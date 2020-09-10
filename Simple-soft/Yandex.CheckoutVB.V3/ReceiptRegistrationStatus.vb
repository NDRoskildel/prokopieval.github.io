Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    ''' <summary>
    ''' Состояние отправки чека по ФЗ-54
    ''' </summary>

    <JsonConverter(GetType(StringEnumConverter))>
    Public Enum ReceiptRegistrationStatus

        <EnumMember(Value:="pending")>
        Pending = 1
        <EnumMember(Value:="succeeded")>
        Succeeded
        <EnumMember(Value:="canceled")>
        Canceled

    End Enum

End Namespace
