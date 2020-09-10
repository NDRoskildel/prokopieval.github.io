<?php
   $name = $_POST['name'];
   $phone = $_POST['phone'];
   $recipe_choice_chernozem = $_POST['recipe_choice_chernozem'];
   $recipe_choice_pesok = $_POST['recipe_choice_pesok'];
   $recipe_choice_grunt = $_POST['recipe_choice_grunt'];
   $recipe_choice_torf = $_POST['recipe_choice_torf'];
   $okatish = $_POST['okatish'];
   $opilki = $_POST['opilki'];
   $campost = $_POST['campost'];
   // $message =$_POST['message'];

   // $subject = "=?utf-8?B?".base64_encode("Сообщение с сайта")."?=";
   $headers = "Имя:  $name\r\nНомер Телефона: $phone\r\nСостав грунта:\r\nЧернозём: $recipe_choice_chernozem 0 %\r\nПесок: $recipe_choice_pesok 0 %\r\nГрунт: $recipe_choice_grunt 0 %\r\nТорф: $recipe_choice_torf 0 %\r\nДобавки:\r\n$okatish , $opilki ,  $campost \r\nContent-type: text/html; charset=utf-8\r\n";
   $success = mail("Sashaproevg@gmail.com", $subject, $message, $headers);
   
   // $success = false; //для проверки ошибки отправки сообщения
   // $success = true; //для проверки успешности отправки 
   echo $success;
?>