Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    <JsonConverter(GetType(StringEnumConverter))>
    Public Enum PaymentStatus

        <EnumMember(Value:="pending")>
        Pending
        <EnumMember(Value:="waiting_for_capture")>
        WaitingForCapture
        <EnumMember(Value:="succeeded")>
        Succeeded
        <EnumMember(Value:="canceled")>
        Canceled

    End Enum

End Namespace
