Imports System
Imports System.Net.Http
Imports System.Runtime.CompilerServices

Namespace Yandex.CheckoutVB.V3

    Module ClientExtensions

        <Extension()>
        Function MakeAsync(ByVal _Client As Client) As AsyncClient
            Return New AsyncClient(NewHttpClient(_Client), True)
        End Function

        <Extension()>
        Function MakeAsync(ByVal _Client As Client, ByVal _Timeout As TimeSpan) As AsyncClient
            Dim HttpClient As HttpClient = NewHttpClient(_Client)
            HttpClient.Timeout = _Timeout
            Return New AsyncClient(HttpClient, True)
        End Function

        Private Function NewHttpClient(ByVal _Client As Client) As HttpClient
            Dim HttpClient As HttpClient = New HttpClient With {
                .BaseAddress = New Uri(_Client.ApiUrl)
            }
            HttpClient.DefaultRequestHeaders.Add("Authorization", _Client.Authorization)
            If Not String.IsNullOrEmpty(_Client.UserAgent) Then HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd(_Client.UserAgent)
            Return HttpClient
        End Function

    End Module

End Namespace
