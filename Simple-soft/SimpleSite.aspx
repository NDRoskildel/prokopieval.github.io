<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SimpleSite.aspx.vb" Inherits="SimpleSite" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="https://www.w3.org/1999/xhtml/" lang="ru">
<head>
	<title>Облачная платформа "Простой сайт"</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta content="text/css" http-equiv="Content-Style-Type" />
    <meta name="robots" content="index,follow" />
    <meta name="revisit-after" content="30 days" />
	<meta name="description" content="Программы для автоматизации бизнеса, услуги по разработке баз данных. На сайте Вы можете скачать демо-версии программ: Учет клиентов, компьютеров, пациентов, складской учет, управление проектами и др." />
	<meta name="keywords" content="программы для бизнеса, учет клиентов, программы для бизнеса, скачать программы, разработка баз данных, базы данных, програмы, автоматизация, учет, документооборот, делопроизводство, архив документов" />
	<link href="styles.css" type="text/css" rel="stylesheet" />
	<link rel="shortcut icon" href="Images/favicon.ico" type="image/x-icon" />

    <style type="text/css">
        .CPageCaption
        {
            font-family: Trebuchet MS, Verdana;
            font-size: 18pt;
            font-weight: bold;
            color: #086585;
            white-space: nowrap;
        }
        .CPrice
        {
            font-family: Verdana;
            font-size: 19pt;
            color: #086585;
            white-space: nowrap;
            text-align: right;
        }
        .size {
            white-space: nowrap;
            padding-left: 5px;
            padding-right: 10px;
            text-align: center;
            width: 65px;
        }
        .slider_wrap {
            margin: 0px auto 0;
            width: 1065px;
            height: 512px;
            position: relative;
            overflow: hidden;
        }

            .slider_wrap img {
                width: 1024px;
                height: auto;
                display: none;
                position: absolute;
                top: 0;
                left: 20px;
            }

                .slider_wrap img:first-child {
                    display: block;
                }

            .slider_wrap span {
                margin-top: -18px;
                width: 15px;
                height: 26px;
                display: block;
                position: absolute;
                top: 50%;
                cursor: pointer;
                background: url(Images/slider2_arrow.png) no-repeat;
            }

                .slider_wrap span.next {
                    right: 0;
                    background-position: -15px 0;
                }

                    .slider_wrap span.next:hover {
                        background-position: -15px -26px;
                    }

                .slider_wrap span.prev {
                    left: 0;
                    background-position: 0 0;
                }

                    .slider_wrap span.prev:hover {
                        background-position: 0 -26px;
                    }
					
			.CButton2 {
				font-family: Arial, Georgia, "Trebuchet MS";
				font-size: 18px;
				font-weight: bold;
				
				background-position: left top;
				background-repeat: no-repeat;
				border: 0px solid #fff;
				width: 165px;
				height: 45px;
				cursor: pointer;
				text-align: center;
				background-color: #6ab580;
			}	
    </style>

    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.0/jquery.min.js"></script>

    <script type="text/javascript">
        $(function () {
            var elWrap = $('#slider'),
                el = elWrap.find('img'),
                indexImg = 1,
                indexMax = el.length;

            function change() {
                el.fadeOut(500);
                el.filter(':nth-child(' + indexImg + ')').fadeIn(500);
            }

            function autoCange() {
                indexImg++;
                if (indexImg > indexMax) {
                    indexImg = 1;
                }
                change();
            }
            var interval = setInterval(autoCange, 3000);

            elWrap.mouseover(function () {
                clearInterval(interval);
            });
            elWrap.mouseout(function () {
                interval = setInterval(autoCange, 3000);
            });

            elWrap.append('<span class="next"></span><span class="prev"></span>');

            $('span.next').click(function () {
                indexImg++;
                if (indexImg > indexMax) {
                    indexImg = 1;
                }
                change();
            });
            $('span.prev').click(function () {
                indexImg--;
                if (indexImg < 1) {
                    indexImg = indexMax;
                }
                change();
            });
        });
    </script>
	<script language="javascript" type="text/javascript">
	<!--
		function DoPostback() {
			var ddl = document.getElementById('ddlDbFiles');
			var i = ddl.selectedIndex;
			var s = ddl.options[i].innerHTML;
			location.href = 'http://146.120.68.98/SimpleSite/Default.aspx?db=' + s;
		}
	//-->
	</script>
	
	
