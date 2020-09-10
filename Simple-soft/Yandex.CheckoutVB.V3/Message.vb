Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    Public Class Message

        Public Type As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Evnt As NewEvent
        Public Payment As Object

    End Class

End Namespace
