<?php
   $free_select = $_POST['free_select'];
   $free_name = $_POST['free_name'];
   $free_phone = $_POST['free_phone'];
   // $subject = $_POST['subject'];
   // $message =$_POST['message'];

   // $subject = "=?utf-8?B?".base64_encode("Сообщение с сайта")."?=";
   $headers = "Имя:  $free_name\r\nНомер Телефона: $free_phone\r\n Выбранный грунт:  $free_select\r\nContent-type: text/html; charset=utf-8\r\n";

   $success = mail("Sashaproevg@gmail.com", $subject, $message, $headers, $phone);
   
   // $success = false; //для проверки ошибки отправки сообщения
   // $success = true; //для проверки успешности отправки 
   echo $success;
?>