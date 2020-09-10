$(document).ready(function(){
    $("#send").on("click",function(){
        var name = $("#name").val().trim();
        var phone = $("#phone").val().trim();
        var day = $("#day").val().trim();
        var time = $("#time").val().trim();
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else 
        if(phone == "") {
            $("#errorMsg").text("Введите номер телефона");
            return false;
        }else
        if(day == "") {
            $("#errorMsg").text("Выберите день");
            return false;
        }else
        if(time == "") {
            $("#errorMsg").text("EВыберите время");
            return false;
        }



        $("#errorMsg").text("");

        $.ajax({
            url: 'ajax_form.php',
            type: 'POST',
            cache: false,
            data: {'name': name, 'phone': phone, 'day': day,'time':time },
            dataType: 'html',
            beforeSend: function() {
                $("#send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникла ошибка");
                else{
                    alert("Сообщение успешно отправлено");
                    $("#forma").trigger("reset");
                }
                $("#send").prop("disabled",false);
            }
        })
    });
});
