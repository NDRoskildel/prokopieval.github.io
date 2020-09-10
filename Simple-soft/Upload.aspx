<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Upload.aspx.vb" Inherits="Upload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="https://www.w3.org/1999/xhtml/" lang="ru">
<head runat="server">
<title>Простой софт - загрузка БД</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta name="robots" content="index,follow" />
<meta name="revisit-after" content="30 days" />
<meta name="description" content="Программы для автоматизации бизнеса, услуги по разработке баз данных. На сайте Вы можете скачать демо-версии программ: Учет клиентов, компьютеров, пациентов, складской учет, управление проектами и др." />
<meta name="keywords" content="программы для бизнеса, учет клиентов, разработка софта, скачать программы, разработка баз данных, базы данных, програмы, автоматизация, учет, документооборот, делопроизводство, архив документов" />
<link href="styles.css" type="text/css" rel="stylesheet" />
<link rel="shortcut icon" href="Images/favicon.ico" type="image/x-icon" />
<style type="text/css">
    ol {margin: 10px 0px 5px 35px;}
    li {margin: 0px 0px 5px 0px;}
</style>
</head>

<body style="font: Verdana 9pt; margin: 0px 0px 0px 0px;">
<form id="form1" runat="server">

<!-- Header -->
<div>
	<table id="tblHead" border="0" width="100%" cellspacing="0" cellpadding="0" style="height: 160px;">
		<tr valign="top">
			<td style="width: 365px; background-image: url(Images/HeadBg.jpg); background-repeat: repeat-x;">
				<table id="tblLogo" border="0" cellspacing="0" cellpadding="0" style="color: DimGray;"> 
					<tr>
						<td><a href="index.htm"><img alt="" border="0" src="Images/Logo.png" style="margin-top: 40px; margin-bottom: 2px; margin-left: 22px;" /></a><a href="index.htm"><img alt="" border="0" src="Images/Logotype.png" style="margin-top: 36px; margin-bottom: 2px; margin-left: 5px; width: 60px; height: 60px" /></a></td>
					</tr>
					<tr>
						<td style="padding-top: 3px; padding-left: 90px">
							<div class="CPhone">+7 (812) 309-46-42 c 10 ?? 18</div>
						</td>
					</tr>
				</table>
			</td>
			<td style="background-image: url(Images/Head.jpg); background-repeat: repeat-x;">
				&nbsp;
			</td>
		</tr>
	</table>
</div>
<!-- Common menu -->
	<div id="divMenuLinks" class="CMenuBox2">
		<div id="menu">
			<ul>
				<li><a href="index.htm">Главная</a></li>
				<li><a href="programs.htm">Программы</a></li>
				<li><a href="services.htm">Услуги</a></li>
				<li><a href="sites.htm">Сайты</a></li>
				<li><a href="download.htm">Скачать</a></li>	

				<li><a href="prices.htm">Цены</a></li>		
				<li><a href="AllEquipment.htm">Оборудование</a></li>	
				<li><a href="faq.htm">Вопросы</a></li>			
				<li><a href="Video.htm">Видео</a></li>
				<li><a href="gallery.htm">Галерея</a></li>				
				<li><a href="responses.htm">Отзывы</a></li>		
				<li><a href="PsSchool.htm">Школа</a></li>		
				<li><a href="partner.htm">Партнеры</a></li>		
				<li><a href="market.htm">Маркет</a></li>	

				<li><a href="contacts.htm">Контакты</a></li>	
				<li><a href="support.htm">Поддержка</a></li>	
				<li><a href="phpBB3/index.php">Форум</a></li>	
			</ul>
		</div>
	</div>
