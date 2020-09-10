'//////////////////////////////////////////////////
'<moduleinfo>
'   Creator: Ivan Abramov
'   Created: 2012-02-13
'   Description: for sending emails and writing into db
'</moduleinfo>
'//////////////////////////////////////////////////

Option Explicit On
Option Strict Off

Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Net
Imports System.Data
Imports System.Data.OleDb
Imports SSCommon

Partial Class sendform
    Inherits System.Web.UI.Page

    Private m_sFormType As String
    Private m_sPageFrom As String
    Private m_sSmtpPassword As String = "ambalwecdxnbkaqs"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sFormContent As String, sMsg As String, sCompany As String, sCity As String, sComments As String, sProduct As String, iFilled As Integer, sInertResult As String, sResult As String

        m_sFormType = Request.QueryString("formtype") 'get "OrderForm" or "SupportForm" or "ConfigForm" or "GiveMeLinkSecurityCompany" or "PsPrintCallMeOrder"
        'Response.Write(m_sFormType)

        If Not Request.UrlReferrer Is Nothing Then
            m_sPageFrom = Request.UrlReferrer.AbsoluteUri
        End If

        '<ANTISPAM
        sCompany = Request.Form("Company")
        If Contains(LCase(sCompany), "google") Then
            Exit Sub 'it's probably spam
        End If
        sCity = Request.Form("City")
        If Contains(LCase(sCity), "new york") Then
            Exit Sub 'it's probably spam
        End If
        sComments = Request.Form("Comments")
        If sComments > "" Then
            If Not (sComments Like "*[А-я]*") Then
                If sComments Like "*[A-z]*" Then
                    Exit Sub 'it's probably spam
                End If
            End If
        End If

        'sFormContent = getFormContent(Request)
        'If sFormContent > "" Then
        '    If sFormContent Like "*[А-я]*" Then

        '    End If
        'End If
        '/>

        If m_sFormType = "OrderForm" Then 'Request
            DoOrderForm()

        ElseIf m_sFormType = "ProjectForm" Or m_sFormType = "ConfigForm" Then
            DoProjectForm()

        ElseIf m_sFormType = "SupportForm" Or m_sFormType = "SupportForm2" Then
            DoSupportForm(m_sFormType)

        ElseIf m_sFormType = "PartnerLogin" Then
            DoPartnerLogin()
        ElseIf m_sFormType = "ClientLogin" Then
            DoClientLogin()

        ElseIf m_sFormType Like "*CallMeOrder" Or m_sFormType = "CallToActionForm" Then
            DoCallMeOrder()

        ElseIf m_sFormType Like "GiveMeLink*" Then 'eg "GiveMeLinkClientsCount" or "GiveMeLinkTours"
            sProduct = Mid(m_sFormType, 11) 'eg "Tours"

            DoGiveMeLink(sProduct)

        ElseIf m_sFormType = "PartnerRegister" Then
            DoPartnerRegister()

        ElseIf m_sFormType = "ReviewForm" Then
            DoResponseForm()

        ElseIf m_sFormType = "OrderSite" Then
            DoOrderSite()

            'ElseIf m_sFormType = "SitesQuestionForm" Then
            '    DoSitesQuestionForm()

        ElseIf m_sFormType = "ProstoysoftComOrderForm" Then
            DoProstoysoftComOrderForm()

        ElseIf m_sFormType = "ProductionKitchen" Then
            DoProductionKitchen()

        ElseIf UCase(m_sFormType) Like "PSPRINT*" Then
            DoPsPrintOrder()

        ElseIf LCase(m_sFormType) = "chudosoft" Then
            DoChudosoftFormOrder()
        ElseIf LCase(m_sFormType) = "bestps" Then
            DoBestpsFormOrder()

        Else
            sFormContent = GetFormContent(Request, vbCr, iFilledCount_out:=iFilled) 'vbCrLf - проблема  ''"; " - OK
            If iFilled > 0 Then
                sFormContent = sFormContent & vbCr & "Filled " & iFilled & " fields."

                '1. WRITE IN DB
                sInertResult = DoInsertIntoDb(sTable:="tblOrders", sOrderDate:="NOW", sComments:=sFormContent)

                '2. SEND EMAIL
                sResult = SendMail("info@prostoysoft.ru; sale@simple-soft.ru", "prostoysoft@yandex.ru", "", "Заполнена форма " & m_sFormType, sFormContent, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)

                '3. MESSAGE ON PAGE
                sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
                If m_sFormType = "ProstoysoftComOrderForm" Then
                    sMsg = sMsg & "The form was sent. Thank you for your order.<br />We will contact you.<br /><a href=" & m_sPageFrom & ">Return...</a>"
                Else
                    sMsg = sMsg & "Форма отправлена. Спасибо за вашу заявку.<br />Мы обязательно с вами свяжемся.<br /><a href=" & m_sPageFrom & ">Вернуться...</a>"
                End If
                sMsg = sMsg & "</p>"
                Response.Write(sMsg)
            End If
        End If
    End Sub

    Protected Sub DoProstoysoftComOrderForm()
        On Error Resume Next

        Dim sFormContent As String, sInertResult As String, sResult As String, sMsg As String, iFilled As Integer

        sFormContent = GetFormContent(Request, vbCr, iFilledCount_out:=iFilled) 'vbCrLf - проблема
        If iFilled > 0 Then
            sFormContent = sFormContent & vbCr & "Filled " & iFilled & " fields."

            '1. WRITE IN DB
            sInertResult = DoInsertIntoDb(sTable:="tblOrders", sOrderDate:="NOW", sComments:=sFormContent)

            '2. SEND EMAIL
            sResult = SendMail("info@prostoysoft.ru; sale@simple-soft.ru", "prostoysoft@yandex.ru", "", "Заполнена форма " & m_sFormType, sFormContent, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)

            '3. MESSAGE ON PAGE
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            If m_sFormType = "ProstoysoftComOrderForm" Then
                sMsg = sMsg & "The form was sent. Thank you for your order.<br />We will contact you.<br /><a href=" & m_sPageFrom & ">Return...</a>"
            Else
                sMsg = sMsg & "Форма отправлена. Спасибо за вашу заявку.<br />Мы обязательно с вами свяжемся.<br /><a href=" & m_sPageFrom & ">Вернуться...</a>"
            End If
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)
        End If
    End Sub

    Protected Sub DoChudosoftFormOrder()
        Dim sSecretPart As String, sMsg As String, sResult As String, sTo As String
        Dim sSubject As String, sMessage As String, sUserName As String
        Dim sUserPhone As String, sUserEmail As String, sFormName As String, sSelectLicense As String
        Dim dListLicense(6) As String, sSQL As String, iAffected As Integer, sError As String

        dListLicense = {"Лицензия ""Базовая"" - 3000 руб. (1 рабочее место)",
                           "Лицензия ""Стандарт"" - 9000 руб. (3 рабочих места)",
                           "Лицензия ""Бизнес"" - 15000 руб. (5 рабочих мест)",
                           "Лицензия ""ПРО"" - 20000 руб. (10 рабочих мест)",
                           "Лицензия ""КОРП"" - 25000 руб. (20 рабочих мест)",
                           "Лицензия ""ВИП"" - 34900 руб. (без ограничений)"}
        sUserName = ""
        sUserPhone = ""
        sUserEmail = ""
        sSelectLicense = ""
        sError = ""

        sFormName = Request.Form("form-name")
        sSecretPart = Request.Form("js-inp-field")
        If sFormName = "user-form" Then
            sUserName = Request.Form("user-name")
            sUserPhone = Request.Form("user-phone")
            sUserEmail = Request.Form("user-email")
        ElseIf sFormName = "order-form" Then
            sUserName = Request.Form("order-form__name")
            sUserPhone = Request.Form("order-form__phone")
            sUserEmail = Request.Form("order-form__email")
            sSelectLicense = dListLicense(Request.Form("order-form__select-license") - 1)
        End If

        If sSecretPart = "ProstoySoft" Then
            sTo = "info@prostoysoft.ru" '"roman.a@simple-soft.ru" 

            sSubject = "Заполнена форма на сайта chudosoft.ru"
            sMessage = "Отправка формы с сайта chudosoft.ru, указаны следующие данные: " & vbCrLf
            sMessage = sMessage & "Имя: " & sUserName & vbCrLf
            sMessage = sMessage & "Телефон: " & sUserPhone & vbCrLf
            sMessage = sMessage & "Email: " & sUserEmail & vbCrLf
            If sSelectLicense <> "" Then
                sMessage = sMessage & "Выбранная лицензия: " & sSelectLicense & vbCrLf
            End If
            sResult = SendMail(sTo, "prostoysoft@yandex.ru", "", sSubject, sMessage, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=True)

            sSQL = "INSERT INTO tblOrders (OrderDate, Fio, Email, Phone, Comments) VALUES ("
            sSQL = sSQL & AbsDateTimeFormat(Now, "#") & ", "
            sSQL = sSQL & Quotes(sUserName) & ", "
            sSQL = sSQL & Quotes(sUserEmail) & ", "
            sSQL = sSQL & Quotes(sUserPhone) & ", "
            sSQL = sSQL & Quotes("Письмо с сайта chudosoft.ru")
            sSQL = sSQL & ")"
            DbExecSqlQuery(sSQL, iAffected, sError_out:=sError, sDbOrConn:="SSClients")

            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена. Спасибо за вашу заявку.<br />"
            sMsg = sMsg & "Мы обязательно с вами свяжемся.<br />"
            sMsg = sMsg & "<a href=" & m_sPageFrom & ">Вернуться...</a>"
            sMsg = sMsg & "</p>"

            Response.Write(sMsg)
        Else
            sMsg = "<p>Ваши действия выглядят подозрительными, программа определила их как "
            sMsg = sMsg & "действия BOT-программы.</p>"

            Response.Write(sMsg)
        End If
    End Sub

    Protected Sub DoBestpsFormOrder()
        Dim sSecretPart As String, sMsg As String, sResult As String, sTo As String
        Dim sSubject As String, sMessage As String, sUserName As String
        Dim sUserPhone As String, sUserEmail As String, sFormName As String, sSelectLicense As String
        Dim dListLicense(6) As String, sSQL As String, iAffected As Integer, sError As String

        dListLicense = {"Лицензия ""Базовая"" - 8000 руб. (1 рабочее место)",
                           "Лицензия ""Стандарт"" - 13000 руб. (3 рабочих места)",
                           "Лицензия ""Бизнес"" - 17000 руб. (5 рабочих мест)",
                           "Лицензия ""ПРО"" - 23000 руб. (10 рабочих мест)",
                           "Лицензия ""КОРП"" - 30000 руб. (20 рабочих мест)",
                           "Лицензия ""ВИП"" - 34900 руб. (без ограничений)"}
        sUserName = ""
        sUserPhone = ""
        sUserEmail = ""
        sSelectLicense = ""
        sError = ""

        sFormName = Request.Form("form-name")
        sSecretPart = Request.Form("js-inp-field")
        If sFormName = "user-form" Then
            sUserName = Request.Form("user-name")
            sUserPhone = Request.Form("user-phone")
            sUserEmail = Request.Form("user-email")
        ElseIf sFormName = "order-form" Then
            sUserName = Request.Form("order-form__name")
            sUserPhone = Request.Form("order-form__phone")
            sUserEmail = Request.Form("order-form__email")
            sSelectLicense = dListLicense(Request.Form("order-form__select-license") - 1)
        End If

        If sSecretPart = "ProstoySoft" Then
            sTo = "roman.a@simple-soft.ru"

            sSubject = "Заполнена форма на сайта Bestps.ru"
            sMessage = "Отправка формы с сайта Bestps.ru, указаны следующие данные: " & vbCrLf
            sMessage = sMessage & "Имя: " & sUserName & vbCrLf
            sMessage = sMessage & "Телефон: " & sUserPhone & vbCrLf
            sMessage = sMessage & "Email: " & sUserEmail & vbCrLf
            If sSelectLicense <> "" Then
                sMessage = sMessage & "Выбранная лицензия: " & sSelectLicense & vbCrLf
            End If
            sResult = SendMail(sTo, "prostoysoft@yandex.ru", "", sSubject, sMessage, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=True)

            sSQL = "INSERT INTO tblOrders (OrderDate, Fio, Email, Phone, Comments) VALUES ("
            sSQL = sSQL & AbsDateTimeFormat(Now, "#") & ", "
            sSQL = sSQL & Quotes(sUserName) & ", "
            sSQL = sSQL & Quotes(sUserEmail) & ", "
            sSQL = sSQL & Quotes(sUserPhone) & ", "
            sSQL = sSQL & Quotes("Письмо с сайта Bestps.ru")
            sSQL = sSQL & ")"
            DbExecSqlQuery(sSQL, iAffected, sError_out:=sError, sDbOrConn:="SSClients")

            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена. Спасибо за вашу заявку.<br />"
            sMsg = sMsg & "Мы обязательно с вами свяжемся.<br />"
            sMsg = sMsg & "<a href=" & m_sPageFrom & ">Вернуться...</a>"
            sMsg = sMsg & "</p>"

            Response.Write(sMsg)
        Else
            sMsg = "<p>Ваши действия выглядят подозрительными, программа определила их как действия BOT-программы.</p>"

            Response.Write(sMsg)
        End If
    End Sub

    Protected Sub DoProductionKitchen()
        On Error Resume Next

        Dim sFio As String, sCompany As String, sEmail As String, sPhone As String, sProgram As String, sLicense As String, sPaymentType As String, sSupport As String
        Dim sComments As String, sRS As String, sBank As String, sKS As String, sBIC As String, sINN As String, sKPP As String, sSql As String, sError As String = ""
        Dim sAddressUr As String, sAddressFact As String, sAddressPost As String, sDocBeforePay As String, sSource As String, sPromocode As String, sMsg As String
        Dim sMessage As String = "", sTo As String, sInfoByFio As String, sInfoByCompany As String, sInfoByEmail As String, iAffected As Integer, sResult As String
        Dim sSubject As String, sMessage2 As String, sProject As String, sAll As String

        sFio = Request.Form("FIO")
        sEmail = Request.Form("CEmail")
        sPhone = Request.Form("Phone")
        sCompany = Request.Form("Company")
        sComments = Request.Form("Comments")

        sAll = sFio & " " & sEmail & " " & sPhone & " " & sCompany & " " & sComments
        If MyTrim(sAll) = "" Then
            Exit Sub
        End If

        '<1. WRITE IN DB
        sSql = "INSERT INTO tblOrders (OrderDate, Fio, Company, Email, Phone, Comments) VALUES ("
        sSql = sSql & AbsDateTimeFormat(Now, "#") & ", "
        sSql = sSql & Quotes(sFio) & ", "
        sSql = sSql & Quotes(sCompany) & ", "
        sSql = sSql & Quotes(sEmail) & ", "
        sSql = sSql & Quotes(sPhone) & ", "
        sSql = sSql & Quotes(sComments)
        sSql = sSql & ")"
        DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients")
        '/>

        '<2. SEND EMAIL TO PERSONAL
        sMessage = "FIO: " & sFio & vbCrLf
        sMessage &= "Company: " & sCompany & vbCrLf
        sMessage &= "E-mail: " & sEmail & vbCrLf
        sMessage &= "Phone: " & sPhone & vbCrLf
        sMessage &= "Comments: " & sComments

        sTo = "info@prostoysoft.ru; sale@simple-soft.ru"
        sSubject = "Клиент заполнил форму ProductionKitchen"

        sResult = SendMail(sTo, "prostoysoft@yandex.ru", "", sSubject, sMessage, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)
        '/>

        '<3. SEND EMAIL TO CLIENT
        '/>

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена. Спасибо за интерес к нашим продуктам.<br />"
            sMsg = sMsg & "Мы свяжемся с вами в ближайшее время. (Если этого не произойдет, пожалуйcта, свяжитесь Вы с нами.)<br />"
            sMsg = sMsg & "<a href=ProductionKitchen.htm>Вернуться...</a>"
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)
        End If
    End Sub

    '// LOCAL PROCEDURAS /////////////////////////////////////////////////////////////////////////////////////

    'used 1 time
    Protected Function DoInsertIntoDb(Optional sTable As String = "tblOrders", Optional ByVal sOrderDate As String = "NOW", Optional ByVal sComments As String = "") As String
        Dim sSql As String, iAffected As Integer, sError As String = "", sResult As String

        If UCase(sOrderDate) = "NOW" Then
            sOrderDate = AbsDateTimeFormat(Now, "#")
        End If

        If Not IsInQuotes(sComments) Then
            sComments = Quotes(sComments)
        End If

        sSql = "INSERT INTO " & sTable & " (OrderDate, Comments) VALUES (" & sOrderDate & ", " & sComments & ")"

        DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients")
        sResult = Trim(sSql & "; " & sError)

        Return sResult
    End Function

    'used 2 times
    Protected Function GetFormContent(ByRef oRequest As System.Web.HttpRequest, Optional ByVal sDelim As String = vbCrLf, Optional ByRef iFilledCount_out As Integer = 0) As String
        On Error Resume Next

        iFilledCount_out = 0 'clear out param

        Dim oEach As Object, sKey As String, sValue As String, sLine As String, sResult As String = ""

        For Each oEach In oRequest.Form.AllKeys
            sKey = "" : sValue = "" : sLine = "" 'reset

            sKey = oEach
            If sKey > "" Then
                If sKey Like "submit*" Then 'чтобы не приходило eg "submit1: Отправить"
                    sKey = sKey 'Debug.Assert(True)
                Else
                    sValue = oRequest.Form(sKey)
                    If sValue > "" Then
                        sLine = sKey & ": " & sValue
                        sResult = IIf(sResult > "", sResult & sDelim, "") & sLine

                        iFilledCount_out = iFilledCount_out + 1
                    End If
                End If
            End If
        Next

        sLine = "Url: " & oRequest.Url.AbsoluteUri ''m_sPageFrom

        sResult = sResult & sDelim & sLine

        Return sResult
    End Function

    Public Function FilledCorrectly(sFormField As String, Optional ByRef iFilledCtr_out As Integer = 0, Optional sRequiredChar1 As String = "", Optional sRequiredChar2 As String = "") As Boolean
        On Error Resume Next

        Dim bResult As Boolean

        bResult = True

        If sFormField = "" Then
            bResult = True 'it's OK

        ElseIf StartsWithAny(sFormField, "'#", "ORDER BY") Then
            bResult = False 'intruder
        ElseIf sFormField = "'" Then
            bResult = False 'intruder
        ElseIf sFormField = """" Then
            bResult = False 'intruder
        ElseIf sFormField = "\" Then
            bResult = False 'intruder
        ElseIf sFormField = "'--" Then
            bResult = False 'intruder
        ElseIf sFormField = "'/*" Then
            bResult = False 'intruder

        End If

        If bResult Then
            If sRequiredChar1 > "" Then
                If Contains(sFormField, sRequiredChar1) Then
                    bResult = True 'it's OK
                Else
                    Return False
                End If
            End If

            If sRequiredChar2 > "" Then
                If Contains(sFormField, sRequiredChar2) Then
                    bResult = True 'it's OK
                Else
                    Return False
                End If
            End If

            iFilledCtr_out = iFilledCtr_out + 1
        End If

        Return bResult
    End Function

    Protected Sub DoOrderForm()
        On Error Resume Next

        Dim sFio As String, sCompany As String, sEmail As String, sPhone As String, sProgram As String, sLicense As String, sPaymentType As String, sSupport As String, sComments As String, sRS As String, sBank As String
        Dim sKS As String, sBIC As String, sINN As String, sKPP As String, sSql As String, sError As String = "", sAddressUr As String, sAddressFact As String, sAddressPost As String, sDocBeforePay As String
        Dim sSource As String, sPromocode As String, sMsg As String, sMessage As String = "", sTo As String, sInfoByFio As String, sInfoByCompany As String, sInfoByEmail As String, iAffected As Integer, sAll As String
        Dim sSubject As String, sMessage2 As String, sProject As String, sResult As String, iFilledCtr As Integer = 0

        sFio = Request.Form("txtFIO") : If Not FilledCorrectly(sFio, iFilledCtr) Then Exit Sub
        sCompany = Request.Form("txtCompany") : If Not FilledCorrectly(sCompany, iFilledCtr) Then Exit Sub
        sEmail = Request.Form("txtClientEmail") : If Not FilledCorrectly(sEmail, iFilledCtr, "@", ".") Then Exit Sub
        sPhone = Request.Form("txtClientPhone") : If Not FilledCorrectly(sPhone, iFilledCtr) Then Exit Sub
        sProgram = Request.Form("ddlProgram") : If Not FilledCorrectly(sProgram, iFilledCtr) Then Exit Sub
        sLicense = Request.Form("ddlLicense") : If Not FilledCorrectly(sLicense, iFilledCtr) Then Exit Sub
        sPaymentType = Request.Form("ddlPaymentType") : If Not FilledCorrectly(sPaymentType, iFilledCtr) Then Exit Sub
        sSupport = Request.Form("ddlSupport") : If Not FilledCorrectly(sSupport, iFilledCtr) Then Exit Sub
        sProject = Request.Form("Config") : If Not FilledCorrectly(sProject, iFilledCtr) Then Exit Sub
        sSource = Request.Form("ddlSource") : If Not FilledCorrectly(sSource, iFilledCtr) Then Exit Sub
        If sSource = "Другое" Then
            sSource &= ": " & Request.Form("txtOtherSource") : If Not FilledCorrectly(sSource, iFilledCtr) Then Exit Sub
        End If
        sComments = Request.Form("txtComments") : If Not FilledCorrectly(sComments, iFilledCtr) Then Exit Sub

        sRS = Request.Form("RS")
        sBank = Request.Form("Bank")
        sKS = Request.Form("KS")
        sBIC = Request.Form("BIC")
        sINN = Request.Form("INN")
        sKPP = Request.Form("KPP")
        sAddressUr = Request.Form("Address")
        sAddressFact = Request.Form("Address2")
        sAddressPost = Request.Form("Address3")
        sDocBeforePay = Request.Form("DocBeforePay")
        sPromocode = Request.Form("promocode")

        If iFilledCtr < 2 Then
            Exit Sub 'it's spam bot
        End If

        sAll = sFio & sCompany & sEmail & sPhone & sProgram & sLicense & sPaymentType & sSupport & sProject & sComments
        If MyTrim(sAll) = "" Then
            Exit Sub'it's spam bot
        End If

        '2018-11-02
        If MyTrim(sCompany) = "Acunetix" Then
            Exit Sub
        End If
        If MyTrim(sEmail) Like "sample@*" Then
            Exit Sub
        End If
        '/>

        sInfoByFio = GetClientInfoByFio(sFio) ''eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
        sInfoByCompany = GetClientInfoByCompany(sCompany) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
        sInfoByEmail = GetClientInfoByEmail(sEmail) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"

        If SubstringCount(sProject, "%") > 2 Then 'if eg + Конфигурация "%D0%A6%D0%B5%D0%BD%D1%82%D1%80%20%D0%B0%D0%BD%D0%B4%D1%80%D0%BE%D0%BB%D0%BE%D0%B3%D0%B8%D0%B8"
            sProject = RemoveStartSubstr(Trim(sProject), "+ Конфигурация ")
            sProject = RemoveEndSubstr(sProject, """")
            sProject = Server.UrlDecode(sProject)
            sProject = "+ Конфигурация " & QuotesDbl(sProject)
        End If

        '<1. WRITE IN DB
        sSql = "INSERT INTO tblOrders (OrderDate, Fio, Company, Email, Phone, Program, License, PaymentType, Support, Comments, RS, Bank, KS, BIC, INN, KPP,"
        sSql = sSql & " AddressUr, AddressFact, AddressPost, DocBeforePay, Source, Promocode) VALUES ("
        sSql = sSql & AbsDateTimeFormat(Now, "#") & ", "
        sSql = sSql & Quotes(sFio) & ", "
        sSql = sSql & Quotes(sCompany) & ", "
        sSql = sSql & Quotes(sEmail) & ", "
        sSql = sSql & Quotes(sPhone) & ", "
        sSql = sSql & Quotes(sProgram) & ", "
        sSql = sSql & Quotes(sLicense) & ", "
        sSql = sSql & Quotes(sPaymentType) & ", "
        sSql = sSql & Quotes(sSupport) & ", "
        sSql = sSql & Quotes(Trim(sProject & " " & sComments)) & ", "
        sSql = sSql & Quotes(sRS) & ", "
        sSql = sSql & Quotes(sBank) & ", "
        sSql = sSql & Quotes(sKS) & ", "
        sSql = sSql & Quotes(sBIC) & ", "
        sSql = sSql & Quotes(sINN) & ", "
        sSql = sSql & Quotes(sKPP) & ", "
        sSql = sSql & Quotes(sAddressUr) & ", "
        sSql = sSql & Quotes(sAddressFact) & ", "
        sSql = sSql & Quotes(sAddressPost) & ", "
        sSql = sSql & Quotes(sDocBeforePay) & ", "
        sSql = sSql & Quotes(sSource) & ", "
        sSql = sSql & Quotes(sPromocode)
        sSql = sSql & ")"
        DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients")
        '/>

        '<2. SEND EMAIL TO PERSONAL
        sMessage = "FIO: " & sFio & IIf(sInfoByFio > "", " (" & sInfoByFio & ")", "") & vbCrLf
        sMessage &= "Company: " & sCompany & IIf(sInfoByCompany > "", " (" & sInfoByCompany & ")", "") & vbCrLf
        sMessage &= "E-mail: " & sEmail & IIf(sInfoByEmail > "", " (" & sInfoByEmail & ")", "") & vbCrLf
        sMessage &= "Phone: " & sPhone & vbCrLf
        sMessage &= "Program: " & sProgram & vbCrLf
        sMessage &= "License: " & sLicense & vbCrLf
        sMessage &= "PaymentType: " & sPaymentType & vbCrLf
        sMessage &= "Support: " & sSupport & vbCrLf
        sMessage &= "Config: " & UCase(sProject) & vbCrLf
        sMessage &= "Comments: " & sComments & vbCrLf
        sMessage &= "RS: " & sRS & vbCrLf
        sMessage &= "Bank: " & sBank & vbCrLf
        sMessage &= "KS: " & sKS & vbCrLf
        sMessage &= "BIC: " & sBIC & vbCrLf
        sMessage &= "INN: " & sINN & vbCrLf
        sMessage &= "KPP: " & sKPP & vbCrLf
        sMessage &= "Address uridichesky: " & sAddressUr & vbCrLf
        sMessage &= "Address factichesky: " & sAddressFact & vbCrLf
        sMessage &= "Address pochtovy: " & sAddressPost & vbCrLf
        sMessage &= "DocBeforePay: " & sDocBeforePay & vbCrLf
        sMessage &= "Source: " & sSource & vbCrLf
        sMessage &= "Promocode: " & sPromocode & vbCrLf

        sTo = "info@prostoysoft.ru; sale@simple-soft.ru"
        sSubject = "Клиент заполнил форму на сайте"

        sResult = SendMail("info@prostoysoft.ru; sale@simple-soft.ru", "prostoysoft@yandex.ru", "", sSubject, sMessage, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)
        '/>

        '<3. SEND EMAIL TO CLIENT
        If IsEmail(sEmail) Then
            'sSubject = "Простой софт - Ваша заказ принят"

            'sMessage2 = "Добрый день." & vbCrLf & vbCrLf
            'sMessage2 &= "Спасибо за интерес к нашим продуктам." & vbCrLf
            'sMessage2 &= "Мы приняли Ваш заказ и свяжемся с Вами в ближайшее время." & vbCrLf
            'sMessage2 &= "Наш режим работы с 10 до 18 по московскому времени в рабочие дни." & vbCrLf & vbCrLf

            ''            If sPaymentType = "Яндекс.Деньги" Then
            ''                sSubject = "Приобретение программы """ & sProgram & """ способ оплаты - Яндекс.Деньги"

            ''                sMessage2 &= "Вы можете оплатить программу """ & sProgram & """ редакция "БАЗОВАЯ" 3000 руб. в любое время. 
            ''                sMessage2 &= "№ нашего кошелька Яндекс-денег для перевода 410012134585621."
            ''                sMessage2 &= "В комментариях к платежу укажите, пожалуйста, от кого он - ваше имя, емейл, название программы или напишите отдельный мейл с сообщением об оплате."
            ''sMessage2 &= "После поступления оплаты или вашего сообщения нам об оплате с доказательством оплаты (отсканированная платежка или чек), мы сразу высылаем вам персональный лицензионный код к программе по емейл. Его нужно ввести в диалоговое окно "Ввод лицензионного кода" из меню "Помощь" и ваша демо-версия станет полной версией без временных и функциональных ограничений (кроме ограничений по типу лицензии).

            ''            ElseIf sPaymentType = "" Then

            ''            Else

            ''            End If

            'sMessage2 &= sMessage
            'sMessage2 &= vbCrLf

            'sMessage2 &= vbCrLf & "С уважением," & vbCrLf
            'sMessage2 &= "Отдел продаж" & vbCrLf
            'sMessage2 &= "Компания ""Простой софт"" http://www.prostoysoft.ru" & vbCrLf

            'sResult = SendMail(sEmail, "prostoysoft@yandex.ru", "", sSubject, sMessage2, "", "smtp.yandex.ru", "sale@simple-soft.ru", m_sSmtpPassword, 587, True, bBccToAdmin:=False)
        End If
        '/>

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            If Request.Form("PaymentType") = "Яндекс.Деньги" Then
                sMsg = sMsg & "В системе Яндекс.Деньги номер нашего кошелька для перевода 410011190199363. В комментариях платежа, пожалуйста, укажите от кого он (ваше имя, емейл).<br />"
                sMsg = sMsg & "<a href=prices.htm>Вернуться...</a>"
            ElseIf Request.Form("ddlPaymentType") = "WebMoney" Then
                sMsg = sMsg & "В системе WebMoney наш рублевый кошелек R915619485572 или долларовый Z027033288833. В комментариях платежа, пожалуйста, укажите от кого он (ваше имя, емейл).<br />"
                sMsg = sMsg & "<a href=prices.htm>Вернуться...</a>"
            ElseIf Request.Form("ddlPaymentType") Like "*RBK Money*" Then
                sMsg = sMsg & "При способе оплаты 'RBK Money' пожалуйста, заплните <a href='prices.htm#RbkMoneyForm'>форму оплаты через RBK Money</a>"
            Else
                sMsg = sMsg & "Форма отправлена. Спасибо за интерес к нашим продуктам.<br />"
                sMsg = sMsg & "Мы свяжемся с вами в ближайшее время. (Если этого не произойдет, пожалуйcта, свяжитесь Вы с нами.)<br />"
                sMsg = sMsg & "<a href=prices.htm>Вернуться...</a>"
            End If
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)
        End If
    End Sub

    Protected Sub DoProjectForm()
        'On Error Resume Next

        Dim sMessage As String = "", sTo As String, sSubject As String, sMsg As String, sResult As String, sResponsible As String, sFolder As String, sFile As String
        Dim oPostedFile As HttpPostedFile, sTargetFile As String = "", sShortFile As String = "", sFIO As String, sCompany As String, sEmail As String, sCity As String
        Dim sPhone As String, sProgram As String, sLicense As String, sComments As String, sSql As String, iAffected As Integer, sError As String = "", iClientID As Integer
        Dim sInfoByFio As String, sInfoByCompany As String, sInfoByEmail As String, sProject As String

        oPostedFile = Request.Files("mail_file")
        If oPostedFile Is Nothing OrElse oPostedFile.FileName = "" Then
            'Debug.Assert(True) 'do nothing - no attached file
        Else
            ''sFolder = Server.MapPath("") 'get e.g. "E:\Personal\WebSites\simple-soft" or "C:\inetpub\simple-soft"
            ''If FolderExists(sFolder & "\Documents") Then
            ''    sFolder = sFolder & "\Documents"
            ''End If
            sFolder = "C:\inetpub\wwwroot\SimpleSitePS\Documents\"
            sFile = oPostedFile.FileName
            sShortFile = GetShortFileName(sFile)
            If sShortFile Like "*[А-я ]*" Then
                sShortFile = GetRandomString(8, 8) & AfterSubstrRev(sShortFile, ".", bWithSubstr:=True) 'имя файла с русскими буквами или пробелами переименовываем
            End If
            sTargetFile = BuildPath(sFolder, sShortFile)
            If sTargetFile > "" Then
                oPostedFile.SaveAs(sTargetFile)
            End If
        End If

        sFIO = Request.Form("FIO")
        sCompany = Request.Form("Company")
        sEmail = Request.Form("CEmail")
        sCity = Request.Form("City")
        sPhone = Request.Form("txtPhone")
        sProgram = Request.Form("ddlProgram")
        sLicense = Request.Form("ddlLicense")
        sComments = Request.Form("Comments")
        sProject = Trim(sProgram & " " & sLicense & " " & sComments)

        '<antispam
        If sEmail > "" And sEmail Like "*@*" Then ' And (sFIO > "" Or sCompany > "") Then
            'Debug.Assert(True) 'it's ok
        Else
            Response.Write("The email is incorrect.")
            Exit Sub 'it's probably spam
        End If

        If Len(sProject) > 200 Then
            If sProject Like "*[А-я]*" Then
                'Debug.Assert(True) 'it's ok
            ElseIf InStr(1, sProject, "<a href", CompareMethod.Text) > 0 Then
                Response.Write("This is a spam.")
                Exit Sub 'it's probably spam
            End If
        End If
        '/>

        sInfoByFio = GetClientInfoByFio(sFIO) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
        sInfoByCompany = GetClientInfoByCompany(sCompany) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
        sInfoByEmail = GetClientInfoByEmail(sEmail) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"

        If sInfoByEmail Like "ID=#*" Then
            iClientID = Val(Mid(sInfoByEmail, 4)) 'get eg "1474"
        End If


        '<1. write in db
        sSql = "INSERT INTO tblProjects (ProjectDate, Project, Client, Person, City, ClientEmail, Phone, ProjectStatus, TechTask, UserName, ProjectNotes, ClientID) VALUES ("
        sSql = sSql & AbsDateFormat(Now, "#") & ", "
        sSql = sSql & Quotes(Trim(sProgram & " " & sLicense & " " & sComments)) & ", "
        sSql = sSql & Quotes(sCompany) & ", "
        sSql = sSql & Quotes(sFIO) & ", "
        sSql = sSql & Quotes(sCity) & ", "
        sSql = sSql & Quotes(sEmail) & ", "
        sSql = sSql & Quotes(sPhone) & ", "
        sSql = sSql & "'Заявка подана', " '"'Проявил интерес', "
        sSql = sSql & Quotes(sShortFile) & ", "

        sSql = sSql & "'FilledForm', "

        sSql = sSql & "'', " '"'заполнена форма'"
        sSql = sSql & IIf(iClientID <> 0, iClientID, "NULL")
        sSql = sSql & ")"
        DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients")
        '/>

        '<2. send email to personal
        sMessage &= "FIO: " & sFIO & IIf(sInfoByFio > "", " (" & sInfoByFio & ")", "") & vbCrLf
        sMessage &= "Company: " & sCompany & IIf(sInfoByCompany > "", " (" & sInfoByCompany & ")", "") & vbCrLf
        sMessage &= "E-mail: " & sEmail & IIf(sInfoByEmail > "", " (" & sInfoByEmail & ")", "") & vbCrLf
        sMessage &= "City: " & sCity & vbCrLf
        sMessage &= "Phone: " & sPhone & vbCrLf
        sMessage &= "Program: " & sProgram & vbCrLf
        sMessage &= "License: " & sLicense & vbCrLf
        sMessage &= "Comments: " & sComments & vbCrLf
        If iAffected <= 0 Then
            sMessage &= "Информация НЕ была добавлена в БД. " & vbCrLf & vbCrLf & sError & vbCrLf
        End If

        sTo = "info@prostoysoft.ru"

        sSubject = "Заявка на конфигурацию"
        If Request.Form("ddlProgram") > "" Then
            sResponsible = "для " & IIf(Int(2 * Rnd()) = 1, "Ivan", "Vera")
            sSubject &= ", программа """ & Request.Form("ddlProgram") & """ (" & sResponsible & ")" ' от " & Request.Form("Company") & ")"
        End If

        sResult = SendMail(sTo, "prostoysoft@yandex.ru", "", sSubject, sMessage, sTargetFile, "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)
        '/>

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена. Спасибо за интерес к нашим продуктам.<br />"
            sMsg = sMsg & "Мы свяжемся с вами в ближайшее время. (Если этого не произойдет, пожалуйcта, свяжитесь Вы с нами.)<br />"
            sMsg = sMsg & "<a href=services.htm>Вернуться...</a>"
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)

            If sTargetFile > "" Then
                'DeleteFile(sTargetFile)
            End If
        End If
    End Sub

    Protected Sub DoSupportForm(Optional ByVal sSupportFormType As String = "") '"SupportForm" Or "SupportForm2"
        On Error Resume Next

        Dim oPostedFile As HttpPostedFile, sShortFile As String, sTargetFile As String = "", sFolder As String, sFile As String = "", sResult As String, sError As String = ""
        Dim sProgram As String, sVersion As String, sDbms As String, sOS As String, sEmail As String, sPhone As String, sFio As String, sCompany As String, sComments As String, sSql As String = ""
        Dim sSubject As String, sMessage As String = "", sTo As String, sMsg As String, sInfoByEmail As String, sInfoByFio As String, sInfoByCompany As String
        Dim iAffected As Integer, sAddedId As String = "", iClientID As Integer = 0, sAgreeWithRools As String = "", sAll As String

        oPostedFile = Request.Files("mail_file")
        If oPostedFile Is Nothing OrElse oPostedFile.FileName = "" Then
            'Debug.Assert(True) '// NO ATTACHED FILE
        Else
            '// ATTACHED FILE
            ''sFolder = Server.MapPath("") 'get eg "C:\inetpub\simple-soft" or "C:\inetpub\wwwroot\SimpleSitePS"
            ''If FolderExists(sFolder & "\Documents") Then
            ''    sFolder = sFolder & "\Documents"
            ''End If
            sFolder = "C:\inetpub\wwwroot\SimpleSitePS\Documents\"
            sFile = oPostedFile.FileName
            sShortFile = GetShortFileName(sFile)
            If sShortFile Like "*[А-я ]*" Then
                sShortFile = Translit(sShortFile, True) 'имя файла с русскими буквами переводим в транслит
            End If
            sTargetFile = BuildPath(sFolder, sShortFile)
            If sTargetFile > "" Then
                oPostedFile.SaveAs(sTargetFile)
            End If
        End If

        sProgram = Request.Form("ddlProgram")
        sVersion = Request.Form("Version")
        sDbms = Request.Form("ddlDbms")
        sDbms = (RemoveAllStartSubstrs(sDbms, False, "База данных формата ", "Microsoft"))
        sOS = Request.Form("OS")
        sEmail = Trim(Request.Form("CEmail"))
        sPhone = Trim(Request.Form("Phone"))
        sFio = Request.Form("FIO")
        sCompany = Request.Form("Company")
        sComments = Request.Form("Comments")

        '<ANTISPAM
        sAll = sProgram & " " & sVersion & " " & sDbms & " " & sOS & " " & sEmail & " " & sPhone & " " & sFio & " " & sCompany & " " & sComments
        If MyTrim(sAll) = "" Then
            Exit Sub 'it's spam
        End If

        If sEmail > "" And sEmail Like "*@*" Then ' And (sFIO > "" Or sCompany > "") Then
            'Debug.Assert(True) 'it's ok
        Else
            Response.Write("The email is incorrect.")
            Exit Sub 'it's probably spam
        End If
        If Contains(sVersion, "http") Or Contains(sOS, "http") Or Contains(sFio, "http") Then
            Response.Write("This is a spam.")
            Exit Sub 'it's probably spam
        End If

        '2018-11-02
        If MyTrim(sCompany) = "Acunetix" Then
            Exit Sub
        End If
        If MyTrim(sEmail) Like "sample@*" Then
            Exit Sub
        End If
        '/>

        '<поиск информации в клиентской БД
        sInfoByEmail = GetClientInfoByEmail(sEmail) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
        sInfoByFio = GetClientInfoByFio(sFio) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
        sInfoByCompany = GetClientInfoByCompany(sCompany) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"

        If sInfoByEmail Like "ID=#*" Then
            iClientID = Val(Mid(sInfoByEmail, 4)) 'get eg "1474"
        End If
        '/>

        '<1. WRITE IN DB
        If sSupportFormType = "SupportForm" Then
            sSql = "INSERT INTO tblSupport (RequestDate, Program, Version, Dbms, OS, ClientEmail, ClientFio, Company, Comments, AttachedFile, Status, ClientID) VALUES ("
            sSql = sSql & AbsDateFormat(Now, "#") & ", "
            sSql = sSql & Quotes(sProgram) & ", "
            sSql = sSql & Quotes(sVersion) & ", "
            sSql = sSql & Quotes(sDbms) & ", "
            sSql = sSql & Quotes(sOS) & ", "
            sSql = sSql & Quotes(sEmail & ", " & sPhone) & ", "
            sSql = sSql & Quotes(sFio) & ", "
            sSql = sSql & Quotes(sCompany) & ", "
            sSql = sSql & Quotes(sComments) & ", "
            sSql = sSql & Quotes(GetShortFileName(sTargetFile)) & ", "
            sSql = sSql & "'Заявка подана', "
            sSql = sSql & IIf(iClientID <> 0, iClientID, "NULL")
            sSql = sSql & ")"
        ElseIf sSupportFormType = "SupportForm2" Then
            sSql = "INSERT INTO tblProjects (ProjectDate, Project, Client, Person, City, ClientEmail, Phone, ProjectStatus, TechTask, ProjectNotes, ProjectType, ClientID) VALUES ("
            sSql = sSql & AbsDateFormat(Now, "#") & ", "
            sSql = sSql & Quotes(Trim("Платная поддержка. " & sProgram & " " & sComments)) & ", "
            sSql = sSql & Quotes(sCompany) & ", "
            sSql = sSql & Quotes(sFio) & ", "
            sSql = sSql & "'', " 'City
            sSql = sSql & Quotes(sEmail) & ", "
            sSql = sSql & Quotes(sPhone) & ", " 'Phone
            sSql = sSql & "'Заявка подана', "
            sSql = sSql & Quotes(GetShortFileName(sTargetFile)) & ", "
            sSql = sSql & "''" & ", " 'ProjectNotes
            sSql = sSql & "'Платная поддержка', "
            sSql = sSql & IIf(iClientID <> 0, iClientID, "NULL")
            sSql = sSql & ")"
        End If
        DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients", vAddedId_out:=sAddedId)
        '/>

        '<2. SEND EMAIL TO PERSONAL
        ''sSubject = "Обращение в поддержку" & IIf(sAddedId <> "", " (ID=" & sAddedId & " от " & FormatDateTime(Now, DateFormat.ShortDate) & ")", "") & IIf(sSupportFormType = "SupportForm2", " форма платного обращения", "")
        sSubject = "Обращение в поддержку" & IIf(sAddedId <> "", " (ID=" & sAddedId & " от " & CStr(Now) & ")", "") & IIf(sSupportFormType = "SupportForm2", " форма платного обращения", "")

        sMessage &= "Program: " & sProgram & vbCrLf
        sMessage &= "Version: " & sVersion & vbCrLf
        sMessage &= "DBMS: " & sDbms & vbCrLf
        sMessage &= "OS: " & sOS & vbCrLf
        sMessage &= "E-Email: " & sEmail & IIf(sInfoByEmail > "", " (" & sInfoByEmail & ")", "") & vbCrLf
        sMessage &= "FIO: " & sFio & IIf(sInfoByFio > "", " (" & sInfoByFio & ")", "") & vbCrLf
        sMessage &= "Company: " & sCompany & IIf(sInfoByCompany > "", " (" & sInfoByCompany & ")", "") & vbCrLf
        sMessage &= "Comments: " & vbCrLf & sComments & vbCrLf
        If sFile > "" Then
            sMessage &= "Файл: " & GetShortFileName(sTargetFile) & vbCrLf
        End If
        If sSupportFormType = "SupportForm2" Then
            sAgreeWithRools = Request.Form("chkAgreeWithRools")
            sMessage &= "AgreeWithRools: " & sAgreeWithRools & vbCrLf
        End If

        'sTo = "support@simple-soft.ru"
        'sResult = SendMail(sTo, "prostoysoft@yandex.ru", "", sSubject, sMessage, sTargetFile, "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)
        sResult = SendMail("support@simple-soft.ru", "prostoysoft@yandex.ru", "", sSubject, sMessage, sTargetFile, "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)
        '/>

        '<3. SEND EMAIL TO CLIENT
        If IsEmail(sEmail) Then
            sSubject = "Prostoysoft - Ваша заявка принята" & IIf(sAddedId <> "", " (ID=" & sAddedId & ")", "")

            sMessage = "Добрый день." & vbCrLf & vbCrLf
            sMessage &= "Мы приняли Вашу заявку и обязательно ее рассмотрим." & vbCrLf
            sMessage &= IIf(sAddedId <> 0, "Обращению присвоен уникальный код ID=" & sAddedId & vbCrLf, "")
            sMessage &= "Наша техническая служба работает по рабочим дням с 10 до 18 по московскому времени и в соответствии с Регламентом оказания технической поддержки" & vbCrLf
            sMessage &= "http://www.prostoysoft.ru/terms.htm" & vbCrLf
            sMessage &= "Пожалуйста, проверьте, предоставили ли Вы исчерпывающую информацию по проблеме или вопросу (копия БД, скриншот или видео) в заполненной Вами форме." & vbCrLf & vbCrLf

            sMessage &= "Program: " & sProgram & vbCrLf
            sMessage &= "Version: " & sVersion & vbCrLf
            sMessage &= "DBMS: " & sDbms & vbCrLf
            sMessage &= "OS: " & sOS & vbCrLf
            sMessage &= "E-Email: " & sEmail & vbCrLf
            sMessage &= "FIO: " & sFio & vbCrLf
            sMessage &= "Company: " & sCompany & vbCrLf
            sMessage &= "Comments: " & sComments & vbCrLf
            If sFile > "" Then
                sMessage &= "Файл: " & GetShortFileName(sFile) & vbCrLf
            End If

            sMessage &= vbCrLf & "С уважением," & vbCrLf
            sMessage &= "Служба технической поддержки" & vbCrLf
            sMessage &= "Компания ""Простой софт""." & vbCrLf

            'sMessage &= vbCrLf & "Пожалуйста, не отвечайте на это письмо. Связаться со службой поддержки Prostoysoft вы можете через форму обратной связи: http://prostoysoft.ru/support.htm" ' Наш e-mail поддержки: support@simple-soft.ru" & vbCrLf

            'sResult = sendMail(sEmail, "prostoysoft@yandex.ru", "", "Обращение в поддержку", sMessage, sTargetFile, "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)

            '2015-01-31: off - doesn't work
            SendMail(sEmail, "support@simple-soft.ru", "", sSubject, sMessage, "", "smtp.yandex.ru", "support@simple-soft.ru", "elmgeqxlsufobdxd", 587, bSSL:=True, bBccToAdmin:=False)
        End If
        '/>

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена. Спасибо за ваше обращение.<br />"
            sMsg = sMsg & "В ближайшее время мы рассмотрим ваш вопрос или проблему и сообщим о результатах.<br />"
            sMsg = sMsg & "<a href=support.htm>Вернуться...</a>"
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)

            If sTargetFile > "" Then
                'DeleteFile(sTargetFile)
            End If
        End If
    End Sub

    Protected Sub DoResponseForm() 'отправить отзыв
        Dim sFIO As String, sCompany As String, sEmail As String, sProgram As String, sComments As String, sSql As String, sResult As String, sMsg As String, iAffected As Integer, sError As String = ""
        Dim sAddedId As String = "", sAll As String

        sFIO = Request.Form("FIO")
        sCompany = Request.Form("Company")
        sEmail = Request.Form("CEmail")
        sProgram = Request.Form("ddlProgram")
        sComments = Request.Form("Comments")

        sAll = sFIO & " " & sCompany & " " & sEmail & " " & sProgram & " " & sComments
        If MyTrim(sAll) = "" Then
            Exit Sub 'it's spam
        End If

        '<1. WRITE IN DB
        sSql = "INSERT INTO tblResponses (ResponseDate, ClientFIO, ClientCompany, ClientEmail, Program, Response) VALUES ("
        sSql = sSql & AbsDateTimeFormat(Now, "#") & ", "
        sSql = sSql & Quotes(sFIO) & ", "
        sSql = sSql & Quotes(sCompany) & ", "
        sSql = sSql & Quotes(sEmail) & ", "
        sSql = sSql & Quotes(sProgram) & ", "
        sSql = sSql & Quotes(sComments)
        sSql = sSql & ")"
        sResult = DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients", vAddedId_out:=sAddedId)
        '/>

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена. Спасибо за вашу заявку.<br />"
            sMsg = sMsg & "Мы обязательно с вами свяжемся.<br />"
            sMsg = sMsg & "<a href=" & m_sPageFrom & ">Вернуться...</a>"
            sMsg = sMsg & "</p>"

            Response.Write(sMsg)
        End If
    End Sub

    Protected Sub DoOrderSite()
        On Error Resume Next

        Dim sMessage As String = "", sTo As String, sSubject As String, sMsg As String, sResult As String, sResponsible As String, sFolder As String, sFile As String
        Dim oPostedFile As HttpPostedFile, sTargetFile As String = "", sShortFile As String = "", sFIO As String, sCompany As String, sEmail As String, sCity As String
        Dim sPhone As String, sProgram As String, sLicense As String, sComments As String, sSql As String, iAffected As Integer, sError As String = "", iClientID As Integer
        Dim sInfoByFio As String, sInfoByCompany As String, sInfoByEmail As String, sProject As String, sAll As String

        oPostedFile = Request.Files("mail_file")
        If oPostedFile Is Nothing OrElse oPostedFile.FileName = "" Then
            'Debug.Assert(True) 'do nothing - no attached file
        Else
            ''sFolder = Server.MapPath("") 'get e.g. "E:\Personal\WebSites\simple-soft" or "C:\inetpub\simple-soft"
            ''If FolderExists(sFolder & "\Documents") Then
            ''    sFolder = sFolder & "\Documents"
            ''End If
            sFolder = "C:\inetpub\wwwroot\SimpleSitePS\Documents\"
            sFile = oPostedFile.FileName
            sShortFile = GetShortFileName(sFile)
            If sShortFile Like "*[А-я ]*" Then
                sShortFile = GetRandomString(8, 8) & AfterSubstrRev(sShortFile, ".", bWithSubstr:=True) 'имя файла с русскими буквами или пробелами переименовываем
            End If
            sTargetFile = BuildPath(sFolder, sShortFile)
            If sTargetFile > "" Then
                oPostedFile.SaveAs(sTargetFile)
            End If
        End If

        sFIO = Request.Form("FIO")
        sCompany = Request.Form("Company")
        sEmail = Request.Form("CEmail")
        sCity = Request.Form("City")
        sPhone = Request.Form("Phone")
        sProgram = Request.Form("ddlProgram")
        sLicense = "" 'Request.Form("ddlLicense")
        sComments = Request.Form("Comments")
        sProject = Trim(sProgram & " " & sLicense & " " & sComments)

        sAll = sFIO & " " & sCompany & " " & sEmail & " " & sCity & " " & sPhone & " " & sProgram & " " & sLicense & " " & sComments & " " & sProject
        If MyTrim(sAll) = "" Then
            Exit Sub 'it's spam
        End If

        '<antispam
        If sEmail > "" And sEmail Like "*@*" Then ' And (sFIO > "" Or sCompany > "") Then
            'Debug.Assert(True) 'it's ok
        Else
            Response.Write("The email is incorrect.")
            Exit Sub 'it's probably spam
        End If

        If Len(sProject) > 200 Then
            If sProject Like "*[А-я]*" Then
                'Debug.Assert(True) 'it's ok
            ElseIf InStr(1, sProject, "<a href", CompareMethod.Text) > 0 Then
                Response.Write("This is a spam.")
                Exit Sub 'it's probably spam
            End If
        End If

        'If Contains(LCase(sCompany), "google") Then
        '    Exit Sub 'it's probably spam
        'End If
        '/>

        '<поиск информации в клиентской БД
        sInfoByFio = GetClientInfoByFio(sFIO) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
        sInfoByCompany = GetClientInfoByCompany(sCompany) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
        sInfoByEmail = GetClientInfoByEmail(sEmail) 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"

        If sInfoByEmail Like "ID=#*" Then
            iClientID = Val(Mid(sInfoByEmail, 4)) 'get eg "1474"
        End If
        '/>

        '<1. write in db
        sSql = "INSERT INTO tblProjects (ProjectDate, Project, Client, Person, City, ClientEmail, Phone, ProjectStatus, TechTask, ProjectNotes, ClientID) VALUES ("
        sSql = sSql & AbsDateFormat(Now, "#") & ", "
        sSql = sSql & Quotes(Trim(sProgram & " " & sLicense & " " & sComments)) & ", "
        sSql = sSql & Quotes(sCompany) & ", "
        sSql = sSql & Quotes(sFIO) & ", "
        sSql = sSql & Quotes(sCity) & ", "
        sSql = sSql & Quotes(sEmail) & ", "
        sSql = sSql & Quotes(sPhone) & ", "
        sSql = sSql & "'Заявка подана', " '"'Проявил интерес', "
        sSql = sSql & Quotes(sShortFile) & ", "
        sSql = sSql & "'FilledForm', " '"'заполнена форма'"
        sSql = sSql & IIf(iClientID <> 0, iClientID, "NULL")
        sSql = sSql & ")"
        DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients")

        'в таблицу "Заказы клиентов" тоже надо писать <bkm>

        '/>

        '<2. send email to personal
        sMessage &= "FIO: " & sFIO & IIf(sInfoByFio > "", " (" & sInfoByFio & ")", "") & vbCrLf
        sMessage &= "Company: " & sCompany & IIf(sInfoByCompany > "", " (" & sInfoByCompany & ")", "") & vbCrLf
        sMessage &= "E-mail: " & sEmail & IIf(sInfoByEmail > "", " (" & sInfoByEmail & ")", "") & vbCrLf
        sMessage &= "City: " & sCity & vbCrLf
        sMessage &= "Phone: " & sPhone & vbCrLf
        sMessage &= "SiteType: " & sProgram & vbCrLf
        'sMessage &= "License: " & sLicense & vbCrLf
        sMessage &= "Comments: " & sComments & vbCrLf
        If iAffected <= 0 Then
            sMessage &= "Информация НЕ была добавлена в БД. " & vbCrLf & vbCrLf & sError & vbCrLf
        End If

        sTo = "info@prostoysoft.ru"

        sSubject = "Заявка на создание сайта"
        If Request.Form("ddlProgram") > "" Then
            sResponsible = "для " & IIf(Int(2 * Rnd()) = 1, "Ivan", "Vera")
            sSubject &= ", тип сайта """ & Request.Form("ddlProgram") & """ (" & sResponsible & ")" ' от " & Request.Form("Company") & ")"
        End If

        sResult = SendMail(sTo, "prostoysoft@yandex.ru", "", sSubject, sMessage, sTargetFile, "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)
        '/>

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена. Спасибо за проявленный интерес.<br />"
            sMsg = sMsg & "Мы свяжемся с вами в ближайшее время. (Если этого не произойдет, пожалуйcта, свяжитесь Вы с нами.)<br />"
            sMsg = sMsg & "<a href=sites.htm>Вернуться...</a>"
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)

            If sTargetFile > "" Then
                'DeleteFile(sTargetFile)
            End If
        End If
    End Sub

    Protected Sub DoPsPrintOrder()
        On Error Resume Next

        Dim sFormContent As String, sMsg As String, sSql As String, iAffected As Integer, sError As String = "", iFilled As Integer

        sFormContent = GetFormContent(Request, "  ;  ", iFilledCount_out:=iFilled) ''" ; "  'vbCrLf - проблема
        If iFilled > 0 Then
            If MyTrim(sFormContent) = "" Then
                Exit Sub
            End If

            '<antispam
            If iFilled <= 1 Then 'должно быть заполнено минимум 2 поля, иначе это спам
                Exit Sub
            End If
            '/>

            sSql = "INSERT INTO tblPsPrintOrders (OrderTitle, OrderDate) VALUES (" & Quotes(sFormContent) & ", " & AbsDateTimeFormat(Now, "#") & ")"
            DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients")

            SendMail("info@prostoysoft.ru;psprint@prostoysoft.ru", "prostoysoft@yandex.ru", "", "Заполнена форма " & m_sFormType, sFormContent, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)

            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена. Спасибо за проявленный интерес.<br />"
            sMsg = sMsg & "Мы обязательно с вами свяжемся. (Если этого не произойдет, пожалуйcта, свяжитесь Вы с нами.)<br />"
            sMsg = sMsg & "<a href=" & m_sPageFrom & ">Вернуться...</a>"
            sMsg = sMsg & "</p>"

            Response.Write(sMsg)
        End If
    End Sub

    Protected Sub DoPartnerLogin()
        Dim sLogin As String, sPassword As String, sSql As String, sResult As String, sMsg As String

        sLogin = Request.Form("txtLogin")
        sPassword = Request.Form("txtPassword")

        sSql = "SELECT ID & ';' & Dealer FROM tblDealers WHERE DealerEmail = " & Quotes(sLogin) & " AND DealerPassword = " & Quotes(sPassword)
        sResult = DbExecSqlQuery(sSql, sDbOrConn:="SSClients")

        'sSql = "SELECT * FROM tblDealers WHERE Email = '" & sLogin & "' AND Password = '" & sPassword & "'"
        'dtA = DbGetDataTableBySql(sSql)

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            Session("UserType") = "Dealer"
            Session("UserID") = BeforeSubstr(sResult, ";")
            Session("UserName") = AfterSubstr(sResult, ";")

            'Session("UserID") = dtA.Rows(0)("ID")
            'Session("UserName") = dtA.Rows(0)("Dealer")

            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            If Session("UserName") > "" Then
                sMsg = sMsg & "Добро пожаловать, " & Session("UserName") & ".<br />"
            Else
                sMsg = sMsg & "Неправильный логин или пароль.<br /><a href=partner.htm>Вернуться...</a>"
            End If
            sMsg = sMsg & "</p>"

            Response.Write(sMsg)
        End If
    End Sub

    Protected Sub DoClientLogin()
        Dim sLogin As String, sPassword As String, sSql As String, sResult As String, sMsg As String

        sLogin = Request.Form("txtLogin")
        sPassword = Request.Form("txtPassword")

        sSql = "SELECT ID & '|' & Client & '|' & Person FROM tblMain WHERE Email = " & Quotes(sLogin) & " AND ClientPassword = " & Quotes(sPassword)
        sResult = DbExecSqlQuery(sSql, sDbOrConn:="SSClients")

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            Session("UserID") = BeforeSubstr(sResult, ";")
            Session("UserType") = "Dealer"
            Session("UserName") = AfterSubstr(sResult, ";")

            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            If Session("UserName") > "" Then
                sMsg = sMsg & "Добро пожаловать, " & Session("UserName") & ".<br />"
            Else
                sMsg = sMsg & "Неправильный логин или пароль.<br /><a href=partner.htm>Вернуться...</a>"
            End If
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)
        End If
    End Sub

    Protected Sub DoCallMeOrder()
        On Error Resume Next

        Dim sFio As String, sEmail As String, sPhone As String, sRest As String, sCityCode As String, sNotes As String, sResult As String = "0", sAll As String = "", sSql As String, iAffected As Integer, sError As String = ""
        Dim sSubject As String, sMessage As String, sTo As String, sMsg As String, sFormName As String = ""

        sFio = Request.Form("InputFIO")

        sPhone = Request.Form("InputPhone")
        If sPhone Like "8##########" Then
            sRest = Mid(sPhone, 2)
            sCityCode = Left(sRest, 3)
            sRest = Mid(sRest, 4)
            sPhone = sPhone & " readable: 8 " & sCityCode & " " & Left(sRest, 3) & " " & Mid(sRest, 4, 2) & " " & Mid(sRest, 7)
        End If

        sEmail = Request.Form("InputEmail")

        sFormName = Request.Form.AllKeys("id")
        sNotes = Trim(m_sPageFrom & " " & sFormName)

        '<ANTISPAM
        sAll = sFio & " " & sPhone
        If MyTrim(sAll) = "" Then
            Exit Sub 'it's spam
        End If

        If Trim(sPhone) = "" Then
            Exit Sub
        End If

        If Not (sFio Like "*[А-я]*") Then 'если в имени нет русских букв
            If sFio Like "[a-z]*" Then 'и если начинается с маленькой английской
                Exit Sub 'то это спам-биллиберда, выходим
            End If
        End If
        '/>

        '<1. write in db
        sSql = "INSERT INTO tblCallMeOrders (FIO, Phone, Email, Notes, CreateDate) VALUES ("
        sSql = sSql & Quotes(sFio) & ", "
        sSql = sSql & Quotes(sPhone) & ", "
        sSql = sSql & Quotes(sEmail) & ", "
        sSql = sSql & Quotes(sNotes) & ", "
        sSql = sSql & AbsDateTimeFormat(Now, "#") ''sSql = sSql & "#" & Format(Now, "yyyy-mm-dd") & "#"
        sSql = sSql & ")"

        DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients")

        '<2. SEND EMAIL TO PERSONAL
        sMessage = "FIO: " & sFio & vbCrLf
        sMessage &= "Phone: " & sPhone & vbCrLf
        sMessage &= "Email: " & sEmail & vbCrLf
        sMessage &= "Comments: " & sNotes & vbCrLf

        sSubject = "Клиент нажал кнопку Заказать звонок на сайте, заполнив форму " & sFormName & " на странице " & m_sPageFrom

        sTo = "info@prostoysoft.ru" '; sale@simple-soft.ru

        sResult = SendMail(sTo, "prostoysoft@yandex.ru", "", sSubject, sMessage, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)
        '/>

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена, мы перезвоним Вам. Если этого не произойдет, пожалуйcта, свяжитесь Вы с нами.<br />"
            sMsg = sMsg & "<a href=prices.htm>Вернуться...</a>"
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)
        End If

        'Response.Write("Yes")
    End Sub

    Protected Sub DoGiveMeLink(Optional ByVal sProduct As String = "ClientsCount")
        'On Error Resume Next

        Dim sFio As String, sPhone As String = "", sClientEmail As String, sResult As String = "0", sAll As String = "", sSql As String, iAffected As Integer, sFormContent As String
        Dim sSubject As String, sMessage As String = "", sMsg As String, sProductTitle As String = "", sError As String = ""

        If sProduct = "ClientsCount" Then
            sFio = Request.Form("InputFio")
            If sFio = "" Then
                sFio = Request.Form("Fio")
            End If
            sPhone = Request.Form("InputPhone")

            sClientEmail = Request.Form("InputEmail")
            If AfterSubstr(sClientEmail, "@") = "gmal.com" Then
                sClientEmail = Replace(sClientEmail, "gmal.com", "gmail.com", , , CompareMethod.Text)
            End If
        Else 'If sProduct = "SecurityCompany" Then
            sFio = Request.Form("ClientName")
            If sFio = "" Then
                sFio = Request.Form("ClientName2")
            End If
            If sFio = "" Then
                sFio = Request.Form("ClientName3")
            End If
            If sFio = "" Then
                sFio = Request.Form("ClientName4")
            End If

            sClientEmail = Request.Form("ClientEmail")
            If sClientEmail = "" Then
                sClientEmail = Request.Form("ClientEmail2")
            End If
            If sClientEmail = "" Then
                sClientEmail = Request.Form("ClientEmail3")
            End If
            If sClientEmail = "" Then
                sClientEmail = Request.Form("ClientEmail4")
            End If
        End If

        If sFio = "" Then
            sFio = Request.Form("InputFio")
        End If
        If sFio = "" Then
            sFio = Request.Form("ClientName")
        End If
        If sFio = "" Then
            sFio = Request.Form("Fio")
        End If

        sPhone = Request.Form("InputPhone")
        If sPhone = "" Then
            sPhone = Request.Form("Phone")
        End If

        sClientEmail = Request.Form("InputEmail")
        If sClientEmail = "" Then
            sClientEmail = Request.Form("ClientEmail")
        End If
        If sClientEmail = "" Then
            sClientEmail = Request.Form("Email")
        End If

        sAll = sFio & " " & sPhone & " " & sClientEmail
        If MyTrim(sAll) = "" Then
            Exit Sub 'it's spam
        End If

        'sAll = "ИМЯ: " & sFio & vbCr & "ТЕЛЕФОН: " & sPhone & vbCr & "EMAIL:" & sClientEmail

        sFormContent = GetFormContent(Request, "  ;  ")

        '<ANTISPAM
        If ContainsAny(sFio, True, "www", "http") Then
            Exit Sub 'spam
        ElseIf ContainsAny(sAll, True, "clck.ru") Then
            Exit Sub 'spam
        End If
        '/>

        '<1. write in db
        sSql = "INSERT INTO tblGiveMeLinkOrders (FIO, Phone, Email, OrderDate, Product, Comment) VALUES ("
        sSql = sSql & Quotes(sFio) & ", "
        sSql = sSql & Quotes(sPhone) & ", "
        sSql = sSql & Quotes(sClientEmail) & ", "
        sSql = sSql & AbsDateTimeFormat(Now, "#") & ", "
        sSql = sSql & Quotes(sProduct) & ", "
        sSql = sSql & Quotes(sFormContent)
        sSql = sSql & ")"

        DbExecSqlQuery(sSql, iAffected, sError_out:=sError, sDbOrConn:="SSClients")

        '<2. SEND EMAIL TO PERSONAL
        'sMessage = "FIO: " & sFio & vbCrLf
        'sMessage &= "Phone: " & sPhone & vbCrLf
        'sMessage &= "Email: " & sClientEmail & vbCrLf

        'sMessage &= "Добрый день, ув. " & sFio & vbCrLf
        'sMessage &= "Ссылка на загрузку http://www.prostoysoft.ru/ClientsCount.msi & vbCrLf"

        If sProduct = "ClientsCount" Then
            sMessage = sMessage & "Ссылка на загрузку <a href=http://www.prostoysoft.ru/ClientsCount.msi>ClientsCount.msi</a>"
            sProductTitle = "Учет клиентов"
        Else
            sMessage = sMessage & "Ссылка на загрузку <a href=http://www.prostoysoft.ru/" & sProduct & ".exe>" & sProduct & ".exe</a>"
            sProductTitle = sProduct
        End If

        sMessage &= "<p>"
        sMessage &= "<p>При установке вам может мешать антивирус, в этом случае временно отключите его. Мы гарантируем отсутствие вирусов во всех наших программах.<br>"
        sMessage &= "Демо-версия не имеет функциональных ограничений. Только временное – 30 дней.<br>"
        sMessage &= "По окончании этого срока интерфейс программы заблокируется, и для продолжения работы вам нужно будет приобрести лицензию любого типа.<br>"
        sMessage &= "Данные, введенные в базу данных демо-версии, останутся невредимыми в любом случае и никуда не пропадут, вы можете вводить реальные данные уже в демо-версии.<br>"
        sMessage &= "Помимо продажи лицинзий на программы с типовыми конфигурациями базы данных мы также можем оказать вам услугу по созданию индивидуальной конфигурации ""под ключ"" по вашему техническому заданию."
        sMessage &= "Стоимость данной услуги - от 10 000 руб при недельной трудоемкости в зависимости от квалификации ИТ-специалиста."
        sMessage &= "</p>"
        sMessage &= Replace(sFormContent, ";", "<br>")

        sSubject = "Ссылка на загрузку программы """ & sProductTitle & """"

        If sClientEmail > "" Then
            sResult = SendMail(sClientEmail, "prostoysoft@yandex.ru", "", sSubject, sMessage, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, sFormat:="HTML", bBccToAdmin:=True)
        Else '= ""
            sResult = SendMail("info@prostoysoft.ru", "prostoysoft@yandex.ru", "", sSubject & " ClientEmail empty, Product: " & sProduct, sMessage, , "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, sFormat:="HTML", bBccToAdmin:=False)
        End If
        '/>

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"

            If sProduct = "ClientsCount" Then
                sMsg = sMsg & "<b>Прямая ссылка на загрузку программы ""Учет клиентов"" <a href=http://www.prostoysoft.ru/ClientsCount.msi>ClientsCount.msi</a>" & "</b><br><br><br>"
            Else
                sMsg = sMsg & "<b>Прямая Ссылка на загрузку <a href=http://www.prostoysoft.ru/" & sProduct & ".exe>" & sProduct & ".exe</a>" & "</b><br><br><br>"
            End If

            sMsg = sMsg & "Форма отправлена, ожидайте емейл. Если он не придет, пожалуйcта, свяжитесь Вы с нами.<br><br>"
            sMsg = sMsg & "<a href=" & sProduct & ".htm>Вернуться на страницу программного продукта...</a><br><br>"
            sMsg = sMsg & "<a href=prices.htm>Цены и информация по приобретению...</a>"
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)
        End If
    End Sub

    Protected Sub DoPartnerRegister()
        On Error Resume Next

        Dim sFIO As String, sCompany As String, sCity As String, sCountry As String, sAddress As String, sPhone As String, sEmail As String, sGetPartnerNews As String
        Dim sComments As String, sTargetFile As String = "", sSubject As String, sMessage As String = "", sTo As String, sMsg As String, sResult As String, sSql As String
        Dim oPostedFile As HttpPostedFile, sFolder As String, sFile As String, sAll As String, iSubstringCount As Integer

        sFIO = Request.Form("txtFIO")
        sCompany = Request.Form("txtCompany")
        sCity = Request.Form("txtCity")
        sCountry = Request.Form("txtCountry")
        sAddress = Request.Form("txtAddress")
        sPhone = Request.Form("txtPhone")
        sEmail = Request.Form("txtEmail")
        sGetPartnerNews = Request.Form("chkGetPartnerNews")
        sComments = Request.Form("txtComments")

        sAll = sFIO & " " & sCompany & " " & sCity & " " & sCountry & " " & sAddress & " " & sPhone & " " & sEmail & " " & sGetPartnerNews & " " & sComments
        If MyTrim(sAll) = "" Then
            Exit Sub 'it's spam
        Else
            iSubstringCount = SubstringCount(sAll, "http")
            If iSubstringCount >= 1 Then
                Exit Sub 'it's spam
            End If
        End If

        '<1. WRITE IN DB
        sSql = "INSERT INTO tblDealers (Dealer, DealerFIO, Company, DealerEmail, Phone, Country, City, Address, Comments, GetPartnerNews) VALUES ("
        sSql = sSql & Quotes(IIf(sCompany > "", sCompany, sFIO)) & ", "
        sSql = sSql & Quotes(sFIO) & ", "
        sSql = sSql & Quotes(sCompany) & ", "
        sSql = sSql & Quotes(sEmail) & ", "
        sSql = sSql & Quotes(sPhone) & ", "
        sSql = sSql & Quotes(sCountry) & ", "
        sSql = sSql & Quotes(sCity) & ", "
        sSql = sSql & Quotes(sAddress) & ", "
        sSql = sSql & Quotes(sComments) & ", "
        sSql = sSql & IIf(sGetPartnerNews > "", "-1", "0")
        sSql = sSql & ")"
        DbExecSqlQuery(sSql, sDbOrConn:="SSClients")
        '/>

        '<2. SEND EMAIL
        sMessage &= "FIO: " & sFIO & vbCrLf
        sMessage &= "Company: " & sCompany & vbCrLf
        sMessage &= "City: " & sCity & vbCrLf
        sMessage &= "Country: " & sCountry & vbCrLf
        sMessage &= "Address: " & sAddress & vbCrLf
        sMessage &= "Phone: " & sPhone & vbCrLf
        sMessage &= "Email: " & sEmail & vbCrLf
        sMessage &= "GetPartnerNews: " & sGetPartnerNews & vbCrLf
        sMessage &= "Comments: " & sComments & vbCrLf

        sTo = "info@prostoysoft.ru;pr@simple-soft.ru"
        sSubject = "Регистрация партнера"

        sResult = SendMail(sTo, "prostoysoft@yandex.ru", "", sSubject, sMessage, sTargetFile, "smtp.yandex.ru", "prostoysoft", m_sSmtpPassword, 587, bSSL:=True, bBccToAdmin:=False)

        If sResult Like "ОШИБКА*" Then
            Response.Write(sResult)
        Else
            sMsg = "<p align='center' style='font-family: Verdana; font-size: 10pt'>"
            sMsg = sMsg & "Форма отправлена. Спасибо за вашу регистрацию.<br />"
            sMsg = sMsg & "Мы обязательно с вами свяжемся.<br />"
            sMsg = sMsg & "<a href=partner.htm>Вернуться...</a>"
            sMsg = sMsg & "</p>"
            Response.Write(sMsg)

            If sTargetFile > "" Then
                DeleteFile(sTargetFile)
            End If
        End If
        '/>
    End Sub

    'returns eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
    Protected Function GetClientInfoByFio(ByVal sFio As String) As String
        On Error Resume Next

        If Trim(sFio) = "" Then
            Return ""
        End If

        Dim sFioPure As String, iSpacesCount As Integer, a_sVals() As String, sSql As String, sWhere As String = "", sClientID As String = "", sProductInfo As String
        Dim dtA As DataTable, iRecordCount As Integer, sResult As String = ""

        sFioPure = AntiSqlInjection(Trim(sFio))

        iSpacesCount = SubstringCount(sFioPure, " ") 'считаем общее количество пробелов в ФИО
        If iSpacesCount = 0 Then
            Return "" 'не будем искать по одному имени
        ElseIf iSpacesCount = 1 Then
            a_sVals = Split(sFioPure, " ")
            sWhere = " OR Person LIKE '%" & sFioPure & "%'"
            sWhere = sWhere & " OR Person LIKE '%" & a_sVals(1) & " " & a_sVals(0) & "%'"
        ElseIf iSpacesCount >= 2 Then
            a_sVals = Split(sFioPure, " ")
            sWhere = " OR Person LIKE '%" & sFioPure & "%'"
            sWhere = sWhere & " OR Person LIKE '%" & a_sVals(0) & " " & a_sVals(2) & " " & a_sVals(1) & "%'"
            sWhere = sWhere & " OR Person LIKE '%" & a_sVals(2) & " " & a_sVals(1) & " " & a_sVals(0) & "%'"
            sWhere = sWhere & " OR Person LIKE '%" & a_sVals(2) & " " & a_sVals(0) & " " & a_sVals(1) & "%'"
        End If

        ''sFioPure = Trim(BeforeSubstr(sFioPure, " ")) 'get only surname
        sSql = "SELECT TOP 100 ID FROM tblMain WHERE Person = '" & Trim(sFio) & "'" & IIf(sWhere > "", sWhere, "")

        ''sClientID = DbExecSqlQuery(sSql, sDbOrConn:="SSClients")
        dtA = DbGetDataTableBySql(sSql, sDbOrConn:="SSClients")

        If DataTableIsOpen(dtA, bRowsCountNotZero:=True) Then
            iRecordCount = dtA.Rows.Count
            sClientID = dtA.Rows(0)("ID")
        End If

        If sClientID > "" Then
            sSql = "SELECT Product & ' ' & Version & ' ' & LicenseType & ', ' & SaleDate FROM tblSales WHERE ClientID = " & sClientID & " AND RegCode > '' ORDER BY ID DESC"
            sProductInfo = DbExecSqlQuery(sSql, sDbOrConn:="SSClients")

            If iSpacesCount = 1 Then
                sResult = "возможно "
            End If
            sResult = sResult & "ID=" & sClientID & IIf(sProductInfo > "", " " & sProductInfo & " ", "") 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"

            If iRecordCount > 1 Then
                sResult = sResult & " (всего найдено записей " & iRecordCount & ")"
            End If
        End If

        Return Trim(sResult) ''IIf(sResult > "", sResult, "информация не найдена")
    End Function

    'returns eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
    Protected Function GetClientInfoByCompany(ByVal sCompany As String) As String
        On Error Resume Next

        Dim dtA As DataTable, sResult As String = "", iRecordCount As Integer, sCompanyPure As String, sSql As String = "", sClientID As String = "", sProductsInfo As String

        sCompany = Trim(sCompany)
        If sCompany = "" Then
            Return ""
        End If

        '<prepare company
        sCompanyPure = AntiSqlInjection(sCompany)
        If Contains(sCompanyPure, """") Then
            sCompanyPure = AfterAndBeforeSubstr(sCompanyPure, """", """") 'eg Общество с ограниченной ответственностью "ЕвроТрансСтрой" -> ЕвроТрансСтрой
        End If

        If StartsWithAny(sCompanyPure, "АО ", "ООО ", "ЗАО ", "ТОО ", "ОАО ", "АООТ ") Then
            sCompanyPure = AfterSubstr(sCompanyPure, " ")
        End If
        sCompanyPure = Trim(RemoveAllStartSubstrs(sCompanyPure, False, "АО", "ООО", "ЗАО", "ТОО", "ОАО", "Общество с ограниченной ответственностью", "Закрытое акционерное общество"))
        sCompanyPure = Trim(RemoveQuotes(sCompanyPure))

        If Contains(sCompanyPure, """") Then
            sCompanyPure = Trim(AfterSubstr(sCompanyPure, """")) 'eg ООО "ЦКМ"Бенефакта" -> Бенефакта
        End If

        If sCompanyPure Like "ИП *." Then 'eg "ИП Спиридонов Д.В."
            sCompanyPure = BeforeSubstr(sCompanyPure, ".") 'eg "ИП Спиридонов Д"
            If sCompanyPure Like "* [А-Я]" Then
                sCompanyPure = Trim(Left(sCompanyPure, Len(sCompanyPure) - 2))
            End If
        End If

        If sCompanyPure Like "* г.*" Then 'eg "ООО "Базис" г. Казань"
            sCompanyPure = BeforeSubstr(sCompanyPure, " г.") 'eg "ООО "Базис""
        End If
        '/>

        If Len(sCompanyPure) > 1 Then
            If Len(sCompanyPure) > 3 Then
                sSql = "SELECT TOP 100 ID FROM tblMain WHERE Client LIKE '%" & sCompanyPure & "%'"
            Else '2 или 3
                sSql = "SELECT TOP 100 ID FROM tblMain WHERE Client LIKE '%""" & sCompanyPure & """%'"
            End If
        End If

        If sSql > "" Then
            ''sClientID = DbExecSqlQuery(sSql, sDbOrConn:="SSClients")
            dtA = DbGetDataTableBySql(sSql, sDbOrConn:="SSClients")

            If DataTableIsOpen(dtA, bRowsCountNotZero:=True) Then
                iRecordCount = dtA.Rows.Count
                sClientID = dtA.Rows(0)("ID")
                If iRecordCount > 1 Then
                    sResult = " (всего найдено записей " & iRecordCount & ")"
                End If
            End If

            If sClientID > "" Then
                ''sSql = "SELECT Product & ' ' & Version & ' ' & LicenseType & ', ' & SaleDate & ' ' & DealStage FROM tblSales WHERE ClientID = " & sClientID & " AND RegCode > '' ORDER BY ID DESC"
                ''sProductsInfo = DbExecSqlQuery(sSql, sDbOrConn:="SSClients")
                sProductsInfo = GetProductsInfoByClientID(sClientID)

                sResult = "ID=" & sClientID & IIf(sProductsInfo > "", " " & sProductsInfo & " ", "") & sResult 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
            End If
        End If

        Return Trim(sResult) ''IIf(sResult > "", sResult, "информация не найдена")
    End Function

    'returns eg "ID=10000: 123 08.08.2016 Учет клиентов Home 2.915, Оплата получена." 'used 4 times
    Protected Function GetClientInfoByEmail(ByVal sEmail As String) As String
        On Error Resume Next

        Dim dtA As DataTable, sSql As String, sClientID As String, sProductsInfo As String = "", sResult As String = ""

        If Trim(sEmail) = "" Then
            Return ""
        End If

        sEmail = AntiSqlInjection(sEmail)
        sEmail = RemoveAllBrackets(sEmail)

        ''sSql = "SELECT ID FROM tblMain WHERE Email = '" & sEmail & "' OR Email LIKE '%[!A-z0-9_]" & sEmail & "%' OR Email LIKE '%[!A-z0-9_]" & sEmail & "[!A-z0-9_]%' ORDER BY ID DESC"
        ''sClientID = DbExecSqlQuery(sSql, sDbOrConn:="SSClients")
        ''If sClientID > "" Then
        ''    sProductsInfo = GetProductsInfoByClientID(sClientID)

        ''    sResult = "ID=" & sClientID & IIf(sProductsInfo > "", " " & sProductsInfo & " ", "") 'eg "ID=10000 (Учет клиентов 2.915 Home, 08.08.2016)"
        ''End If
        sSql = "SELECT TOP 100 * FROM tblMain WHERE Email = '" & sEmail & "' OR Email LIKE '%[!A-z0-9_]" & sEmail & "%' OR Email LIKE '%[!A-z0-9_]" & sEmail & "[!A-z0-9_]%' ORDER BY ID DESC"
        dtA = DbGetDataTableBySql(sSql, sDbOrConn:="SSClients")

        If DataTableIsOpen(dtA, bRowsCountNotZero:=True) Then
            For i = 0 To dtA.Rows.Count - 1
                sClientID = "" : sProductsInfo = "" 'reset

                sClientID = dtA.Rows(i)("ID")
                sProductsInfo = GetProductsInfoByClientID(sClientID) 'eg "10000 08.08.2016 Учет клиентов Home 2.915, Оплата получена"
                sResult = sResult & "ID=" & sClientID & ": " & IIf(sProductsInfo > "", " " & sProductsInfo & " ", "") & "." 'eg "ID=10000: 12345 08.08.2016 Учет клиентов Home 2.915, Оплата получена."
            Next
        End If

        If sResult = "" Then
            sResult = "в БД клиентов Простой софт информации не найдено"
        End If

        Return Trim(sResult) ''IIf(sResult > "", sResult, "информация не найдена")
    End Function

    'eg "123 08.08.2016 Учет клиентов Home 2.915, Оплата получена"
    Protected Function GetProductsInfoByClientID(ByVal sClientID As String) As String
        On Error Resume Next

        If Trim(sClientID) = "" Then
            Return ""
        End If

        Dim dtA As DataTable, sSql As String, sSaleID As String, sLine As String = "", sProductTitle As String, sVersion As String, sLicenseType As String, sSaleDate As String, sDealStage As String, sResult As String = ""

        sSql = "SELECT * FROM tblSales WHERE ClientID = " & sClientID & " ORDER BY ID"
        dtA = DbGetDataTableBySql(sSql, sDbOrConn:="SSClients")

        If DataTableIsOpen(dtA, bRowsCountNotZero:=True) Then
            For i = 0 To dtA.Rows.Count - 1 'cycle on records
                sSaleID = "" : sProductTitle = "" : sVersion = "" : sLicenseType = "" : sSaleDate = "" : sDealStage = "" 'reset

                sSaleID = dtA.Rows(i)("ID")
                sProductTitle = dtA.Rows(i)("ProductTitle")
                sVersion = dtA.Rows(i)("Version")
                sLicenseType = dtA.Rows(i)("LicenseType")
                sSaleDate = dtA.Rows(i)("SaleDate")
                sDealStage = dtA.Rows(i)("DealStage")

                sLine = Trim(sSaleID & " " & sSaleDate & " " & sProductTitle & " " & Trim(sVersion & " " & sLicenseType) & " " & sDealStage)
                sResult = IIf(sResult > "", sResult & "; ", "") & sLine
            Next
        End If

        Return Trim(sResult) ''IIf(sResult > "", sResult, "информация не найдена")
    End Function

End Class
