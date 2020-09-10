$(document).ready(function(){
    var k1=0;
    var k2=0;
    var k3=0;
    var k4=0;
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
    // // Форма где задают вопросы
    // $("#form-question-send").on("click",function(){
    //     var question_subject = $("#form-question-subject").val().trim();
    //     var question_name = $("#form-question-name").val().trim();
    //     var question_phone = $("#form-question-phone").val().trim();
    //     if(question_name == "") {
    //         $("#errorMsg").text("Введите Имя");
    //         return false;
    //     }else if(question_phone == "") {
    //         $("#errorMsg").text("Ведите телефон");
    //         return false;
    //     }else if(question_subject == "") {
    //         $("#errorMsg").text("Опишите свой вопрос");
    //         return false;
    //     }
    //     $("#errorMsg").text("");

    //     $.ajax({
    //         url: 'form-questions.php',
    //         type: 'POST',
    //         cache: false,
    //         data: { 'question_subject': question_subject, 'question_name': question_name, 'question_phone': question_phone },
    //         dataType: 'html',
    //         beforeSend: function() {
    //             $("#form-question-send").prop("disabled",true);
    //         },
    //         success: function(data){
    //             if(!data)
    //                 alert("При отправке сообщения возникли неполадки");
    //             else{
    //                 $("#form-question").trigger("reset");
    //                 $('#popup-form-success').show();
    //                 $('#popup-form-success').delay(1000).fadeOut(500);
    //             }
    //             $("#form-question-send").prop("disabled",false);
    //         }
    //     })
    // });
    // // Заказать обратный звонок
    // $('.order-form').click(function(){
    //     k1 = 1;
    //     $('#popup-form').show();
    //     $(document).mouseup(function (e){
    //         if (!$('.popup-content').is(e.target) 
    //             && $('.popup-content').has(e.target).length === 0) { 
    //             $('#popup-form').hide();
    //         }
    //     });
    //     $('#send').click(function(){
    //         var name = $("#name").val().trim();
    //         var phone = $("#phone").val().trim();
    //         if(name == "") {
    //             $("#errorMsg").text("Введите Имя");
    //             return false;
    //         }else if(phone == "") {
    //             $("#errorMsg").text("Введите телефон");
    //             return false;
    //         }
    //         $("#errorMsg").text("");
    //         if( k1 == 1){
    //             $.ajax({
    //                 url: 'form-callback.php',
    //                 type: 'POST',
    //                 cache: false,
    //                 data: { 'name': name, 'phone': phone },
    //                 dataType: 'html',
    //                 beforeSend: function() {
    //                     $("#send").prop("disabled",true);
    //                 },
    //                 success: function(data){
    //                     if(!data)
    //                         alert("При отправке сообщения возникли неполадки");
    //                     else{
    //                         $('#popup-form').hide();
    //                         $('#popup-form-success').show();
    //                         $("#form").trigger("reset");
    //                         $('#popup-form-success').delay(1000).fadeOut(500);
    //                     }
    //                     $("#send").prop("disabled",false);
    //                 }
    //             });
    //             k1 = 0;
    //         }  
    //     });
    // });
  
    //Форма заказть звонок 1
    $('#header-button').click(function(){
        k3 = 1;
        $('#popup-form').show();
        $(document).mouseup(function (e){
            if (!$('.popup-container').is(e.target) 
                && $('.popup-container').has(e.target).length === 0) { 
                $('#popup-form').hide();
                k3 = 0;
            }
        });
        $('#popup-close-form').click(function(){
            $('#popup-form').hide();
            k3 = 0;
        });
        $('#send').click(function(){
            var name = $("#name").val().trim();
            var phone = $("#phone").val().trim();
            if(name == "") {
                $("#errorMsg").text("Введите Имя");
                return false;
            }else if(phone == "") {
                $("#errorMsg").text("Введите телефон");
                return false;
            }
            $("#errorMsg").text("");

            if(k3 == 1){
                $.ajax({
                    url: 'form-callback.php',
                    type: 'POST',
                    cache: false,
                    data: { 'name': name, 'phone': phone},
                    dataType: 'html',
                    beforeSend: function() {
                        $("#send").prop("disabled",true);
                    },
                    success: function(data){
                        if(!data)
                            alert("При отправке сообщения возникли неполадки");
                        else{
                            $('#popup-form').hide();
                            $('#popup-good').show();
                            $("#form").trigger("reset");
                            $(document).mouseup(function (e){
                                if (!$('.popup-container').is(e.target) 
                                    && $('.popup-container').has(e.target).length === 0) { 
                                    $('#popup-good').hide();
                                    k3 = 0;
                                }
                            });
                            $('#popup-close-success').click(function(){
                                $('#popup-good').hide();
                                k3 = 0;
                            });
                        }
                        $("#send").prop("disabled",false);
                    }
                });
                k3 = 0;
            }
        });
    });

    //Форма заказть звонок 2
    $('#main-button-desc').click(function(){
        k2 = 1;
        $('#popup-form').show();
        $(document).mouseup(function (e){
            if (!$('.popup-container').is(e.target) 
                && $('.popup-container').has(e.target).length === 0) { 
                $('#popup-form').hide();
                k2 = 0;
            }
        });
        $('#popup-close-form').click(function(){
            $('#popup-form').hide();
            k2 = 0;
        });
        $('#send').click(function(){
            var name = $("#name").val().trim();
            var phone = $("#phone").val().trim();
            if(name == "") {
                $("#errorMsg").text("Введите Имя");
                return false;
            }else if(phone == "") {
                $("#errorMsg").text("Введите телефон");
                return false;
            }
            $("#errorMsg").text("");
            
            if(k2 == 1){
                $.ajax({
                    url: 'form-callback.php',
                    type: 'POST',
                    cache: false,
                    data: { 'name': name, 'phone': phone},
                    dataType: 'html',
                    beforeSend: function() {
                        $("#send").prop("disabled",true);
                    },
                    success: function(data){
                        if(!data)
                            alert("При отправке сообщения возникли неполадки");
                        else{
                            $('#popup-form').hide();
                            $('#popup-good').show();
                            $("#form").trigger("reset");
                            $(document).mouseup(function (e){
                                if (!$('.popup-container').is(e.target) 
                                    && $('.popup-container').has(e.target).length === 0) { 
                                    $('#popup-good').hide();
                                    k2 = 0;
                                }
                            });
                            $('#popup-close-success').click(function(){
                                $('#popup-good').hide();
                                k2 = 0;
                            });
                        }
                        $("#send").prop("disabled",false);
                    }
                });
                k2 = 0;
            }
        });
    });


    //Форма заказть звонок 3
    $('#main-button-mob').click(function(){
        k1 = 1;
        $('#popup-form').show();
        $(document).mouseup(function (e){
            if (!$('.popup-container').is(e.target) 
                && $('.popup-container').has(e.target).length === 0) { 
                $('#popup-form').hide();
                k1 = 0;
            }
        });
        $('#popup-close-form').click(function(){
            $('#popup-form').hide();
            k1 = 0;
        });
        $('#send').click(function(){
            var name = $("#name").val().trim();
            var phone = $("#phone").val().trim();
            if(name == "") {
                $("#errorMsg").text("Введите Имя");
                return false;
            }else if(phone == "") {
                $("#errorMsg").text("Введите телефон");
                return false;
            }
            $("#errorMsg").text("");
            
            if(k1 == 1){
                $.ajax({
                    url: 'form-callback.php',
                    type: 'POST',
                    cache: false,
                    data: { 'name': name, 'phone': phone},
                    dataType: 'html',
                    beforeSend: function() {
                        $("#send").prop("disabled",true);
                    },
                    success: function(data){
                        if(!data)
                            alert("При отправке сообщения возникли неполадки");
                        else{
                            $('#popup-form').hide();
                            $('#popup-good').show();
                            $("#form").trigger("reset");
                            $(document).mouseup(function (e){
                                if (!$('.popup-container').is(e.target) 
                                    && $('.popup-container').has(e.target).length === 0) { 
                                    $('#popup-good').hide();
                                    k1 = 0;
                                }
                            });
                            $('#popup-close-success').click(function(){
                                $('#popup-good').hide();
                                k1 = 0;
                            });
                        }
                        $("#send").prop("disabled",false);
                    }
                });
                k1 = 0;
            }
        });
    });

    //Форма заказть звонок 4
    $('#contacts-button').click(function(){
        k4 = 1;
        $('#popup-form').show();
        $(document).mouseup(function (e){
            if (!$('.popup-container').is(e.target) 
                && $('.popup-container').has(e.target).length === 0) { 
                $('#popup-form').hide();
                k4 = 0;
            }
        });
        $('#popup-close-form').click(function(){
            $('#popup-form').hide();
            k4 = 0;
        });
        $('#send').click(function(){
            var name = $("#name").val().trim();
            var phone = $("#phone").val().trim();
            if(name == "") {
                $("#errorMsg").text("Введите Имя");
                return false;
            }else if(phone == "") {
                $("#errorMsg").text("Введите телефон");
                return false;
            }
            $("#errorMsg").text("");
            
            if(k4 == 1){
                $.ajax({
                    url: 'form-callback.php',
                    type: 'POST',
                    cache: false,
                    data: { 'name': name, 'phone': phone},
                    dataType: 'html',
                    beforeSend: function() {
                        $("#send").prop("disabled",true);
                    },
                    success: function(data){
                        if(!data)
                            alert("При отправке сообщения возникли неполадки");
                        else{
                            $('#popup-form').hide();
                            $('#popup-good').show();
                            $("#form").trigger("reset");
                            $(document).mouseup(function (e){
                                if (!$('.popup-container').is(e.target) 
                                    && $('.popup-container').has(e.target).length === 0) { 
                                    $('#popup-good').hide();
                                    k4 = 0;
                                }
                            });
                            $('#popup-close-success').click(function(){
                                $('#popup-good').hide();
                                k4 = 0;
                            });
                        }
                        $("#send").prop("disabled",false);
                    }
                });
                k4 = 0;
            }
        });
    });


     //Форма заказть звонок вопрос
    $('#send-question').click(function(){
        var name = $("#question-name").val().trim();
        var phone = $("#question-phone").val().trim();
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
            data: { 'name': name, 'phone': phone},
            dataType: 'html',
            beforeSend: function() {
                $("#send-question").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $('#popup-good').show();
                    $("#form-questions").trigger("reset");
                    $(document).mouseup(function (e){
                        if (!$('.popup-container').is(e.target) 
                            && $('.popup-container').has(e.target).length === 0) { 
                            $('#popup-good').hide();
                        }
                    });
                    $('#popup-close-success').click(function(){
                        $('#popup-good').hide();
                    });
                }
                $("send-question").prop("disabled",false);
            }
        });
    });

});