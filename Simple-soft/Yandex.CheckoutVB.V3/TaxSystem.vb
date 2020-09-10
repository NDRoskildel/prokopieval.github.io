Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    ''' <summary>
    ''' Код системы налогооблажения
    ''' </summary>

    <JsonConverter(GetType(StringEnumConverter))>
    Public Enum TaxSystem

        ''' <summary>
        ''' Общая система налогооблажения
        ''' </summary>

        General = 1

        ''' <summary>
        ''' Упрощенная (УСН, доходы)
        ''' </summary>

        Simplified = 2

        ''' <summary>
        ''' Упрощенная (УСН, доходы минус расходы)
        ''' </summary>

        SimplifiedWithExpenses = 3

        ''' <summary>
        ''' Единый налог на вменяемый доход (ЕНВД)
        ''' </summary>

        Imputed = 4

        ''' <summary>
        ''' Единый сельскохозяйственный налог (ЕСН)
        ''' </summary>

        Agricultural = 5

        ''' <summary>
        ''' Патентная система налогооблажения
        ''' </summary>

        Patent = 6

    End Enum

End Namespace
