Namespace PS.Basket

    Public Class Licenses

        Public License As String
        Public Type As String = "license"

        Public Sub New(Value As String)
            Select Case (Value)
                Case "1"
                    License = "Базовая (1 р.м.)"
                Case "2"
                    License = "Стандартная (3 р.м.)"
                Case "3"
                    License = "Бизнес (5 р.м.)"
                Case "4"
                    License = "Профессиональная (10 р.м.)"
                Case "5"
                    License = "Корпоративная (20 р.м.)"
                Case "6"
                    License = "Вип"
                Case Else
                    License = "Не указана"
            End Select
        End Sub

    End Class

End Namespace