</head>

<body style="font: Verdana 9pt; margin: 0px 0px 0px 0px;">

<form id="form1" runat="server">
<div>
<input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="/wEPDwUKLTE5MTMzNjY3OQ9kFgICAQ9kFgQCAQ8PFgYeBFRleHQFJ0M6XGluZXRwdWJcd3d3cm9vdFxTaW1wbGVTaXRlXEFwcF9EYXRhXB4JRm9yZUNvbG9yCqQBHgRfIVNCAgRkZAIDDxBkDxYRZgIBAgICAwIEAgUCBgIHAggCCQIKAgsCDAINAg4CDwIQFhEQBQpCb29rc0NvdW50BQpCb29rc0NvdW50ZxAFDENsaWVudHNDb3VudAUMQ2xpZW50c0NvdW50ZxAFCUNvbXBDb3VudAUJQ29tcENvdW50ZxAFC0Nvb2tSZWNlcHRzBQtDb29rUmVjZXB0c2cQBQ9EZW1vRGF0YWJhc2VXZWIFD0RlbW9EYXRhYmFzZVdlYmcQBQ5Eb2N1bWVudHNDb3VudAUORG9jdW1lbnRzQ291bnRnEAULRmluZFJlc3VsdHMFC0ZpbmRSZXN1bHRzZxAFB015RGlzY3MFB015RGlzY3NnEAULTmV3RGF0YWJhc2UFC05ld0RhdGFiYXNlZxAFDVBhdGllbnRzQ291bnQFDVBhdGllbnRzQ291bnRnEAUNUHJvZHVjdHNDb3VudAUNUHJvZHVjdHNDb3VudGcQBQ1Qcm9qZWN0c0NvdW50BQ1Qcm9qZWN0c0NvdW50ZxAFCFJlbnRDYXJzBQhSZW50Q2Fyc2cQBQtTdG9sb3ZheWFNUAULU3RvbG92YXlhTVBnEAUDU1ZEBQNTVkRnEAUUVmV0ZXJpbmFyeU1hbmFnZW1lbnQFFFZldGVyaW5hcnlNYW5hZ2VtZW50ZxAFDVZpc2l0b3JzQ291bnQFDVZpc2l0b3JzQ291bnRnZGRkBILH7HIrqOcqguaB3TU8XmkptPp4/doSoZdBRMG9kYQ=" />
</div>

<div>
	<input type="hidden" name="__EVENTVALIDATION" id="__EVENTVALIDATION" value="/wEWEgLlvorCAgKFtJNhAtX/hfYLAq6T4KYOAteM0QwCpfGY6w0CoKO81QEChfPXkwcC8IiW3AMCz6iPqwMCk861rgsC+fvZlgEC6eLwxgUC/OW47QgCq8mogwoC9ormxwIC0Ln8xAQCoaPFogUORvNYxLHUX67BDua7vpMcjQToZiN9KPooNYcwsNtHTA==" />
</div>

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
<!-- end -->