<!-- Main part -->
<table border="0" width="100%" cellspacing="15" style="margin-top: 7px;">
<tbody valign="top">
	<tr>
		<!-- Left part -->
		<td style="width: 1%">
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
                <tr><td>13. <a href="PsPhone.htm">PsPhone</a></td></tr>
                <tr><td>14. <a href="PsMobile.htm">PsMobile</a></td></tr>
                <tr><td>15. <a href="PsMobileScan.htm">PsMobileScan</a></td></tr>
                <tr><td>16. <a href="Prostoysoft.htm">Prostoysoft Tables</a></td></tr>
			</table>
			<br /><br />

		</td> 

		<!-- Center part -->
		<td>
			<table border="0" width="100%" cellpadding="0" cellspacing="0">
				<tr>
					<td style="white-space: nowrap" valign="top">
						<table id="tblCaption" border="0" width="100%">
                            <tr>
                                <td valign="top" nowrap><b class="CPageCaption">Загрузка базы данных для веб-системы 
                                    &quot;Простой сайт&quot;</b></td>
                            </tr>
                        </table>
			            <hr />
					</td>
				</tr>
			</table>

		    <!-- Main Part -->
		    <table border="0" class="CLayoutTable" cellpadding="2" cellspacing="0" align="left">
				<tr>
					<td align="left" style="height: 14px;">
                        <asp:label id="lblMessage" runat="server" CssClass="CMessage" Font-Size="9pt"></asp:label>
                    </td>
				</tr>
				<tr id="trFiles" runat="server">
					<td align="left">
						<fieldset class="CFrame">
                            <legend class="CLegend">Список файлов</legend>

                            <table border="0" cellpadding="2" cellspacing="0" style="margin: 15px 10px 15px 10px;">
                                <tr>
                                    <td>
                                        <asp:DataGrid ID="grdFiles" runat="server" AutoGenerateColumns="False" 
                                            BorderColor="Silver" BorderWidth="1px" CellPadding="3" Width="100%">
                                            <Columns>
                                                <asp:TemplateColumn SortExpression="Checked">
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkChecked" runat="server" />
                                                    </ItemTemplate>
                                                    <HeaderStyle BackColor="Gainsboro" Font-Bold="False" Font-Italic="False" 
                                                        Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                                        Width="1%" />
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn SortExpression="FileIcon" HeaderText="Тип">
                                                    <ItemTemplate>
                                                        <asp:Image ID="imgFileIcon" runat="server" />
                                                    </ItemTemplate>
                                                    <HeaderStyle BackColor="Gainsboro" Font-Bold="False" Font-Italic="False" 
                                                        Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                                        Width="1%" />
                                                </asp:TemplateColumn>
                                                <asp:BoundColumn DataField="FileName" HeaderText="Файл" 
                                                    SortExpression="FileName">
                                                    <HeaderStyle BackColor="Gainsboro" Font-Bold="False" Font-Italic="False" 
                                                        Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
                                                </asp:BoundColumn>
                                                <asp:BoundColumn HeaderText="Размер" SortExpression="FileSize" 
                                                    DataField="FileSize">
                                                    <HeaderStyle BackColor="Gainsboro" Font-Bold="False" Font-Italic="False" 
                                                        Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                                        HorizontalAlign="Right" />
                                                    <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                                        Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Right" 
                                                        Wrap="False" />
                                                </asp:BoundColumn>
                                                <asp:BoundColumn HeaderText="Дата создания" SortExpression="Created" 
                                                    DataField="Created" DataFormatString="{0:dd.MM.yyyy HH:mm}">
                                                    <HeaderStyle BackColor="Gainsboro" Font-Bold="False" Font-Italic="False" 
                                                        Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                                        HorizontalAlign="Right" />
                                                    <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                                        Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Right" 
                                                        Wrap="False" />
                                                </asp:BoundColumn>
                                                <asp:BoundColumn HeaderText="Дата изменения" SortExpression="Modified" 
                                                    DataField="Modified" DataFormatString="{0:dd.MM.yyyy HH:mm}">
                                                    <HeaderStyle BackColor="Gainsboro" Font-Bold="False" Font-Italic="False" 
                                                        Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                                        HorizontalAlign="Right" />
                                                    <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                                        Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Right" 
                                                        Wrap="False" />
                                                </asp:BoundColumn>
                                            </Columns>
                                            <ItemStyle Font-Overline="False" Font-Size="8pt" Font-Strikeout="False" Font-Underline="False" />
                                        </asp:DataGrid>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap>
                                        <br />
                                        <asp:Button ID="btnDelete" runat="server" Text="Удалить" Width="105px" ToolTip="Удалить отмеченное" />
                                    </td>
                                </tr>
                            </table>
                        </fieldset> 
                    </td>
                </tr>
				<tr>
					<td align="left" nowrap>
                    </td>
				</tr>
				<tr id="trUploadFiles" runat="server">
                    <td align="left" nowrap style="padding-top: 4px;">
						<fieldset class="CFrame" style="height: 140px;">
                            <legend class="CLegend">Загрузка файлов</legend>

                            <table border="0" cellspacing="2" cellspacing="0" style="margin: 8px">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblFile" runat="server" Text="Максимальный размер файла 4 Мб"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:FileUpload ID="fupFile" runat="server" Size="75" />
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 8px;">
                                        <asp:Button ID="btnUpload" runat="server" Text="Загрузить" Width="105px" ToolTip="Загрузить указанные файлы на сервер в текущую папку" />
                                    </td>
                                </tr>
                            </table>
						</fieldset>
                    </td>
                </tr>

				<tr>
					<td colspan="9" align="left" nowrap>
						<br />
                        <asp:Button ID="btnReturn" runat="server" Text="ВЕРНУТЬСЯ" class="CButton" Width="120px" />
                        <br />
                    </td>
				</tr>
			</table>


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

