Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    <JsonConverter(GetType(StringEnumConverter))>
    Public Enum VatDataType

        <EnumMember(Value:="calculated")>
        Calculated
        <EnumMember(Value:="untaxed")>
        Untaxed

    End Enum

End Namespace