<!-- Main part -->
<table border="0" width="100%" cellspacing="15" style="margin-top: 7px;">
<tbody valign="top">
	<tr>
        
		<!-- Center part -->
		<td>
                    <table id="tblLogoAndProgramInfo" border="0" width="100%" cellpadding="10">
                        <tr>
                            <td valign="top" rowspan="9" style="width: 1%; padding-top:20px;">
                                <img alt="" src="Images/SimpleSiteLogo.jpg" style="border-style: none" />
                            </td>
                            <td valign="top" colspan="9">
                                <table id="tblProductTitle" border="0" width="100%">
                                    <tr>
                                        <td>
                                            <b class="CPageCaption">Облачная платформа "ПРОСТОЙ САЙТ" SimpleSite</b>
                                        </td>
                                        <td align="center" style="color: DarkRed;"></td>
                                        <td class="CPrice">20000 руб.<sup><a href="prices.htm" title="Лицензия ПРО (10 рабочих мест)" class="CL1">*</a></sup></td>
                                        <td align="center" class="green"><a href="prices.htm?program=16&license=4#OrderForm" style="color: White; text-decoration: none;" target="_parent">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Купить&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a></td>
                                    </tr>
                                    <tr>
                                        <td colspan="9">
                                            <hr class="CHr" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="9">
                                            <div style="color: RoyalBlue; font-family: Trebuchet MS; font-size:14pt; font-weight: bold">
                                                <p>1.&nbsp;&nbsp;<b>Позволяет вести базу данных через браузер</b></p>
                                                <p>2.&nbsp;&nbsp;<b>Может работать с нашего или вашего сервера</b></p>
                                                <p>3.&nbsp;&nbsp;<b>Одновременная работа с windows-программой Prostoysoft Tables</b> <a href="Prostoysoft.htm" style="text-decoration: none">...</a></p>
                                            </div>
                                        </td>
                                    </tr>
                                </table>

                                <p class="CProgVersion">Версия 1.139 от 28.05.2020</p> 
                                <table border="2" cellpadding="4" cellspacing="0" brdercolor="Gainsboro" style="border-color:LightGray;boder-width:2px;boder-style:solid;border-collapse:collapse;font-weight:bold:">
                                    <tr>
                                        <td nowra><img alt="" src="Images/Download1.png" style="border-style: none" /></td>
                                        <td nowra><a href="SimpleSite.msi">Скачать полный дистрибутив</a>&nbsp;&nbsp;</td>
                                        <td class="size">1,6 Mb</td>
                                        <td nowra>MSI-инсталлятор для установки с нуля</td>
                                    </tr>
                                    <tr>
                                        <td nowra><img alt="" src="Images/Download1.png" style="border-style: none" /></td>
                                        <td nowra><a href="SimpleSite.zip">Скачать обновление</a>&nbsp;&nbsp;</td>
                                        <td class="size">1,4 Mb</td>
                                        <td nowra>ZIP-архив для копирования в C:\Inetpub\wwwroot&nbsp;&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>

                    <br />

<h3 style="color: #4682b4;font-size:12pt">Чтобы установить программу, нужно:</h3>
<ol>
    <li>Установить компоненты Windows - Службы IIS и MSMQ (лучше отметить <b style="color:Red"><u>все галочки</u></b> всех компонентов Windows как на <a href="Images/AllWindowsComponents.jpg" target="_blank">скриншоте</a>)</li>
    <li>Установить .NET Framework 4 по <a href="https://www.microsoft.com/ru-ru/download/details.aspx?id=17851">ссылке</a></li>
    <li>Скачать дистрибутив программы "Простой сайт" по первой ссылке выше и запустить установку</li>
</ol>

<h3 style="color: #4682b4;font-size:12pt">Чтобы обновить программу, нужно:</h3>
<ol>
    <li>Скачать обновление</li>
    <li>Извлечь из архива папку SimpleSite</li>
    <li>Откопировать ее в папку C:\Inetpub\wwwroot\ поверх старой с заменой файлов</li>
</ol>


<p class="CPageCaption"><b>Демо-версия онлайн</b></p>
Для ознакомления выберите базу данных&nbsp;&nbsp;<asp:DropDownList ID="ddlDbFiles" runat="server"></asp:DropDownList>&nbsp;и <b><a href="javascript:DoPostback()" style="border: 2px dashed teal; padding: 6px"> перейдите по ссылке </a></b><br />
<div style="color:Red">Логин: <b>admin</b>, без пароля.</div>
<p>
Вы можете <b><a href="Upload.aspx">загрузить свою БД</a></b> и посмотреть, как она будет выглядеть в системе "Простой сайт".
</p>       

