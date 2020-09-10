<%@ Page Language="VB" AutoEventWireup="false" CodeFile="InfoBlock_Left.aspx.vb" Inherits="InfoBlock_Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="https://www.w3.org/1999/xhtml/">
<head runat="server">
    <title></title>
    <link href="styles.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <table id="tblNews" runat="server" border="0" width="188" class="CBorder" cellspacing="5">
	    <tr><td class="CNewsCaption" style="background-color: SteelBlue;">Новости</td></tr>
    </table>

    <table id="tblPrograms" runat="server" border="0" width="188" class="CBorder" cellspacing="5" style="margin-top:20px;">
		<tr><td class="CNewsCaption" style="background-color: SteelBlue;">Программы</td></tr>
		<tr><td>1. <a href="ClientsCount.htm" target="_parent">Учет клиентов</a></td></tr>
		<tr><td>2. <a href="ProductsCount.htm" target="_parent">Склад и торговля</a></td></tr>
		<tr><td>3. <a href="CompCount.htm" target="_parent">Учет компьютеров</a></td></tr>
		<tr><td>4. <a href="PatientsCount.htm" target="_parent">Учет пациентов</a></td></tr>
		<tr><td>5. <a href="DocumentsCount.htm" target="_parent">Архив документов</a></td></tr>
		<tr><td>6. <a href="VisitorsCount.htm" target="_parent">Учет посетителей</a></td></tr>
		<tr><td>7. <a href="ProjectsCount.htm" target="_parent">Управление проектами</a></td></tr>
		<tr><td>8. <a href="BooksCount.htm" target="_parent">Учет книг</a></td></tr>
		<tr><td>9. <a href="MyDiscs.htm" target="_parent">Мои диски</a></td></tr>
		<tr><td>10. <a href="CookRecepts.htm" target="_parent">Кулинарные рецепты</a></td></tr>
		<tr><td>11. <a href="FindResults.htm" target="_parent">Анализ результатов поиска</a></td></tr>
		<tr><td>12. <a href="SimpleSite.aspx" target="_parent">Простой сайт</a></td></tr>
	</table>

	<table id="tblConfigurations" runat="server" border="0" width="188" class="CBorder" cellspacing="5" style="font-size: 8pt; margin-top:20px;">
		<tr><td class="CNewsCaption" style="background-color: SteelBlue;">Конфигурации</td></tr>
		<tr><td>1. <a href="Strahovanie.htm" target="_parent">Страховая компания</a></td></tr>
		<tr><td>2. <a href="transport.htm" target="_parent">Транспортная компания</a></td></tr>
		<tr><td>3. <a href="AdsAgency.htm" target="_parent">Рекламное агентство</a></td></tr>
		<tr><td>4. <a href="AutoClaims.htm" target="_parent">Учет заявок по гарантии</a></td></tr>
		<tr><td>5. <a href="LearningCenter.htm" target="_parent">Обучающий центр</a></td></tr>
		<tr><td>6. <a href="Potolki.htm" target="_parent">Производство потолков</a></td></tr>
		<tr><td>7. <a href="Domofon.htm" target="_parent">Домофоны и антенны</a></td></tr>
		<tr><td>8. <a href="Beauty.htm" target="_parent">Салон красоты</a></td></tr>
		<tr><td>9. <a href="SchoolComp.htm" target="_parent">Учет в школе</a></td></tr>
		<tr><td>10. <a href="Stolovaya.htm" target="_parent">Простая столовая</a></td></tr>
		<tr><td>11. <a href="Events.htm" target="_parent">Учет мероприятий</a></td></tr>
		<tr><td>12. <a href="Print.htm" target="_parent">Типография</a></td></tr>
        <tr><td>13. <a href="Tours.htm" target="_parent">Турагентство</a></td></tr>
        <tr><td>14. <a href="Hotel.htm" target="_parent">Простая гостиница</a></td></tr>
        <tr><td>15. <a href="Lawyer.htm" target="_parent">Юридическое дело</a></td></tr>
        <tr><td>16. <a href="Realty.htm" target="_parent">Агентство недвижимости</a></td></tr>
        <tr><td>17. <a href="Fitness.htm" target="_parent">Фитнес-клуб</a></td></tr>
        <tr><td>18. <a href="PhotoSalon.htm" target="_parent">Фотосалон</a></td></tr>
        <tr><td>19. <a href="Farm.htm" target="_parent">Кролеферма</a></td></tr>
        <tr><td>20. <a href="Dento.htm" target="_parent">Стоматология</a></td></tr>
        <tr><td>21. <a href="Veterinary.htm" target="_parent">Ветеринарная клиника</a></td></tr>
        <tr><td>22. <a href="WindowsDoors.htm" target="_parent">Окна и двери</a></td></tr>
        <tr><td>23. <a href="Equipment.htm" target="_parent">Монтаж оборудования</a></td></tr>
        <tr><td>24. <a href="Repairing.htm" target="_parent">Ремонтная мастерская</a></td></tr>
        <tr><td>25. <a href="Atelier.htm" target="_parent">Ателье</a></td></tr>
        <tr><td>26. <a href="Building.htm" target="_parent">Строительство</a></td></tr>
        <tr><td>27. <a href="AutoParts.htm" target="_parent">Продажа автозапчастей</a></td></tr>
        <tr><td>28. <a href="MovieCollection.htm" target="_parent">Коллекция аудио/видео</a></td></tr>
        <tr><td>29. <a href="Rent.htm" target="_parent">Прокат</a></td></tr>
        <tr><td>30. <a href="Cadres.htm" target="_parent">Кадровый учет</a></td></tr>
        <tr><td>31. <a href="Transports.htm" target="_parent">Учет автотранспорта</a></td></tr>
        <tr><td>32. <a href="Parking.htm" target="_parent">Автостоянка</a></td></tr>
        <tr><td>33. <a href="Taxi.htm" target="_parent">Такси</a></td></tr>
        <tr><td>34. <a href="Furniture.htm" target="_parent">Мебельное производство</a></td></tr>
        <tr><td>35. <a href="AutoService.htm" target="_parent">Автосервис</a></td></tr>
        <tr><td>36. <a href="Pawnshop.htm" target="_parent">Ломбард</a></td></tr>
        <tr><td>37. <a href="Pharmacy.htm" target="_parent">Аптека</a></td></tr>
        <tr><td align="center" style="font-size: 7pt"><a href="databases.htm" target="_parent"><i>Полный список конфигураций...</i></a></td></tr>
	</table>

	<table id="tblSellers" border="0" width="188" class="CBorder" cellspacing="5" style="margin-top:20px;">
		<tr><td class="CNewsCaption" style="background-color: SteelBlue;" colspan="3">Онлайн консультанты</td></tr>
        <tr><td><b>Вера</b></td><td><img alt="" src="Images/IcqOnline.gif" /></td><td>icq627551485</td></tr>
		<tr><td><b>Анжела</b></td><td><img alt="" src="Images/IcqOnline.gif" /></td><td>icq630078085</td></tr>
        <tr><td><b>Иван</b></td><td><img alt="" src="Images/IcqOnline.gif" /></td><td>icq17227718</td></tr>
	</table>
	<br /><br />

    <!--
    <form id="ClientLogin" method="post" action="sendform.aspx?formtype=ClientLogin">
	<table id="tblClientLogin" border="0" class="CBorder" cellpadding="0" cellspacing="5" style="width: 140px;">
		<tr><td class="CNewsCaption" style="background-color: SteelBlue;" colspan="9">Вход для клиентов</td></tr>
		<tr>
			<td align="center"><b>Логин</b></td>
			<td style="padding-left: 2px; padding-top: 4px;">
                <input type="text" id="txtLogin" name="txtLogin" value="" style="width: 117px;" />
            </td>
		</tr>
		<tr valign="middle">
			<td style="padding-left: 2px;"><b>Пароль</b></td>
			<td style="padding-left: 2px;">
                <input type="password" id="txtPassword" name="txtPassword" value="" style="width: 117px;" />
            </td>
		</tr>
		<tr>
			<td colspan="9" style="padding-left: 58px; padding-top: 2px; padding-bottom: 2px;">
				<input type="submit" id="btnEnter" name="btnEnter" value=" Вход " class="CButton" />
            </td>
		</tr>
		<tr>
			<td colspan="9" align="right">
                <a href="RemindPassword.aspx" class="CSmallText" style="color: RoyalBlue;">Напомнить пароль</a>
            </td>
		</tr>
	</table>
    </form>
	<br />
    -->

</body>
</html>
