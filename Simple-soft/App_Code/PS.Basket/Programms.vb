Namespace PS.Basket

    Public Class Programms

        Public Programm As String
        Public Type As String = "programm"

        Public Sub New(Value As String)
            Select Case (Value)
                Case "1"
                    Programm = "Учет клиентов"
                Case "2"
                    Programm = "Склад и торговля"
                Case "3"
                    Programm = "Учет компьютеров"
                Case "4"
                    Programm = "Учет пациентов"
                Case "5"
                    Programm = "Архив документов"
                Case "6"
                    Programm = "Учет посетителей"
                Case "7"
                    Programm = "Управление проектами"
                Case "8"
                    Programm = "Учет книг"
                Case "9"
                    Programm = "Мои диски"
                Case "10"
                    Programm = "Кулинарные рецепты"
                Case "11"
                    Programm = "Анализ результатов поиска"
                Case "12"
                    Programm = "Простой сайт"
                Case "13"
                    Programm = "PsPhone"
                Case "14"
                    Programm = "PsMobile"
                Case "15"
                    Programm = "PsMobileScan"
                Case Else
                    Programm = "Не указана"
            End Select
        End Sub

    End Class

End Namespace
