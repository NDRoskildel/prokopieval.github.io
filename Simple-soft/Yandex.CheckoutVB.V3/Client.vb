Imports System
Imports System.Collections.Generic
Imports System.Net
Imports System.IO
Imports System.Text

Namespace Yandex.CheckoutVB.V3

    ''' <summary>
    ''' Yandex.CheckoutVB HTTP API Client
    ''' </summary>

    Public Class Client

        Public UserAgent As String
        Public ApiUrl As String
        Public Authorization As String
        Public TestUri As Uri

        ''' <summary>
        ''' Client - constructor
        ''' </summary>
        ''' <param name="_Shopid">Unique id of the shop</param>
        ''' <param name="_SecretKey">Secret web api key</param>
        ''' <param name="_UserAgent">API URL</param>
        ''' <param name="_ApiUrl">Name of the user agent</param>

        Public Sub New(_Shopid As String,
                       _SecretKey As String,
                       Optional _UserAgent As String = "Yandex.CheckoutVB.V3 .NET Client",
                       Optional _ApiUrl As String = "https://payment.yandex.net/api/v3")
            If String.IsNullOrWhiteSpace(_Shopid) Then
                Throw New ArgumentNullException("Shopid")
            End If
            If String.IsNullOrWhiteSpace(_SecretKey) Then
                Throw New ArgumentNullException("SecretKey")
            End If
            If String.IsNullOrWhiteSpace(_ApiUrl) Then
                Throw New ArgumentNullException("ApiUrl")
            End If
            If Not Uri.TryCreate(_ApiUrl, UriKind.Absolute, TestUri) Then
                Throw New ArgumentException("'" & _ApiUrl & "' is not valid URL.")
            End If
            ApiUrl = _ApiUrl
            If Not ApiUrl.EndsWith("/") Then
                ApiUrl = _ApiUrl & "/"
            End If
            UserAgent = _UserAgent
            Authorization = "Basic " & Convert.ToBase64String(Encoding.UTF8.GetBytes(_Shopid & ":" & _SecretKey))
        End Sub

#Region "Sync"

        ''' <summary>
        ''' Создание платежа.
        ''' </summary>
        ''' <param name="_Payment">Информация о платеже <see cref="V3.NewPayment"/></param>
        ''' <param name="_IdempotenceKey">Idempotence key, для генерации нового используйте 
        ''' пустое значение, нужен чтобы избежать повторения транзакций</param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function CreatePayment(_Payment As NewPayment, Optional _IdempotenceKey As String = Nothing) As Payment
            Return Query(Of Payment)("POST", _Payment, "payments/", _IdempotenceKey)
        End Function

        ''' <summary>
        ''' Подтверждение платежа.
        ''' </summary>
        ''' <param name="_Id">Идентификатор платежа</param>
        ''' <param name="_IdempotenceKey">Idempotence key, нужен, чтобы избежать повторения транзакций, 
        ''' для генерации нового, оставьте пустым</param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function CapturePayment(_Id As String, Optional _IdempotenceKey As String = Nothing) As Payment
            Return Query(Of Payment)("POST", Nothing, "payments/" & _Id & "/capture", _IdempotenceKey)
        End Function

        ''' <summary>
        ''' Подтверждение платежа, может использоваться для изменения суммы платежа.
        ''' Если у Вас нет необходимости делать какие либо изменения в платеже, 
        ''' используйте <see cref="CapturePayment(String, String)"/>
        ''' </summary>
        ''' <param name="_Payment">Информация о платеже <see cref="V3.Payment"/></param>
        ''' <param name="_IdempotenceKey">Idempotence key, нужен, чтобы избежать повторения транзакций, 
        ''' для генерации нового, оставьте пустым</param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function CapturePayment(_Payment As Payment, Optional _IdempotenceKey As String = Nothing) As Payment
            Return Query(Of Payment)("POST", _Payment, "payments/" & _Payment.Id & "/capture", _IdempotenceKey)
        End Function

        ''' <summary>
        ''' Запросить состояние платежа.
        ''' </summary>
        ''' <param name="_Id">Уникальный идентификатор платежа</param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function GetPayment(_Id As String) As Payment
            Return Query(Of Payment)("GET", Nothing, "payments/" & _Id, Nothing)
        End Function

        ''' <summary>
        ''' Отмена платежа.
        ''' </summary>
        ''' <param name="_Id">Уникальный идентификатор платежа</param>
        ''' <param name="_IdempotenceKey">Idempotence key, нужен, чтобы избежать повторения 
        ''' транзакций, для генерации нового оставьте пустым</param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function CancelPayment(_Id As String, Optional _IdempotenceKey As String = Nothing) As Payment
            Return Query(Of Payment)("POST", Nothing, "payments/" & _Id & "/cancel", _IdempotenceKey)
        End Function

        ''' <summary>
        ''' Создать возврат.
        ''' </summary>
        ''' <param name="_Refund">Информация о возврате</param>
        ''' <param name="_IdempotenceKey">Idempotence key, нужен, чтобы избежать повторения транзакций, 
        ''' оставьте пустым, для генерации нового</param>
        ''' <returns><see cref="V3.NewRefund"/></returns>

        Public Function CreateRefund(_Refund As NewRefund, Optional _IdempotenceKey As String = Nothing) As Refund
            Return Query(Of Refund)("POST", _Refund, "refunds/", _IdempotenceKey)
        End Function

        ''' <summary>
        ''' Запрос возврата.
        ''' </summary>
        ''' <param name="_Id">Уникальный идентификатор возврата</param>
        ''' <returns><see cref="V3.NewRefund"/></returns>

        Public Function GetRefund(_Id As String) As Refund
            Return Query(Of Refund)("GET", Nothing, "refunds/" & _Id, Nothing)
        End Function

