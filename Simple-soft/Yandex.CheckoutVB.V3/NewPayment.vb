Imports System.Collections.Generic

Namespace Yandex.CheckoutVB.V3

    ''' <summary>
    ''' Исходные данные для создания платежа.
    ''' </summary>

    Public Class NewPayment

        ''' <summary>
        ''' Сумма платежа.
        ''' Иногда партнеры Яндекс.Кассы берут с пользователя дополнительную комиссию, 
        ''' которая не входит в эту сумму.
        ''' </summary>

        Public Amount As Amount

        ''' <summary>
        ''' Описание транзакции, которое Вы увидите в личном кабинете Яндекс.Кассы, а пользователь - при оплате.
        ''' Например: "Оплата заказа №5 для useer_name@yandex.ru"
        ''' </summary>

        Public Description As String

        ''' <summary>
        ''' Автоматический прием поступившего платежа.
        ''' </summary>

        Public Capture As Boolean?

        ''' <summary>
        ''' Данные, необходимы для инициации выбранного сценария подтверждения платежа пользователем.
        ''' </summary>

        Public Confirmation As Confirmation = New Confirmation

        ''' <summary>
        ''' Дополнительные данные, которые можно передать вместе с запросом 
        ''' и получить в ответе от Яндекс.Кассы для реализации внутренней логики.
        ''' </summary>

        Public Metadata As Dictionary(Of String, String)

        ''' <summary>
        ''' Чек для проведения платежа по ФЗ-54 <see cref="V3.Receipt"/>
        ''' </summary>

        Public Receipt As Receipt

        ''' <summary>
        ''' Получатель.
        ''' </summary>

        Public Recipient As Recipient

        Public PaymentToken As String

        Public PaymentMethodId As String

        Public PaymentMethodData As PaymentMethod

        Public SavePaymentMethod As Boolean?

        Public ClientIp As String

        Public Airline As Airline

    End Class

End Namespace