<p class="CPageCaption" style="margin-top: 33px"><b>Видео презентации</b></p>

<b>1. Как мы сами ведем учет в облачной системе "Простой сайт"</b><br />

<iframe width="560" height="315" src="https://www.youtube.com/embed/KtH18ndQxRE" frameborder="0" allowfullscreen="true"></iframe>
				
<br /><br /><br />

<b>2. Генерация документов и отправка их по e-mail в облачной системе "Простой сайт"</b><br />

<iframe width="560" height="315" src="https://www.youtube.com/embed/tqlaVILgEk0" frameborder="0" allowfullscreen="true"></iframe>
				
<br /><br /><br />

<b>3. "Простой сайт" - разворачиваем через копирование</b><br />

<iframe width="560" height="315" src="https://www.youtube.com/embed/FiAq0MohFTQ"  frameborder="0" allowfullscreen="true"></iframe>
				
<br /><br /><br />

<b>4. Общий обзор возможностей облачной системы "Простой сайт"</b><br />

<object width="420" height="315">
<param name="movie" value="https://www.youtube.com/v/PT5YcjAfOn8?version=3&amp;hl=ru_RU" />
<param name="allowFullScreen" value="true" />
<param name="allowscriptaccess" value="always" />
<embed src="https://www.youtube.com/v/PT5YcjAfOn8?version=3&amp;hl=ru_RU" type="application/x-shockwave-flash" width="560" height="315" allowscriptaccess="always" allowfullscreen="true" />
</object>

<br /><br /><br />

<b>5. Установка системы "Простой сайт"</b><br />

<object width="420" height="315">
<param name="movie" value="https://www.youtube.com/v/boq8kVl4xMk?version=3&amp;hl=ru_RU" />
<param name="allowFullScreen" value="true" />
<param name="allowscriptaccess" value="always" />
<embed src="https://www.youtube.com/v/boq8kVl4xMk?version=3&amp;hl=ru_RU" type="application/x-shockwave-flash" width="560" height="315" allowscriptaccess="always" allowfullscreen="true" />
</object>
				
<br /><br /><br />


<table>
    <tr>
        <td> <img alt="" src="Images/ScreenShotLogo1.png" style="border-style: none;" /> </td>
        <td> <h3 style="color: #4682b4;font-size:15.5pt">Скриншоты программы</h3> </td>
    </tr>
</table>
<br />
<div style="border: thin solid #E5E5E5; border-radius: 15px; background-color: #FFFFFF; box-shadow: 0 0 15px rgba(0,0,0,0.4); margin-bottom: 50; padding: 0px 12px 12px 12px; width: 95%">
    <table border="0" cellpadding="10" width="100%">

        <tr>
            <td><p style="color: #086585; font-weight: bolder"></p></td>
            <td><p style="color: #086585; font-weight: bolder"></p></td>
            <td><p style="color: #086585; font-weight: bolder"></p></td>
        </tr>
        <tr>
            <td><a href="Images/SimpleSite1_1.gif" target="_blank"><img alt="Кликните для увеличения" src="Images/SimpleSite1_small.gif" style="border-style: none" /></a></td>
            <td><a href="Images/SimpleSite2_1.gif" target="_blank"><img alt="Кликните для увеличения" src="Images/SimpleSite2_small.gif" style="border-style: none" /></a></td>
            <td><a href="Images/SimpleSite3_1.gif" target="_blank"><img alt="Кликните для увеличения" src="Images/SimpleSite3_small.gif" style="border-style: none" /></a></td>
        </tr>

        <tr>
            <td><p style="color: #086585; font-weight: bolder"></p></td>
            <td><p style="color: #086585; font-weight: bolder"></p></td>
            <td><p style="color: #086585; font-weight: bolder"></p></td>
        </tr>
        <tr>
            <td><a href="Images/SimpleSite5_1.gif" target="_blank"><img alt="Кликните для увеличения" src="Images/SimpleSite5_small.gif" style="border-style: none" /></a></td>
            <td><a href="Images/SimpleSite6_1.gif" target="_blank"><img alt="Кликните для увеличения" src="Images/SimpleSite6_small.gif" style="border-style: none" /></a></td>
            <td><a href="Images/SimpleSite7_1.gif" target="_blank"><img alt="Кликните для увеличения" src="Images/SimpleSite7_small.gif" style="border-style: none" /></a></td>
        </tr>

    </table>