#End Region

#Region "Parse"

        ''' <summary>
        ''' Парсит HTTP-запрос в объект типа <see cref="V3.Message"/>
        ''' </summary>
        ''' <param name="_RequestHttpMethod">Метод запроса</param>
        ''' <param name="_RequestContentType">Тип содержания</param>
        ''' <param name="_RequestInputStream">Поток ввода</param>
        ''' <returns><see cref="V3.Message"/> или Nothing</returns>

        Public Shared Function ParseMessage(_RequestHttpMethod As String,
                                            _RequestContentType As String,
                                            _RequestInputStream As Stream) As Message
            Return ParseMessage(_RequestHttpMethod, _RequestContentType, ReadToEnd(_RequestInputStream))
        End Function

        ''' <summary>
        ''' Парсит HTTP-запрос в объект типа <see cref="V3.Message"/>
        ''' </summary>
        ''' <param name="_RequestHttpMethod">Метод запроса</param>
        ''' <param name="_RequestContentType">Тип содержания</param>
        ''' <param name="_JsonBody">json-строка</param>
        ''' <returns></returns>

        Public Shared Function ParseMessage(_RequestHttpMethod As String,
                                            _RequestContentType As String,
                                            _JsonBody As String) As Message
            Dim Msg As Message = Nothing
            If _RequestHttpMethod = "POST" And _RequestContentType.StartsWith(ApplicationJson) Then
                Msg = Serializer.DeserializeObject(Of Message)(_JsonBody)
            End If
            Return Msg
        End Function

#End Region

#Region "Helpers"

        Private Shared ReadOnly KnownErrors As HashSet(Of HttpStatusCode) = New HashSet(Of HttpStatusCode) From {
            HttpStatusCode.BadRequest,
            HttpStatusCode.Unauthorized,
            HttpStatusCode.Forbidden,
            HttpStatusCode.NotFound,
            CType(429, HttpStatusCode),
            HttpStatusCode.InternalServerError
        }

        Friend Shared ReadOnly ApplicationJson As String = "application/json"

        Friend Shared Function ProcessResponse(Of T)(ByVal _StatusCode As HttpStatusCode,
                                                     ByVal _ResponseData As String,
                                                     ByVal _ContentType As String) As T

            If _StatusCode <> HttpStatusCode.OK Then
                Throw New YandexCheckoutException(_StatusCode, If(String.IsNullOrEmpty(_ResponseData) Or Not _
                                                  KnownErrors.Contains(_StatusCode) Or Not _
                                                  _ContentType.StartsWith(ApplicationJson),
                                                  New NewError With {
                                                    .Code = _StatusCode.ToString(),
                                                    .Description = _StatusCode.ToString()
                                                  },
                                                  Serializer.DeserializeObject(Of NewError)(_ResponseData)))
            End If

            Return Serializer.DeserializeObject(Of T)(_ResponseData)

        End Function

        Private Function Query(Of T)(_Method As String, _Body As Object, _Url As String, _IdempotenceKey As String) As T
            If String.IsNullOrEmpty(_IdempotenceKey) Then
                _IdempotenceKey = Guid.NewGuid().ToString()
            End If
            Dim Request As HttpWebRequest = CreateRequest(_Method,
                                                          _Body,
                                                          _Url,
                                                          _IdempotenceKey)
            Try
                Dim Response As HttpWebResponse = DirectCast(Request.GetResponse(), HttpWebResponse)
                Dim ResponseStream As Stream = Response.GetResponseStream()
                If ResponseStream Is Nothing Then
                    Throw New InvalidOperationException("Response string is null.")
                End If
                Dim Sr As StreamReader = New StreamReader(ResponseStream)
                Dim ResponseData As String = Sr.ReadToEnd()
                Return ProcessResponse(Of T)(Response.StatusCode, ResponseData, Response.ContentType)
            Catch Ex As WebException
                MsgBox(Ex.Message)
            End Try

        End Function

        Private Function CreateRequest(_Method As String, _Body As Object, _Url As String, _IdempotenceKey As String) As HttpWebRequest
            Dim Request As HttpWebRequest = DirectCast(WebRequest.Create(ApiUrl & _Url), HttpWebRequest)
            Request.Method = _Method
            Request.ContentType = ApplicationJson
            Request.Headers.Add("Authorization", Authorization)

            If Not String.IsNullOrEmpty(_IdempotenceKey) Then
                Request.Headers.Add("Idempotence-Key", _IdempotenceKey)
            End If
            If UserAgent IsNot Nothing Then
                Request.UserAgent = UserAgent
            End If
            If _Body IsNot Nothing Then
                Dim Json As Object = Serializer.SerializeObject(_Body)
                Dim PostBytes As Object = Encoding.UTF8.GetBytes(Json)
                Request.ContentLength = PostBytes.Length
                Dim Stream As Object = Request.GetRequestStream()
                Stream.Write(PostBytes, 0, PostBytes.Length)
            End If
            Return Request
        End Function

        ''' <summary>
        ''' Чтение потока данных.
        ''' </summary>
        ''' <param name="_Stream">Поток данных</param>
        ''' <returns></returns>

        Private Shared Function ReadToEnd(_Stream As Stream) As String
            If _Stream Is Nothing Then
                Return Nothing
            End If
            Dim Reader As StreamReader = New StreamReader(_Stream)
            Return Reader.ReadToEnd()
        End Function

#End Region

    End Class

End Namespace
