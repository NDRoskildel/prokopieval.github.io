'<moduleinfo>
'   Creator: © Ivan Abramov "Простой софт"
'   Created: 2012-10-09
'   Description: 
'</moduleinfo>

Option Explicit On
Option Strict Off

Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports System.Web.UI.WebControls
Imports Microsoft.VisualBasic
Imports SSCommon

Partial Class Upload
    Inherits System.Web.UI.Page

    Private m_dtSource As DataTable
    Private m_sFolder As String

    '// EVENTS ///////////////////////////////////////////////////////////////////////////////////////////////

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oFile As HttpPostedFile, sShortFile As String

        ''m_sFolder = Session("AppFolder") & "\App_Data\"
        m_sFolder = "C:\inetpub\wwwroot\SimpleSite\App_Data\"

        If Not Page.IsPostBack Then
            DoQuery()
        Else
            If Not (fupFile.PostedFile Is Nothing) AndAlso fupFile.PostedFile.ContentLength > 0 Then
                oFile = fupFile.PostedFile
                sShortFile = GetShortFileName(oFile.FileName)

                If LCase(oFile.FileName) Like "*.mdb" Then
                    oFile.SaveAs(BuildPath(m_sFolder, sShortFile))

                    DoQuery() 'fot the uploaded file to be visible

                    lblMessage.Text = "Файл загружен<br /><br />"
                Else
                    lblMessage.Text = "Загружать можно только файлы .mdb<br /><br />"
                End If
            End If
        End If

        'AddClientScripts()
    End Sub

    '// grdFiles //

    Protected Sub grdFiles_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdFiles.ItemDataBound
        Dim dtSource As DataTable, imgFileIcon As WebControls.Image, lnkLink As HyperLink, r As Integer, sObjectType As String

        dtSource = grdFiles.DataSource
        If dtSource Is Nothing Then Exit Sub

        r = e.Item.ItemIndex 'row index
        Select Case e.Item.ItemType
            Case ListItemType.Item, ListItemType.AlternatingItem, ListItemType.SelectedItem
                imgFileIcon = e.Item.Cells(1).Controls(1)
                sObjectType = dtSource.Rows(r)("ObjectType").ToString
                If imgFileIcon.ImageUrl = "" Then
                    imgFileIcon.ImageUrl = IIf(sObjectType = "Folder", "Images\Folder.gif", "Images\File.gif")
                    imgFileIcon.AlternateText = IIf(sObjectType = "Folder", "Папка", "Файл")
                    imgFileIcon.ToolTip = imgFileIcon.AlternateText
                End If

                If sObjectType = "Folder" Then
                    lnkLink = e.Item.Cells(2).Controls(0)
                    lnkLink.NavigateUrl = Request.Path
                    lnkLink.Attributes.Add("onclick", "return GoToFolder('" & lnkLink.Text & "');")
                End If
        End Select
    End Sub

    '// MAIN BUTTONS /////////////////////////////////////////////////////////////////////////////////////////

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sCheckedFiles As String, sDoNotTouchEnum As String, sResult As String
        sCheckedFiles = GetCheckedByGrid(grdFiles, "|", 0, 2) 'get eg "111.doc|222.doc|333.doc"
        sDoNotTouchEnum = "BooksCount.mdb;ClientsCount.mdb;CompCount.mdb;CookRecepts.mdb;DemoDatabaseWeb.mdb;DocumentsCount.mdb;FindResults.mdb;MyDiscs.mdb;PatientsCount.mdb;ProductsCount.mdb;ProjectsCount.mdb;VisitorsCount.mdb"
        sResult = DeleteFilesByLine(m_sFolder, sCheckedFiles, "|", sDoNotTouchEnum) 'DELETING
        If MyCBool(sResult) Then 'if at least one was deleted
            DoQuery()
            lblMessage.Text = "Отмеченные файлы удалены<br /><br />"
        End If
    End Sub

    Protected Sub btnUpload_Click(sender As Object, e As System.EventArgs) Handles btnUpload.Click
        'no code
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("SimpleSite.aspx", False) 'Server.Transfer analog
    End Sub

    '// LOCAL PROCEDURAS /////////////////////////////////////////////////////////////////////////////////////

    Private Sub DoQuery()
        On Error Resume Next

        m_dtSource = GetFilesInFolderDataTable(m_sFolder, sFilesPattern:="*.mdb") 'C:\Inetpub\wwwroot\Simple-soft & \App_Data\

        'dtFiles = m_dsSource.Tables("Files")
        'If EndsWith(sFolder, "\..") Then 'if eg "C:\Inetpub\wwwroot\SimpleSite\Documents\Sub\..", that is move to upper level
        '    sFolder = RemoveEndSubstr(sFolder, "\..") 'remove dots
        '    sFolder = BeforeSubstrRev(sFolder, "\") & "\" 'remove last folder (to move to upper level)
        '    Me.Folder = sFolder
        'End If
        'bMoveUpVisible = Not EqualsAny(sFolder, Session("DocumentsFolder"), Session("TemplatesFolder"))
        'If bMoveUpVisible Then
        '    drRow = dtFiles.NewRow
        '    drRow("ObjectType") = "Folder"
        '    drRow("FileName") = ".."
        '    dtFiles.Rows.InsertAt(drRow, 0) 'insert row with dots in the beginning
        'End If
        grdFiles.DataSource = m_dtSource
        grdFiles.DataBind() 'refresh grid

        'If Me.Folder = "DocumentsFolder" Or Me.Folder = Session("DocumentsFolder") Then
        '    lblPageName.Text = "Папка с документами"
        'ElseIf Me.Folder = "TemplatesFolder" Or Me.Folder = Session("TemplatesFolder") Then
        '    lblPageName.Text = "Папка с шаблонами документов"
        'Else
        '    lblPageName.Text = Me.Folder
        'End If
    End Sub

End Class
