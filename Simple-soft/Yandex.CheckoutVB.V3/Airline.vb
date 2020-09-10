Imports System.Collections.Generic

Namespace Yandex.CheckoutVB.V3

    Public Class Airline

        Public BookingReference As String
        Public TicketNumber As String
        Public Passengers As List(Of Passenger) = New List(Of Passenger)()
        Public Legs As List(Of Leg) = New List(Of Leg)()

    End Class

End Namespace