Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    <JsonConverter(GetType(StringEnumConverter))>
    Public Enum NewEvent

        <EnumMember(Value:="payment.waiting_for_capture")>
        PaymentWaitingForCapture = 1
        <EnumMember(Value:="payment.succeeded")>
        PaymentSucceeded
        <EnumMember(Value:="payment.canceled")>
        PaymentCanceled
        <EnumMember(Value:="refund.succeeded")>
        RefundSucceeded

    End Enum

End Namespace
