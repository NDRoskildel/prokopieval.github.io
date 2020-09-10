<?php
   $name = $_POST['name'];
   $type = $_POST['type'];
   $time =$_POST['time'];
   $range = $_POST['range'];
   $email = $_POST['email'];
   $message =$_POST['message'];

   // $subject = "=?utf-8?B?".base64_encode("Сообщение с сайта")."?=";
   $headers = "Имя:  $name\r\nE-mail: $email\r\n Тип: $type  \r\nСроки: $time\r\nСтоимость: $range \r\nДополнительная информация: $message \r\n Content-type: text/html; charset=utf-8\r\n";

   $success = mail("rb-100@outlook.com", $subject, $headers);
   
   // $success = false; //для проверки ошибки отправки сообщения
   // $success = true; //для проверки успешности отправки 
   echo $success;
?>