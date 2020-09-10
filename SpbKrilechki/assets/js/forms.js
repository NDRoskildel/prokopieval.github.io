$(document).ready(function(){
    // Форма бесплатного пробного грунта
    // $("#form-free-send").on("click",function(){
    //     var free_select = $("#form-free-select").val().trim();
    //     var free_name = $("#form-free-name").val().trim();
    //     var free_phone = $("#form-free-phone").val().trim();
    //     if(free_name == "") {
    //         $("#errorMsg").text("Введите Имя");
    //         return false;
    //     }else if(free_phone == "") {
    //         $("#errorMsg").text("Ведите телефон");
    //         return false;
    //     }
    //     $("#errorMsg").text("");

    //     $.ajax({
    //         url: 'form-free.php',
    //         type: 'POST',
    //         cache: false,
    //         data: { 'free_select': free_select, 'free_name': free_name, 'free_phone': free_phone },
    //         dataType: 'html',
    //         beforeSend: function() {
    //             $("#form-free-send").prop("disabled",true);
    //         },
    //         success: function(data){
    //             if(!data)
    //                 alert("При отправке сообщения возникли неполадки");
    //             else{
    //                 // alert("Message sent successfully");
    //                 $("#form-free").trigger("reset");
    //                 $('#popup-form-success').show();
    //                 $('#popup-form-success').delay(1000).fadeOut(500);
    //             }
    //             $("#form-free-send").prop("disabled",false);
    //         }
    //     })
    // });
 

    // Заказать обратный звонок
    $('#main-send').click(function(){
        var name = $("#main-name").val().trim();
        var phone = $("#main-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#main-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-good').show();
                    $('#main-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#main-send").prop("disabled",false);
            }
        });
    });

    // Заказать обратный звонок
    $('#map-send').click(function(){
        var name = $("#map-name").val().trim();
        var phone = $("#map-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#map-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-good').show();
                    $('#map-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#map-send").prop("disabled",false);
            }
        });
    });

    // Заказать обратный звонок
    $('#popup-1-send').click(function(){
        var name = $("#popup-1-name").val().trim();
        var phone = $("#popup-1-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#popup-1-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-1').hide();
                    $('#popup-good').show();
                    $('#popup-1-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#popup-1-send").prop("disabled",false);
            }
        });
    });

    // Заказать обратный звонок
    $('#popup-2-send').click(function(){
        var name = $("#popup-2-name").val().trim();
        var phone = $("#popup-2-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#popup-2-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-2').hide();
                    $('#popup-good').show();
                    $('#popup-2-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#popup-2-send").prop("disabled",false);
            }
        });
    });

    // Заказать обратный звонок
    $('#popup-3-send').click(function(){
        var name = $("#popup-3-name").val().trim();
        var phone = $("#popup-3-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#popup-3-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-3').hide();
                    $('#popup-good').show();
                    $('#popup-3-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#popup-3-send").prop("disabled",false);
            }
        });
    });

    // Заказать обратный звонок
    $('#popup-4-send').click(function(){
        var name = $("#popup-4-name").val().trim();
        var phone = $("#popup-4-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#popup-4-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-4').hide();
                    $('#popup-good').show();
                    $('#popup-4-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#popup-4-send").prop("disabled",false);
            }
        });
    });

    // Заказать обратный звонок
    $('#popup-5-send').click(function(){
        var name = $("#popup-5-name").val().trim();
        var phone = $("#popup-5-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#popup-5-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-5').hide();
                    $('#popup-good').show();
                    $('#popup-5-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#popup-5-send").prop("disabled",false);
            }
        });
    });

    // Заказать обратный звонок
    $('#popup-6-send').click(function(){
        var name = $("#popup-6-name").val().trim();
        var phone = $("#popup-6-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#popup-6-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-6').hide();
                    $('#popup-good').show();
                    $('#popup-6-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#popup-6-send").prop("disabled",false);
            }
        });
    });

    // Заказать обратный звонок
    $('#popup-7-send').click(function(){
        var name = $("#popup-7-name").val().trim();
        var phone = $("#popup-7-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#popup-7-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-7').hide();
                    $('#popup-good').show();
                    $('#popup-7-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#popup-7-send").prop("disabled",false);
            }
        });
    });
    // Заказать обратный звонок
    $('#popup-8-send').click(function(){
        var name = $("#popup-8-name").val().trim();
        var phone = $("#popup-8-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#popup-8-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-8').hide();
                    $('#popup-good').show();
                    $('#popup-8-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#popup-8-send").prop("disabled",false);
            }
        });
    });
    // Заказать обратный звонок
    $('#popup-9-send').click(function(){
        var name = $("#popup-9-name").val().trim();
        var phone = $("#popup-9-tel").val().trim();
        var type = "";
        if(name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(phone == "") {
            $("#errorMsg").text("Введите телефон");
            return false;
        }
        $("#errorMsg").text("");
        $.ajax({
            url: 'form-callback.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'phone': phone, 'type': type },
            dataType: 'html',
            beforeSend: function() {
                $("#popup-9-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-9').hide();
                    $('#popup-good').show();
                    $('#popup-9-form').trigger("reset");
                    $('#goback').click(function(){
                        $('#popup-good').hide();
                    });
                    // $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#popup-9-send").prop("disabled",false);
            }
        });
    });










});

