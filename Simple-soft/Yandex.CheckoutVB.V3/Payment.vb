Imports System

Namespace Yandex.CheckoutVB.V3

    ''' <inheritdoc />
    ''' <summary>
    ''' Информация о платеже.
    ''' </summary>

    Public Class Payment

        Inherits NewPayment

        Public Id As String
        Public Status As PaymentStatus
        Public Paid As Boolean
        Public CreatedAt As DateTime
        Public ReceiptRegistration As ReceiptRegistrationStatus?
        Public CapturedAt As DateTime?
        Public ExpiresAt As DateTime?
        Public PaymentMethod As PaymentMethod
        Public Test As Boolean
        Public RefundedAmount As Amount
        Public CancellationDetails As CancellationDetails
        Public AuthorizationDetails As AuthorizationDetails

    End Class

End Namespace
