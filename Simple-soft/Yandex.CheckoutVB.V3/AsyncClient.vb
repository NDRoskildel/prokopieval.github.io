Imports System
Imports System.Net.Http
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace Yandex.CheckoutVB.V3

    Public Class AsyncClient

        Public IDisposable As IDisposable

        ReadOnly HttpClient As HttpClient
        ReadOnly DisposeOfHttpClient As Boolean

        ''' <summary>
        ''' Ожидается <paramref name="_HttpClient"/> базовый адрес и заголовок авторизации будет установлен
        ''' </summary>
        ''' <param name="_HttpClient"></param>
        ''' <param name="_DisposeOfHttpClient">
        ''' Избавится от <paramref name="_HttpClient"/> когда он удаляется
        ''' </param>

        Public Sub New(_HttpClient As HttpClient, Optional _DisposeOfHttpClient As Boolean = False)
            HttpClient = _HttpClient
            DisposeOfHttpClient = _DisposeOfHttpClient
        End Sub

        ''' <summary>
        ''' Создание платежа
        ''' </summary>
        ''' <param name="_Payment">Информация о платеже <see cref="V3.NewPayment"/></param>
        ''' <param name="_IdempotenceKey">Idempotence key, позволяет избегать повторных транзакций, 
        ''' для генерации нового оставьте пустым</param>
        ''' <param name="_CancellationToken"><see cref="CancellationToken"/></param>
        ''' <returns><see cref="Payment"/></returns>

        Public Function CreatePaymentAsync(_Payment As NewPayment,
                                           Optional _IdempotenceKey As String = Nothing,
                                           Optional _CancellationToken As CancellationToken = Nothing) As Task(Of Payment)
            Return QueryAsync(Of Payment)(HttpMethod.Post, _Payment, "payments", _IdempotenceKey, _CancellationToken)
        End Function

        ''' <summary>
        ''' Захват платежа
        ''' </summary>
        ''' <param name="_Id">Уникальный идентификатор платежа <see cref="V3.Payment.Id"/></param>
        ''' <param name="_IdempotenceKey">Idempotence key, позволяет избежать повторения транзакций, 
        ''' для генерации нового оставьте пустым</param>
        ''' <param name="_CancellationToken"><see cref="CancellationToken"/></param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function CapturePaymentAsync(_Id As String,
                                            Optional _IdempotenceKey As String = Nothing,
                                            Optional _CancellationToken As CancellationToken = Nothing) As Task(Of Payment)
            Return QueryAsync(Of Payment)(HttpMethod.Post, Nothing, "payments/" & _Id & "/capture",
                                           _IdempotenceKey, _CancellationToken)
        End Function

        ''' <summary>
        ''' Захват платежа, может использоваться для обновления суммы платежа.
        ''' Если Вам не нужно делать какие либо изменения, Вы можете использовать <see cref="CapturePaymentAsync(String, String, CancellationToken)"/>
        ''' </summary>
        ''' <param name="_Payment">Информация о новом платеже</param>
        ''' <param name="_IdempotenceKey">Idempotence key, позволяет избежать повторения транзакций, 
        ''' оставьте пустым для генерации нового</param>
        ''' <param name="_CancellationToken"><see cref="CancellationToken"/></param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function CapturePaymentAsync(_Payment As Payment,
                                            Optional _IdempotenceKey As String = Nothing,
                                            Optional _CancellationToken As CancellationToken = Nothing) As Task(Of Payment)
            Return QueryAsync(Of Payment)(HttpMethod.Post, _Payment, "payments/" & _Payment.Id & "/capture",
                                          _IdempotenceKey, _CancellationToken)
        End Function

        ''' <summary>
        ''' Запрос состояния платежа.
        ''' </summary>
        ''' <param name="_Id">Уникальный идентификатор платежа <see cref="V3.Payment.Id"/></param>
        ''' <param name="_CancellationToken"><see cref="CancellationToken"/></param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function GetPaymentAsync(_Id As String,
                                        Optional _CancellationToken As CancellationToken = Nothing) As Task(Of Payment)
            Return QueryAsync(Of Payment)(HttpMethod.Get, Nothing, "payments/" & _Id, Nothing, _CancellationToken)
        End Function

        ''' <summary>
        ''' Отмена платежа.
        ''' </summary>
        ''' <param name="_Id">Уникальный идентификатор платежа <see cref="V3.Payment.Id"/></param>
        ''' <param name="_IdempotenceKey">Idempotence key, позволяет избежать повторения транзакций, 
        ''' для генерации ноаого оставьте пустым</param>
        ''' <param name="_CancellationToken"><see cref="CancellationToken"/></param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function CancelPaymentAsync(_Id As String,
                                           Optional _IdempotenceKey As String = Nothing,
                                           Optional _CancellationToken As CancellationToken = Nothing) As Task(Of Payment)
            Return QueryAsync(Of Payment)(HttpMethod.Post, Nothing, "payments/" & _Id & "/cancel",
                                          _IdempotenceKey, _CancellationToken)
        End Function

        ''' <summary>
        ''' Создание возврата.
        ''' </summary>
        ''' <param name="_Refund">Информация о возврате <see cref="V3.Refund"/></param>
        ''' <param name="_IdempotenceKey">Idempotence key, позволяет избежать повторения транзакций, 
        ''' для генерации нового оставьте пустым</param>
        ''' <param name="_CancellationToken"><see cref="CancellationToken"/></param>
        ''' <returns><see cref="V3.Payment"/></returns>

        Public Function CreateRefundAsync(_Refund As NewRefund,
                                          Optional _IdempotenceKey As String = Nothing,
                                          Optional _CancellationToken As CancellationToken = Nothing) As Task(Of Payment)
            Return QueryAsync(Of Payment)(HttpMethod.Post, _Refund, "refunds", _IdempotenceKey, _CancellationToken)
        End Function

        ''' <summary>
        ''' Получение информации о возврате.
        ''' </summary>
        ''' <param name="_Id">Уникальный идентификатор возврата <see cref="V3.Refund.Id"/></param>
        ''' <param name="_CancellationToken"><see cref="CancellationToken"/></param>
        ''' <returns><see cref="V3.Refund"/></returns>

        Public Function GetRefundAsync(_Id As String,
                                       Optional _CancellationToken As CancellationToken = Nothing) As Task(Of Payment)
            Return QueryAsync(Of Payment)(HttpMethod.Post, Nothing, "refunds/" & _Id, Nothing, _CancellationToken)
        End Function

        Private Async Function QueryAsync(Of T)(_HttpMethod As HttpMethod,
                                                _Body As Object,
                                                _Url As String,
                                                _IdempotenceKey As String,
                                                _CancellationToken As CancellationToken) As Task(Of T)
            Dim Request As Object = CreateRequest(_HttpMethod,
                                                  _Body,
                                                  _Url,
                                                  If(_IdempotenceKey, _IdempotenceKey, Guid.NewGuid().ToString()))
            Dim Response As Object = Await HttpClient.SendAsync(Request, _CancellationToken)
            Dim ResponseData As Object = If(Response.Content = Nothing, Nothing, Await Response.Content.ReadAsStringAsync())
            Return Client.ProcessResponse(Of T)(Response.StatusCode,
                                                ResponseData,
                                                If(Response.Content, Response.Content,
                                                    If(Response.Headers, Response.Headers,
                                                        If(Response.ContentType, Response.ContentType,
                                                            If(Response.MediaType, Response.MediaType, String.Empty)))))
        End Function

        Private Function CreateRequest(_Method As HttpMethod,
                                       _Body As Object,
                                       _Url As String,
                                       _IdempotenceKey As String) As HttpRequestMessage
            Dim Request As Object = New HttpRequestMessage(_Method, _Url)
            If _Body IsNot Nothing Then
                Request.Content = New StringContent(Serializer.SerializeObject(_Body), Encoding.UTF8, Client.ApplicationJson)
            End If
            If Not String.IsNullOrEmpty(_IdempotenceKey) Then
                Request.Headers.Add("Idempotence-Key", _IdempotenceKey)
            End If
            Return Request
        End Function

        Public Sub Dispose()
            If DisposeOfHttpClient Then
                HttpClient.Dispose()
            End If
        End Sub

    End Class

End Namespace