</div>


<br /><br /><br /><br />
<div id="slider" class="slider_wrap">
	<img alt="Image 1" class="active" src="Images/SimpleSite1.gif" />
	<img alt="Image 2" src="Images/SimpleSite2.gif" />
</div>

<br /><br />
<table>
    <tr>
        <td> <img alt="" src="Images/PlusLogo.png" style="border-style: none;" /> </td>
        <td></td>
        <td> <h3 style="color: #4682b4;font-size:15.5pt"><br />Преимущества системы</h3> </td>
    </tr>
</table>
<br />


<div style="border: thin solid #E5E5E5; border-radius: 15px; background-color: #FFFFFF; box-shadow: 0 0 15px rgba(0,0,0,0.4); margin-bottom: 50px; padding: 0px 12px 12px 12px; width: 95%">
    <table width="100%" border="0" cellpadding="10">
        <tbody valign="top">
            <tr>
                <td><img alt="" src="Images/Plus1.png" style="border-style: none" /></td>
                <td>
                    <div style="padding-top: 2px; padding-bottom: 5px"><b>Возможность ведения вашей корпоративной базы данных через браузер с любого компьютера, подключенного к Интернет. Плюс, есть возможность использования с любой платформы (Android, iOS, Mac) </b></div>
                </td>
                <td><img alt="" src="Images/Plus3.png" style="border-style: none" /></td>
                <td>
                    <div style="padding-top: 2px; padding-bottom: 5px"><b>Возможность конфигурирования вашей БД - создание новых таблиц, полей, связей, отчетов в онлайн.</b></div>
                </td>
            </tr>
            <tr>
                <td><img alt="" src="Images/Plus2.png" style="border-style: none" /></td>
                <td>
                    <div style="padding-top: 2px; padding-bottom: 5px"><b>Возможность публикации части информации для ваших клиентов, авторизация клиентов и просмотр разрешенной им информации.</b></div>
                </td>
                <td><img alt="" src="Images/Plus4.png" style="border-style: none" /></td>
                <td>
                    <div style="padding-top: 2px; padding-bottom: 5px"><b>Многопользовательский режим</b></div>
                </td>
            </tr>
        </tbody>
    </table>
