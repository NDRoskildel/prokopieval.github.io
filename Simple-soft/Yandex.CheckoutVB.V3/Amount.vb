Imports Newtonsoft.Json

Namespace Yandex.CheckoutVB.V3

    ''' <summary>
    ''' Сумма оплаты
    ''' </summary>

    Public Class Amount

        ''' <summary>
        ''' Значение
        ''' </summary>

        <JsonProperty()>
        Public Value As Decimal

        ''' <summary>
        ''' Три буквы для валюты, например RUB
        ''' </summary>

        Public Currency As String = "RUB"

    End Class

End Namespace
