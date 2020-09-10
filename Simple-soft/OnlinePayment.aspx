<%@ Page Language="VB" AutoEventWireup="false" CodeFile="OnlinePayment.aspx.vb" Inherits="Prostoysoft.OnlinePayment" %>
<!DOCTYPE HTML>
<html lang="ru">
<head runat="server">
<meta charset="utf-8" />
    <title>Оплата по карте через Яндекс-кассу</title>
</head>
<body>
    <div class="wrapper">
        <header>

        </header>
        <nav>

        </nav>
        <main>
            <div class="ya-kassa">
                <h3>Онлайн оплата через Яндекс-кассу</h3>
                <form id="YandexKassaForm" runat="server">
                    <label for="YandexKassaForm__programm">Программа:</label>
                    <select id="YandexKassaForm__programm" runat="server" name="programm" required>
                    
                    </select>
                    <label for="YandexKassaForm__license">Вид лицензии:</label>
                    <select name="license" id="YandexKassaForm__license" runat="server" required>

                    </select>
                    <label for="YandexKassaForm__config">Конфигурация:</label>
                    <select name="config" id="YandexKassaForm__config" runat="server" required>

                    </select>
                    <label for="YandexKassaForm__service">Услуга:</label>
                    <select name="service" id="YandexKassaForm__service" runat="server" required>

                    </select>
                    <label for="YandexKassaForm__another" id="YandexKassaForm__lbAnother" hidden>Введите свое наименование:</label>
                    <input type="text" name="another" placeholder="Наименование другой услуги" id="YandexKassaForm__another" hidden />
                    <label for="YandexKassaForm__name">Ваше имя:</label>
                    <input type="text" placeholder="John Doe" name="name" id="YandexKassaForm__name" required />
                    <label for="YandexKassaForm__phone">Телефон:</label>
                    <input type="text" placeholder="+7(999)999-99-99" name="phone" id="YandexKassaForm__phone" required />
                    <label for="YandexKassaForm__email">Email:</label>
                    <input type="text" placeholder="simple@mail.ru" name="email" id="YandexKassaForm__email" required />
                    <label for="YandexKassaForm__price">Сумма заказа:</label>
                    <input type="text" placeholder="0 руб." name="price" id="YandexKassaForm__price" required />
                    <label for="YandexKassaForm__promocode">Промокод:</label>
                    <input type="text" name="promocode" placeholder="Промокод вводить здесь" id="YandexKassaForm__promocode" />
                    <button>Оплатить</button>
                </form>
            </div>
        </main>
    </div>
</body>
</html>