</div>


                    <table>
                        <tr>
                            <td> <img alt="" src="Images/FunctionLogo.png" style="border-style: none;" /> </td>
                            <td></td>
                            <td> <h3 style="color: #4682b4;font-size:15.5pt"><br />Важная информация</h3> </td>
                        </tr>
                    </table>
                    <br />

                    <div style="border: thin solid #E5E5E5; border-radius: 15px; background-color: #FFFFFF; box-shadow: 0 0 15px rgba(0,0,0,0.4); margin-bottom: 50px; padding: 0px 12px 12px 12px; width: 95%">
                        <table width="100%" border="0" cellpadding="10">
                            <tbody valign="top">
                                <tr>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Программа "Простой сайт" является программным продуктом, построенным на основе технологии Microsoft ASP.NET, и обеспечивает доступ к базе данных любой конфигурации, созданной в любой Windows-программе от компании "Простой софт" через веб-интерфейс посредством браузера.</b></div>
                                    </td>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Программа не требует какой-либо специальной адаптации или настроек конфигурации базы данных для использования через веб-интерфейс.</b></div>
                                    </td>
                                </tr>
                                <tr>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Реализована поддержка обоих СУБД - и Access, и Microsoft SQL Server.</b></div>
                                    </td>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Решение поставляется частично с открытым кодом (клиентский проект с ASPX страницами), но часть проектов (бизнес-логика, уровень работы с БД, композитные разработанные элементы) - закрытый код. Большие возможности по стилизации и кастомизации.</b></div>
                                    </td>
                                </tr>
                                <tr>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Можно вести одну и ту же БД, одновременно используя windows-программу и данный веб-интерфейс.</b></div>
                                    </td>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Имеются специальные настройки со специфическими для веб-проекта особенностями (размер пейджинга, время сессии и др.).</b></div>
                                    </td>
                                </tr>
								
								
                                <tr>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Для инсталляции и запуска такой системы у себя требуется компьютер с платформой Windows и установленным IIS (Internet Information Server), начиная с версии 5. Он уже есть во всех операционных системах семейства Windows (его нужно только включить, что делается в установке/удалении компонентов Windows).</b></div>
                                    </td>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Рекомендуемый браузер - Internet Explorer, но весь функционал также тестируется и должен работать под Opera, Mozilla, Google Chrome. Под другими браузерами программа не тестируется.</b></div>
                                    </td>
                                </tr>

								<tr>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Возможности интерфейса данной веб-программы уступают возможностям программ windows в силу ограничений языка HTML и веб-страниц. Слишком большие и сложные конфигурации баз данных использовать в веб, возможно, придется с некоторыми адаптационными работами (уменьшение видимых полей в некоторых таблицах и т.п.).</b></div>
                                    </td>
                                    <td><img alt="" src="Images/tick.jpg" style="border-style: none" /></td>
                                    <td>
                                        <div style="padding-top: 2px; padding-bottom: 5px"><b>Некоторые функциональные моменты находятся еще только в процессе реализации (пользовательские кнопки и скрипты и др.).</b></div>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </div>

<table>
    <tr>
        <td> <img alt="" src="Images/InstallLogo.png" style="border-style: none;" /> </td>
        <td></td>
        <td> <h3 style="color: #4682b4;font-size:15.5pt"><br />Установка программы</h3> </td>
    </tr>
</table>
<p>Для установки данной программы на компьютер с Интернет-сервером Internet Information Server (IIS) необходимо:</p>
<ul>
	<li>Скачать программу <a href="SimpleSite.msi">SimpleSite.msi</a></li>
	<li>Запустить программу установки сделав двойной клик на скаченном файле</li>
	<li>Следуя инструкциям программы-установщика инсталлировать программу</li>
	<li>Если все необходимые компоненты Windows были включены, то система будет опубликована и запустится стартовая страница в браузере</li>
</ul>

<br /><br />

			
<h3 style="color: #4682b4;font-size:15.5pt">Свидетельство Роспатента</h3>
<table border="0" cellpadding="5">
<tr>
<td><a href="Images/Rosp10.jpg" target="_blank"><img alt="Кликните для увеличения" src="Images/Rosp10.jpg" width="232" height="332" style="border-style: none" /></a></td>
</tr>
</table>

<br /><br />
<table>
    <tr>
        <td> <img alt="" src="Images/HistoryLogo.png" style="border-style: none;" /> </td>
        <td></td>
        <td> <h3 style="color: #4682b4;font-size:15.5pt"><br />История версий</h3> </td>
    </tr>
</table>
<br />

