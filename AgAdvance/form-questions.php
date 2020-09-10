<?php
   $question_subject = $_POST['question_subject'];
   $question_name = $_POST['question_name'];
   $question_phone = $_POST['question_phone'];
   // $subject = $_POST['subject'];
   // $message =$_POST['message'];

   // $subject = "=?utf-8?B?".base64_encode("Сообщение с сайта")."?=";
   $headers = "Имя:  $question_name\r\nНомер Телефона: $question_phone\r\n Вопрос:  $question_subject\r\nContent-type: text/html; charset=utf-8\r\n";

   $success = mail("Sashaproevg@gmail.com", $subject, $message, $headers);
   
   // $success = false; //для проверки ошибки отправки сообщения
   // $success = true; //для проверки успешности отправки 
   echo $success;
?>