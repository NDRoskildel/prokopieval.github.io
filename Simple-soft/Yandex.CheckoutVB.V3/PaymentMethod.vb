Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    Public Class PaymentMethod

        <JsonConverter(GetType(StringEnumConverter))>
        Public Type As PaymentMethodType

        Public Id As String
        Public Saved As Boolean
        Public Title As String
        Public Phone As String
        Public Login As String
        Public PaymentPurpose As String
        Public AccountNumber As String
        Public PaymentMethodToken As String
        Public GoogleTransactionId As String
        Public PaymentData As String
        Public Card As Card
        Public VatData As VatData

#Region "Helpers"

        Public Shared Function Alfabank(_Login As String) As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.Alfabank,
                .Login = _Login
            }
        End Function

        Public Shared Function ApplePay(_PaymentData As String) As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.ApplePay,
                .PaymentData = _PaymentData
            }
        End Function

        Public Shared Function B2BSberbank(_PaymentPurpose As String, _VatData As VatData) As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.B2BSberbank,
                .PaymentPurpose = _PaymentPurpose,
                .VatData = _VatData
            }
        End Function

        Public Shared Function BankCard(_Card As Card) As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.BankCard,
                .Card = _Card
            }
        End Function

        Public Shared Function Cash(_Phone As String) As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.Cash,
                .Phone = _Phone
            }
        End Function

        Public Shared Function GooglePay(_PaymentMethodToken As String, _GoogleTransactionId As String) As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.GooglePay,
                .PaymentMethodToken = _PaymentMethodToken,
                .GoogleTransactionId = _GoogleTransactionId
            }
        End Function

        Public Shared Function Installments() As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.Installments
            }
        End Function

        Public Shared Function MobileBalance(_Phone As String) As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.MobileBalance,
                .Phone = _Phone
            }
        End Function

        Public Shared Function Qiwi(_Phone As String) As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.Qiwi,
                .Phone = _Phone
            }
        End Function

        Public Shared Function Sberbank(_Phone As String) As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.Sberbank,
                .Phone = _Phone
            }
        End Function

        Public Shared Function Webmoney() As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.Webmoney
            }
        End Function

        Public Shared Function YandexMoney() As PaymentMethod
            Return New PaymentMethod() With {
                .Type = PaymentMethodType.YandexMoney
            }
        End Function

#End Region

    End Class

End Namespace
