Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Namespace Yandex.CheckoutVB.V3

    Public Class Serializer

        Public Shared Function DeserializeObject(Of T)(ByVal data As String) As T
            Return JsonConvert.DeserializeObject(Of T)(data, SerializerSettings)
        End Function

        Public Shared Function SerializeObject(ByVal value As Object) As String
            Return JsonConvert.SerializeObject(value, SerializerSettings)
        End Function

        Private Shared ReadOnly ContractResolver As IContractResolver = New DefaultContractResolver() With {
            .NamingStrategy = New SnakeCaseNamingStrategy()
        }

        Private Shared ReadOnly SerializerSettings As JsonSerializerSettings = New JsonSerializerSettings() With {
            .ContractResolver = ContractResolver,
            .Formatting = Formatting.None,
            .NullValueHandling = NullValueHandling.Ignore
        }

    End Class

End Namespace