<table id="tblCounters" border="0" cellspacing="0" cellpadding="0" style="width: 88px;">
	<tr valign="top">
		<td>
            <!--Rating@Mail.ru COUNTER-->
            <script language="JavaScript" type="text/javascript"><!--
                d = document; var a = ''; a += ';r=' + escape(d.referrer)
                js = 10//--></script><script language="JavaScript1.1" type="text/javascript"><!--
                                         a += ';j=' + navigator.javaEnabled()
                                         js = 11//--></script><script language="JavaScript1.2" type="text/javascript"><!--
                                                                  s = screen; a += ';s=' + s.width + '*' + s.height
                                                                  a += ';d=' + (s.colorDepth ? s.colorDepth : s.pixelDepth)
                                                                  js = 12//--></script><script language="JavaScript1.3" type="text/javascript"><!--
                                                                                       js = 13//--></script><script language="JavaScript" type="text/javascript"><!--
                                                                                       d.write('<a href="https://top.mail.ru/jump?from=1029407"' +
            ' target=_top><img alt="" src="https://d5.cb.bf.a0.top.list.ru/counter' +
            '?id=1029407;t=49;js=' + js + a + ';rand=' + Math.random() +
            '" alt="Рейтинг@Mail.ru"' + ' border=0 height=31 width=88/><\/a>')
                                                                                       if (11 < js) d.write('<' + '!-- ')//--></script><noscript><a target="_top" href="https://top.mail.ru/jump?from=1029407"><img src="https://d5.cb.bf.a0.top.list.ru/counter?js=na;id=1029407;t=49" alt="Рейтинг@Mail.ru" width="88" height="31" style="border-style: none" /></a></noscript><script language="JavaScript" type="text/javascript"><!--
                                                                                                                                                                                                                                                                                                                                                          if (11 < js) d.write('--' + '>')//--></script>
            <!--/COUNTER-->

            <!--LiveInternet counter--><script type="text/javascript"><!--
                                           document.write("<a href='https://www.liveinternet.ru/click' " +
            "target=_blank><img src='https://counter.yadro.ru/hit?t14.6;r" +
            escape(document.referrer) + ((typeof (screen) == "undefined") ? "" :
            ";s" + screen.width + "*" + screen.height + "*" + (screen.colorDepth ?
            screen.colorDepth : screen.pixelDepth)) + ";u" + escape(document.URL) +
            ";" + Math.random() +
            "' alt='' title='LiveInternet: показано число просмотров за 24" +
            " часа, посетителей за 24 часа и за сегодня' " +
            "border=0 width=88 height=31><\/a>")//--></script>
            <!--/LiveInternet-->

            <!-- Yandex.Metrika informer --> <a href="https://metrika.yandex.ru/stat/?id=6041278&amp;from=informer" target="_blank" rel="nofollow"><img src="https://informer.yandex.ru/informer/6041278/2_1_FFFFFFFF_EEEEEEFF_0_pageviews" style="width:80px; height:31px; border:0;" alt="Яндекс.Метрика" title="Яндекс.Метрика: данные за сегодня (просмотры)" class="ym-advanced-informer" data-cid="6041278" data-lang="ru" /></a> <!-- /Yandex.Metrika informer --> <!-- Yandex.Metrika counter --> <script type="text/javascript" > (function(m,e,t,r,i,k,a){m[i]=m[i]||function(){(m[i].a=m[i].a||[]).push(arguments)}; m[i].l=1*new Date();k=e.createElement(t),a=e.getElementsByTagName(t)[0],k.async=1,k.src=r,a.parentNode.insertBefore(k,a)}) (window, document, "script", "https://mc.yandex.ru/metrika/tag.js", "ym"); ym(6041278, "init", { clickmap:true, trackLinks:true, accurateTrackBounce:true, trackHash:true }); </script> <noscript><div><img src="https://mc.yandex.ru/watch/6041278" style="position:absolute; left:-9999px;" alt="" /></div></noscript> <!-- /Yandex.Metrika counter -->

            <div class="CIn">
                <!-- begin of Top100 code -->
                <script id="top100Counter" type="text/javascript" src="https://counter.rambler.ru/top100.jcn?861574"></script><noscript><img src="https://counter.rambler.ru/top100.cnt?861574" alt="" width="1" height="1" border="0"/></noscript>
                <!-- end of Top100 code -->
            
                <!-- begin of Top100 logo -->
                <a href="https://top100.rambler.ru/home?id=861574" target="_blank"><img src="https://top100-images.rambler.ru/top100/banner-88x31-rambler-gray2.gif" alt="Rambler's Top100" width="88" height="31" border="0" /></a>
                <!-- end of Top100 logo -->
            </div>
        </td>
	</tr>
</table>
		</td>
        	
		<td id="tdBanner" align="center" valign="top">
            <a href="index.htm"><img alt="" src="Images/banner460x80.gif" style="border-style: none" /></a>
		</td>
		
        <td valign="top" class="CCopyright" style="width: 265px;">
            © 2007-2017 <a href="index.htm">ООО "Простой софт"</a>, <a href="mailto:info@simple-soft.ru">И.В.Абрамов</a><br />
            <div style="margin-top: 5px;">
            Санкт-Петербург, ул.Ворошилова, д.2, офис 104<br />    
            БЦ "Охта", +7 (812) 309-46-42 c 10 до 18 пн-пт
            </div>
        </td>
	</tr>
</table>

		</td>
	</tr>
</tbody>
</table>

</form>
</body>
</html>