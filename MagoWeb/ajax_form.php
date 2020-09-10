<?php
   $name = $_POST['name'];
   $phone = $_POST['phone'];
   $day = $_POST['day'];
   $time =$_POST['time'];
   $subject = "Сообщение с сайта";

   $headers = "Имя: $name\r\nНомер: $phone\r\n-----Дата звонка-----\r\nДень: $day \r\nВремя: $time\r\nContent-type: text/html; charset=utf-8\r\n";

   $success = mail("neonilla-magija@yandex.ru", $subject, $headers);
   
   // $success = false; //для проверки ошибки отправки сообщения
   // $success = true; //для проверки успешности отправки 
   echo $success;

?>