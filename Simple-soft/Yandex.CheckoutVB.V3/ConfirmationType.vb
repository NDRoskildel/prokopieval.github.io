Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    <JsonConverter(GetType(StringEnumConverter))>
    Public Enum ConfirmationType

        <EnumMember(Value:="redirect")>
        Redirect
        <EnumMember(Value:="external")>
        External

    End Enum

End Namespace
