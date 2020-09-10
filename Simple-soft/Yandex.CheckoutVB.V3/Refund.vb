Imports System
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    ''' <inheritdoc />
    ''' <summary>
    ''' Информация о возврате
    ''' </summary>

    Public Class Refund

        Inherits NewRefund

        ''' <summary>
        ''' Идентификатор возврата
        ''' </summary>

        Public Id As String

        ''' <summary>
        ''' Статус
        ''' </summary>

        <JsonConverter(GetType(StringEnumConverter))>
        Public Status As PaymentStatus

        Public CreatedAt As DateTime

        Public ReceiptRegistration As ReceiptRegistrationStatus?

    End Class

End Namespace