<table border="1" cellpadding="4" cellspacing="0" bordercolor="LightGrey">			
<tr><th>Версия</th><th align="left">Что нового</th></tr><tr>
<td>1.139</td>
<td>
1. Реализована команда DocumentByTemplate<br>
2. Доработки по экспорту в RTF-документы
</td>
</tr>
<tr>
<td>1.136</td>
<td>
1. Возможность создавать пользовательские кнопки с различными командами (GoToTableAndRecord и др.)
</td>
</tr>
<tr>
<td>1.125</td>
<td>
1. В параметрах реализован механизм управления основными вкладками - их можно задавать для каждого пользователя
</td>
</tr>
<tr>
<td>1.122</td>
<td>
1. Добавлен показ картинок в режиме таблицы<br>
2. Переработан элемент - выпадающий календарь
</td>
</tr>
<tr>
<td>1.113</td>
<td>
1. Доработки по правам доступа и безопасности
</td>
</tr>
<tr>
<td>1.112</td>
<td>
1. Доработка экспорта в .CSV
</td>
</tr>
<tr>
<td>1.111</td>
<td>
1. Доработка формы для редактирования - пользовательские вкладки и позиционирование, заданное пользователем
</td>
</tr>
<tr>
<td>1.99</td>
<td>
1. Доработка формы редактирования - поддержка вкладок и позиционирования, заданного пользователем<br>
2. Реализация панели слева - возможность отображать календарь и быстрые фильтры
</td>
</tr>
<tr>
<td>1.96</td>
<td>
1. Доработки правил цветовыделения - применяются правила, заданные на уровне полей<br>
2. Ряд других улучшений и доработок
</td>
</tr>
<tr>
<td>1.92</td>
<td>
1. Реализована поддержка основных вкладок<br>
2. Реализован многопользовательский режим "Для всех"
</td>
</tr>
<tr class="old">
	<td>1.86</td>
	<td>
		1. Реализована маска ввода, формат поля<br />
		2. Реализованы правила горизонтальной фильтрации прав доступа<br />
		3. Реализовано заполнение многих служебных полей (LastModifiedUser и др.)<br />
		4. Ряд других улучшений и исправлений<br />
    </td>
</tr>
<tr>
	<td>1.84</td>
	<td>
		1. Реализована генерация RTF-документов по шаблонам<br />
		2. Ряд других улучшений и исправлений<br />
    </td>
</tr>
<tr>
	<td>1.83</td>
	<td>
		1. Доработки формы "Настройка полей"<br />
    </td>
</tr>
<tr>
	<td>1.80</td>
	<td>
		1. Реализовано сохранение текущей вкладки подтаблиц при перемещении между страницами<br />
    </td>
</tr>
<tr>
	<td>1.72</td>
	<td>
		1. Доработки при работе с Microsoft SQL Server<br />
    </td>
</tr>
<tr>
	<td>1.71</td>
	<td>
		1. Доработки формы открытия БД - можно сразу открывать БД любого формата, автоматический подбор строки соединения с MS SQL Server<br />
    </td>
</tr>
<tr>
	<td>1.68</td>
	<td>
		1. Доработки при работе с базами данных под MS SQL Server<br />
    </td>
</tr>
<tr>
	<td>1.67</td>
	<td>
		1. Доработки при работе с формой редактирования - заполнение одноименных полей, пересчет значений по умолчанию и т.п.<br />
    </td>
</tr>
<tr>
	<td>1.64</td>
	<td>
		1. Доработки по триггерам - реализована поддержка условий в триггерах<br />
		2. Доработки значений по умолчанию по формулам<br />
		3. Доработки по работе с несколькими базами данных (смена текущей БД и тп)<br />
    </td>
</tr>
<tr>
	<td>1.63</td>
	<td>
		1. Добавлен выпадающий календарь для полей типа "Дата и время"<br />
    </td>
</tr>
<tr>
	<td>1.60</td>
	<td>
		1. Реализован показ подчиненных таблиц в форме для редактирования<br />
    </td>
</tr>
<tr>
	<td>1.55</td>
	<td>
		1. Реализовано копирование настроек меню и панелей инструментов от одного пользователя другим<br />
    </td>
</tr>
<tr>
	<td>1.53</td>
	<td>
		1. Доработки по отчетам<br />
    </td>
