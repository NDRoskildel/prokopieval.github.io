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

Partial Class Info2
    Inherits System.Web.UI.Page

    '// EVENTS ///////////////////////////////////////////////////////////////////////////////////////////////

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'On Error Resume Next

        Dim dtA As DataTable, oRow As HtmlTableRow, oCell As HtmlTableCell, i As Integer, sProductTitle As String, sProduct As String

        dtA = DbGetDataTableBySql("SELECT * FROM tblProducts WHERE Ordinal > 0 ORDER BY Ordinal")

        For i = 0 To dtA.Rows.Count - 1 'cycle on records
            sProductTitle = CStr(dtA.Rows(i)("ProductTitle")) 'eg "Учет клиентов"
            sProduct = CStr(dtA.Rows(i)("Product")) 'eg "ClientsCount"

            oRow = New HtmlTableRow

            oCell = New HtmlTableCell
            oCell.InnerHtml = CStr(dtA.Rows(i)("Ordinal")) & "."
            oRow.Cells.Add(oCell)

            oCell = New HtmlTableCell
            oCell.Attributes.Add("class", "CPrg")
            oCell.InnerHtml = "<a href=""" & sProduct & IIf(sProduct = "SimpleSite", ".aspx", ".htm") & """ target=""_parent"">" & sProductTitle & "</a>"
            oRow.Cells.Add(oCell)

            oCell = New HtmlTableCell
            oCell.Attributes.Add("class", "CVer")
            oCell.InnerHtml = CStr(dtA.Rows(i)("ProductVersion"))
            oRow.Cells.Add(oCell)

            oCell = New HtmlTableCell
            oCell.Attributes.Add("class", "CDate")
            oCell.InnerHtml = CStr(dtA.Rows(i)("VersionDate"))
            oRow.Cells.Add(oCell)

            oCell = New HtmlTableCell
            oCell.Attributes.Add("class", "CDis")
            oCell.InnerHtml = "<a href=""" & sProduct & ".msi" & """ target=""_parent"">Скачать</a>"
            oRow.Cells.Add(oCell)

            oCell = New HtmlTableCell
            oCell.Attributes.Add("class", "CUpd")
            oCell.InnerHtml = IIf(sProduct = "SimpleSite", "<img src=""Images/No.png"" alt="""" border=""0"" />", "<a href=""" & sProduct & "Update.zip"" target=""_parent"">Скачать</a>")
            oRow.Cells.Add(oCell)

            tblProducts.Rows.Add(oRow)
        Next
    End Sub

End Class
