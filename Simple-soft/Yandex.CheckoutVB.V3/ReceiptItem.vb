Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    ''' <summary>
    ''' Позиция чека
    ''' <seealso cref="V3.Receipt"/>
    ''' </summary>

    Public Class ReceiptItem

        ''' <summary>
        ''' Наименование товара
        ''' </summary>

        Public Description As String

        ''' <summary>
        ''' Количество
        ''' </summary>

        Public Quantity As Decimal

        ''' <summary>
        ''' Стоимость
        ''' </summary>

        Public Amount As Amount

        ''' <summary>
        ''' Код налога, <see cref="V3.VatCode"/>
        ''' </summary>

        Public VatCode As VatCode

        ''' <summary>
        ''' Признак предмета расчета, <see cref="V3.PaymentSubject"/>
        ''' </summary>

        <JsonConverter(GetType(StringEnumConverter))>
        Public PaymentSubject As PaymentSubject?

        ''' <summary>
        ''' Признак способа расчета <see cref="V3.PaymentMode"/>
        ''' </summary>

        <JsonConverter(GetType(StringEnumConverter))>
        Public PaymentMode As PaymentMode?

    End Class

End Namespace
