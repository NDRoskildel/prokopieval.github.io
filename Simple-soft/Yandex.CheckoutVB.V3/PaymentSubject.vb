Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Namespace Yandex.CheckoutVB.V3

    <JsonConverter(GetType(StringEnumConverter))>
    Public Enum PaymentSubject

        ''' <summary>
        ''' Товар
        ''' </summary>

        <EnumMember(Value:="commodity")>
        Commodity

        ''' <summary>
        ''' Подакцизный товар
        ''' </summary>

        <EnumMember(Value:="excise")>
        Excise

        ''' <summary>
        ''' Работа
        ''' </summary>

        <EnumMember(Value:="job")>
        Job

        ''' <summary>
        ''' Услуга
        ''' </summary>

        <EnumMember(Value:="service")>
        Service

        ''' <summary>
        ''' Ставка в азартной игре
        ''' </summary>

        <EnumMember(Value:="gambling_bet")>
        GamblingBet

        ''' <summary>
        ''' Выйгрыш в азартной игре
        ''' </summary>

        <EnumMember(Value:="gambling_prize")>
        GamblingPrize

        ''' <summary>
        ''' Лотерейный билет
        ''' </summary>

        <EnumMember(Value:="lottery")>
        Lottery

        ''' <summary>
        ''' Выйгрыш в лотерее
        ''' </summary>

        <EnumMember(Value:="lottery_prize")>
        LotteryPrize

        ''' <summary>
        ''' Результаты интеллектуальной деятельности
        ''' </summary>

        <EnumMember(Value:="intellectual_activity")>
        IntellectualActivity

        ''' <summary>
        ''' Платеж
        ''' </summary>

        <EnumMember(Value:="payment")>
        Payment

        ''' <summary>
        ''' Агентское вознаграждение
        ''' </summary>

        <EnumMember(Value:="agent_commission")>
        AgentCommission

        ''' <summary>
        ''' Несколько вариантов
        ''' </summary>

        <EnumMember(Value:="composite")>
        Composite

        ''' <summary>
        ''' Другое
        ''' </summary>

        <EnumMember(Value:="another")>
        Another

    End Enum

End Namespace
