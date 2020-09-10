Namespace PS.Basket

    Public Class Services

        Public Service As String
        Public Price As Decimal
        Public Type As String = "service"

        Public Sub New(Value As String)
            Select Case (Value)
                Case "1"
                    Service = "Годовая подписка на обновление"
                    Price = 2000
                Case "2"
                    Service = "Стандартная поддержка"
                    Price = 6000
                Case "3"
                    Service = "Премиум поддержка (квартал)"
                    Price = 5000
                Case "4"
                    Service = "Премиум поддержка (полгода)"
                    Price = 9000
                Case "5"
                    Service = "Премиум поддержка (год)"
                    Price = 18000
                Case "6"
                    Service = "Сеанс связи с ИТ-специалистом"
                    Price = 2400
                Case "7"
                    Service = "Выезд специалиста в офис (2 часа)"
                    Price = 3000
                Case "8"
                    Service = "Составление тех. задания (неделя)"
                    Price = 20000
                Case "9"
                    Service = "Настройка конфигурации (неделя)"
                    Price = 20000
                Case Else
                    Service = "Другое"
                    Price = 0
            End Select
        End Sub
    End Class

End Namespace
