Imports System.Data
Imports SSCommon

Namespace Prostoysoft

    Partial Public Class OnlinePayment
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim sSQL As String
            Dim sResult As DataTable

            sSQL = "SELECT TOP 1 '' AS Ordinal, 'Программа' AS ProductTitle FROM tblProducts "
            sSQL = sSQL & "UNION ALL "
            sSQL = sSQL & "SELECT TOP 1 0 AS Ordinal, '(Не требуется)' AS ProductTitle FROM tblProducts "
            sSQL = sSQL & "UNION ALL "
            sSQL = sSQL & "SELECT Ordinal, ProductTitle FROM tblProducts "
            sSQL = sSQL & "WHERE ProgramName = '' AND Ordinal <> -1 AND Ordinal <> 0"
            sResult = DbGetDataTableBySql(sSQL, sDbOrConn:="SSClients")
            If DataTableIsOpen(sResult, bRowsCountNotZero:=True) Then
                For i = 1 To sResult.Rows.Count Step 1
                    YandexKassaForm__programm.DataSource = sResult
                    YandexKassaForm__programm.DataTextField = "ProductTitle"
                    YandexKassaForm__programm.DataValueField = "Ordinal"
                    YandexKassaForm__programm.DataBind()
                Next
            End If

        End Sub

    End Class

End Namespace
