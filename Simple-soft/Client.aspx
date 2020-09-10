<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Client.aspx.vb" Inherits="Client" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="https://www.w3.org/1999/xhtml/" lang="ru">
<head>
<title>Простой софт - страница клиента</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta content="text/css" http-equiv="Content-Style-Type" />
<link href="styles.css" type="text/css" rel="stylesheet" />
</head>

<body style="font: Verdana 9pt; margin: 0px 0px 0px 0px;">

    <form id="form1" runat="server">

<!-- Header -->
<table id="tblHead" border="0" width="100%" cellspacing="0" cellpadding="0" style="margin-top: -2px; height: 160px;">
	<tr valign="top">
		<td style="width: 300px; background-image: url(Images/HeadBg.jpg); background-repeat: no-repeat;">
            <table id="tblLogo" border="0" cellspacing="0" cellpadding="0" style="color: DimGray;"> 
                <tr>
                    <td><a href="index.htm"><img alt="" border="0" src="Images/Logo.png" style="margin-top: 40px; margin-bottom: 2px; margin-left: 22px;" /></a></td>
                </tr>
                <tr>
                    <td align="right" style="padding-top: 3px;">
                        <div class="CPhone">+7 (812) 309-46-42 c 10 до 18</div>
                    </td>
                </tr>
            </table>
        </td>
		<td style="background-image: url(Images/Head.jpg); background-repeat: repeat-x;">
            &nbsp;
        </td>
	</tr>
</table>

<!--Сommon menu-->
<div id="divMenuLinks" class="CMenuBox">
	<span><a href="index.htm" class="CMenu">Главная</a></span>
	<span>|<a href="programs.htm" class="CMenu">Программы</a></span>
    <span>|<a href="databases.htm" class="CMenu">Конфигурации</a></span>
	<span>|<a href="services.htm" class="CMenu">Услуги</a></span>
	<span>|<a href="prices.htm" class="CMenu">Цены</a></span>
	<span>|<a href="download.htm" class="CMenu">Скачать</a></span>
	<span>|<a href="contacts.htm" class="CMenu">Контакты</a></span>
	<span>|<a href="faq.htm" class="CMenu">Вопросы</a></span>
    <span>|<a href="gallery.htm" class="CMenu">Галерея</a></span>
	<span>|<a href="clients.htm" class="CMenu">Клиенты</a></span>
	<span>|<a href="partner.htm" class="CMenu">Партнеры</a></span>
    <span>|<a href="job.htm" class="CMenu">Работа</a></span>
	<span>|<a href="support.htm" class="CMenu">Поддержка</a></span>
	<span>|<a href="phpBB3/index.php" class="CMenu" target="_blank">Форум</a></span>
</div>

<!-- Main part -->
<table border="0" id="tblMain" width="100%" cellspacing="15" style="margin-top: 7px;">
<tbody valign="top">
	<tr>
		<!-- Left part -->
		<td style="width: 1%;">
            <table id="tblPrograms" border="0" width="188" class="CBorder" cellspacing="5">
				<tr><td class="CNewsCaption" style="background-color: SteelBlue;">Программы</td></tr>
				<tr><td>1. <a href="ClientsCount.htm">Учет клиентов</a></td></tr>
				<tr><td>2. <a href="ProductsCount.htm">Склад и торговля</a></td></tr>
				<tr><td>3. <a href="CompCount.htm">Учет компьютеров</a></td></tr>
				<tr><td>4. <a href="PatientsCount.htm">Учет пациентов</a></td></tr>
				<tr><td>5. <a href="DocumentsCount.htm">Архив документов</a></td></tr>
				<tr><td>6. <a href="VisitorsCount.htm">Учет посетителей</a></td></tr>
				<tr><td>7. <a href="ProjectsCount.htm">Управление проектами</a></td></tr>
				<tr><td>8. <a href="BooksCount.htm">Учет книг</a></td></tr>
				<tr><td>9. <a href="MyDiscs.htm">Мои диски</a></td></tr>
				<tr><td>10. <a href="CookRecepts.htm">Кулинарные рецепты</a></td></tr>
				<tr><td>11. <a href="FindResults.htm">Анализ результатов поиска</a></td></tr>
				<tr><td>12. <a href="SimpleSite.aspx">Простой сайт</a></td></tr>
			</table>
			<br /><br />
		</td> 

		<!-- Center part -->
		<td>
			<div style="white-space: nowrap"><b class="CPageCaption">Простой софт - страница клиента</b></div>
			<hr style="text-align: left" />

            <br />

            <p>
            Добро пожаловать!
            </p>



		</td>
		
		<!-- Right part -->
		<td>

		</td>
	</tr>
	<tr>
	
		<!-- Bottom part -->
		<td colspan="2">
			<br />
			<hr />

<table border="0" class="CFooter" width="100%" cellspacing="1">
	<tr>
		<td id="tdCounters" valign="top">

		</td>
        	
		<td id="tdBanner" align="center" valign="top">

		</td>
		
        <td valign="top" class="CCopyright">© 2007-2015 <a href="index.htm">ООО "Простой софт"</a>, <a href="mailto:info@simple-soft.ru">Иван Абрамов</a><br />
            <div style="margin-top: 5px;">
            Санкт-Петербург, ул.Ворошилова, д.2, офис 104<br />    
            БЦ "Охта", +7 (812) 309-46-42 c 10 до 18 пн-пт
            </div>
            <p class="CAge">16+</p></td>
	</tr>
</table>

		</td>
	</tr>
</tbody>
</table>

    </form>

</body>
</html>