</tr>
<tr>
	<td>1.50</td>
	<td>
		1. Доработки по триггерам<br />
		2. Доработки по отчетам<br />
		3. Доработки по безопасности<br />
    </td>
</tr>
<tr>
	<td>1.45</td>
	<td>
		1. Реализованы триггеры<br />
		2. Оптимизирована производительность<br />
    </td>
</tr>
<tr>
	<td>1.41</td>
	<td>
		1. Доработки по экспорту в Word и Excel<br />
    </td>
</tr>
<tr>
	<td>1.40</td>
	<td>
		1. Доработки по панели инструментов<br />
    </td>
</tr>
<tr>
	<td>1.38</td>
	<td>
		1. Доработки по фильтрам<br />
		2. Ряд других улучшений и исправлений<br />
    </td>
</tr>
<tr>
	<td>1.36</td>
	<td>
		1. Реализована поддержка СУБД Microsoft SQL Server. Меняется в общих настройках или в файле Server.config<br />
		2. Много других доработок<br />
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



					<footer class="footer-distributed">

						<div class="footer-left">

							<h3>Простой<span>Софт</span></h3>

							<p class="footer-links">
								<a href="index.htm">Главная</a>
								·
								<a href="programs.htm">Программы</a>
								·
								<a href="services.htm">Услуги</a>
								·
								<a href="prices.htm">Цены</a>
								·
								<a href="faq.htm">Вопросы</a>
								·
								<a href="contacts.htm">Контакты</a>
							</p>

							<p class="footer-company-name">Простой софт &copy; 2017</p>
							
            
<!-- Rating Mail.ru counter -->
<script type="text/javascript">
    var _tmr = window._tmr || (window._tmr = []);
    _tmr.push({ id: "1029407", type: "pageView", start: (new Date()).getTime() });
    (function (d, w, id) {
        if (d.getElementById(id)) return;
        var ts = d.createElement("script"); ts.type = "text/javascript"; ts.async = true; ts.id = id;
        ts.src = "https://top-fwz1.mail.ru/js/code.js";
        var f = function () { var s = d.getElementsByTagName("script")[0]; s.parentNode.insertBefore(ts, s); };
        if (w.opera == "[object Opera]") { d.addEventListener("DOMContentLoaded", f, false); } else { f(); }
    })(document, window, "topmailru-code");
</script><noscript><div>
<img src="https://top-fwz1.mail.ru/counter?id=1029407;js=na" style="border:0;position:absolute;left:-9999px;" alt="Top.Mail.Ru" />
</div></noscript>
<!-- //Rating Mail.ru counter -->
<!-- Rating Mail.ru logo -->
<a href="https://top.mail.ru/jump?from=1029407">
<img src="https://top-fwz1.mail.ru/counter?id=1029407;t=479;l=1" style="border:0;" height="31" width="88" alt="Top.Mail.Ru" /></a>
<!-- //Rating Mail.ru logo -->


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
							
						</div>

						<div class="footer-center">

							<div>
								<i class="fa fa-map-marker"></i>
								<p><span>Санкт-Петербург</span>ул.Ворошилова, д.2, офис 104 БЦ "Охта"</p>
							</div>

							<div>
								<i class="fa fa-phone"></i>
								<p>+7 (812) 309-46-42 c 10 до 18 пн-пт</p>
							</div>

							<div>
								<i class="fa fa-envelope"></i>
								<p><a href="support.htm">Обратиться в поддержку</a></p>
							</div>

						</div>

						<div class="footer-right">

							<p class="footer-company-about">
								<span>О компании</span>
								Программы для дома и офиса!
							</p>
							<p class="CAge">16+</p>

<div class="footer-icons">
								<a href="https://vk.com/prostoysoft"><i class="fa fa-vk"></i></a>
								<a href="#"><i class="fa fa-facebook"></i></a>
								<a href="#"><i class="fa fa-twitter"></i></a>
							</div>

						</div>

					</footer>

					
                </td>
	</tr>
</tbody>
</table>

    </form>

</body>

</html>