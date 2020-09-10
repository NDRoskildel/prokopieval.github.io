Imports System
Imports System.Net

Namespace Yandex.CheckoutVB.V3

    <Serializable>
    Public Class YandexCheckoutException

        Inherits Exception

        Public StatusCode As HttpStatusCode

        Public Err As NewError

        Public Sub New(_StatusCode As HttpStatusCode, _Err As NewError)
            MyBase.New(_Err.Description)
            StatusCode = _StatusCode
            Err = _Err
        End Sub

    End Class

End Namespace
