<?php
   $name = $_POST['name'];
   $phone = $_POST['phone'];
   $form_delivery_adress = $_POST['form_delivery_adress'];
   $form_delivery_select = $_POST['form_delivery_select'];
   $form_delivery_size = $_POST['form_delivery_size'];
   $dostavka = $_POST['dostavka'];
   // $message =$_POST['message'];

   // $subject = "=?utf-8?B?".base64_encode("Сообщение с сайта")."?=";
   $headers = "Имя:  $name\r\nНомер Телефона: $phone\r\nАдрес доставки:\r\n$form_delivery_adress\r\nТип грунта: $form_delivery_select\r\nОбъем: $form_delivery_size\r\nСпособ доставки: $dostavka\r\nContent-type: text/html; charset=utf-8\r\n";
   $success = mail("Sashaproevg@gmail.com", $subject, $message, $headers);
   
   // $success = false; //для проверки ошибки отправки сообщения
   // $success = true; //для проверки успешности отправки 
   echo $success;
?>