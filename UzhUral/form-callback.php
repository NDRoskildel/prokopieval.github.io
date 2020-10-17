<?php
   $name = $_POST['name'];
   $phone = $_POST['phone'];
   // $subject = $_POST['subject'];
   // $message =$_POST['message'];

   // $subject = "=?utf-8?B?".base64_encode("Сообщение с сайта")."?=";
   $headers = "Имя:  $name\r\nНомер Телефона: $phone\r\n Content-type: text/html; charset=utf-8\r\n";

   $success = mail("rb-100@outlook.com", $subject, $message, $headers);
   
   // $success = false; //для проверки ошибки отправки сообщения
   $success = true; //для проверки успешности отправки 
   echo $success;
?>