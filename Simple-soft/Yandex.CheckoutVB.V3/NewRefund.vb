Imports Newtonsoft.Json

Namespace Yandex.CheckoutVB.V3

    ''' <summary>
    ''' Данные для оформления возврата
    ''' </summary>

    Public Class NewRefund

        ''' <summary>
        ''' Сумма к возврату
        ''' </summary>

        <JsonRequired>
        Public Amount As Amount

        ''' <summary>
        ''' Идентификатор платежа
        ''' </summary>

        <JsonRequired>
        Public PaymentId As String

        ''' <summary>
        ''' Чек, для проведения возврата по ФЗ-54 <see cref="V3.Refund"/>
        ''' </summary>

        Public Receipt As Receipt

        ''' <summary>
        ''' Описание
        ''' </summary>

        Public Description As String

    End Class

End Namespace
