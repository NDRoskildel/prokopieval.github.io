Imports System.Collections.Generic

Namespace Yandex.CheckoutVB.V3

    ''' <summary>
    ''' Чек
    ''' </summary>

    Public Class Receipt

        ''' <summary>
        ''' Номер телефона плательщика
        ''' </summary>

        Public Phone As String

        ''' <summary>
        ''' Электронная почта плательщика
        ''' </summary>

        Public Email As String

        ''' <summary>
        ''' Позиция чека, <see cref="V3.ReceiptItem"/>
        ''' </summary>

        Public Items As List(Of ReceiptItem) = New List(Of ReceiptItem)()

        ''' <summary>
        ''' Система налогооблажения, <see cref="V3.TaxSystemCode"/>
        ''' </summary>

        Public TaxSystemCode As TaxSystem?

    End Class

End Namespace
