<?php
   $name = $_POST['name'];
   $phone = $_POST['phone'];
   $type = $_POST['type'];
   // $subject = $_POST['subject'];
   // $message =$_POST['message'];

   // $subject = "=?utf-8?B?".base64_encode("Сообщение с сайта")."?=";
   $headers = "Имя:  $name\r\nНомер Телефона: $phone\r\n Тип работы: $type\r\nContent-type: text/html; charset=utf-8\r\n";

   $success = mail("Sashaproevg@gmail.com", $subject, $message, $headers);
   
   // $success = false; //для проверки ошибки отправки сообщения
   // $success = true; //для проверки успешности отправки 
   echo $success;
?>