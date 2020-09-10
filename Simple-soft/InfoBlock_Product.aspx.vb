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

Partial Class InfoBlock_Product
    Inherits System.Web.UI.Page

    '// EVENTS ///////////////////////////////////////////////////////////////////////////////////////////////

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''On Error Resume Next

        'Dim sPage As String = "", sProduct As String, sProductTitle As String, sProductPrice As String, sProductVersion As String, sVersionDate As String
        'Dim dtA As DataTable

        'If Not (Request.UrlReferrer Is Nothing) Then
        '    sPage = AfterSubstrRev(Request.UrlReferrer.ToString, "/")
        'End If
        'sProduct = BeforeSubstr(sPage, ".") 'eg "ClientsCount" or "VisitorsCount"
        'If sProduct = "" Then Exit Sub

        'dtA = DbGetDataTableBySql("SELECT * FROM tblProducts WHERE Product = " & Quotes(sProduct))

        'If DataTableIsOpen(dtA) Then
        '    sProductTitle = GetValid(dtA.Rows(0)("ProductTitle"))
        '    sProductPrice = dtA.Rows(0)("Price")
        '    sProductVersion = GetValid(dtA.Rows(0)("ProductVersion"))
        '    sVersionDate = GetValid(dtA.Rows(0)("VersionDate"))
        '    If IsDate(sVersionDate) Then
        '        sVersionDate = Format(CDate(sVersionDate), "dd.MM.yyyy")
        '    End If

        '    If sProduct = "SimpleSite" Then
        '        lblProduct.Text = "Веб-система """ & sProductTitle & """"
        '        lblProduct.Font.Size = 16
        '        lblProductDescription.Text = "Веб-интерфейс к любой конфигурации"
        '        lblProductDescription.ToolTip = "построенной на базе наших программ для Windows"
        '    Else
        '        lblProduct.Text = "Программа """ & sProductTitle & """"
        '    End If
        '    lblProductPrice.Text = sProductPrice & " руб."
        '    lblProductVersion.Text = "Версия " & sProductVersion & " от " & sVersionDate '& " (СУБД MS Access или MS SQL Server)"
        'End If

    End Sub

End Class
