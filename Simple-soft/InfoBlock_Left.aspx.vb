'<moduleinfo>
'   Creator: © Ivan Abramov "Простой софт"
'   Created: 2013-04-18
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

Partial Class InfoBlock_Left
    Inherits System.Web.UI.Page

    '// EVENTS ///////////////////////////////////////////////////////////////////////////////////////////////

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'On Error Resume Next

        Dim sPage As String = "", dtA As DataTable, oRow As HtmlTableRow, oCell As HtmlTableCell, i As Integer, sNewsDate As String, sNewsTitle As String

        If Not (Request.UrlReferrer Is Nothing) Then
            sPage = AfterSubstrRev(Request.UrlReferrer.ToString, "/")
        End If
        If sPage = "index.htm" Then
            Debug.Assert(True)
        ElseIf EqualsAny(sPage, "programs.htm", "download.htm") Then '', "prices.htm") Then
            tblPrograms.Visible = False
            tblConfigurations.Visible = False
        End If

        dtA = DbGetDataTableBySql("SELECT * FROM tblNews ORDER BY ID Desc")

        For i = 0 To dtA.Rows.Count - 1 'cycle on records
            sNewsDate = CStr(dtA.Rows(i)("NewsDate")) 'eg "Учет клиентов"
            sNewsTitle = CStr(dtA.Rows(i)("NewsTitle")) 'eg "ClientsCount"

            oRow = New HtmlTableRow

            oCell = New HtmlTableCell
            oCell.InnerHtml = "<b>" & sNewsDate & "</b><br />" & sNewsTitle
            oRow.Cells.Add(oCell)

            tblNews.Rows.Add(oRow)
        Next

        'SetAllLinksParent(Page.Controls)
    End Sub

    'Private Sub SetAllLinksParent(oControlsCollection As Object)
    '    Dim oEach As Object, sTypeName As String
    '    For Each oEach In Page.Controls
    '        sTypeName = TypeName(oEach)
    '        If sTypeName Like "HTMLAnchor*" Then
    '            Debug.Assert(True)
    '        End If

    '        If oEach.Controls.Count > 0 Then
    '            SetAllLinksParent(oEach.Controls) 'recur
    '        End If
    '    Next
    'End Sub
End Class
