$(document).ready(function(){
    var k1=0;
    var k2=0;
    var k3=0;
    var k4=0;
    // Форма бесплатного пробного грунта
    $("#form-free-send").on("click",function(){
        var free_select = $("#form-free-select").val().trim();
        var free_name = $("#form-free-name").val().trim();
        var free_phone = $("#form-free-phone").val().trim();
        if(free_name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(free_phone == "") {
            $("#errorMsg").text("Ведите телефон");
            return false;
        }
        $("#errorMsg").text("");

        $.ajax({
            url: 'form-free.php',
            type: 'POST',
            cache: false,
            data: { 'free_select': free_select, 'free_name': free_name, 'free_phone': free_phone },
            dataType: 'html',
            beforeSend: function() {
                $("#form-free-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    // alert("Message sent successfully");
                    $("#form-free").trigger("reset");
                    $('#popup-form-success').show();
                    $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#form-free-send").prop("disabled",false);
            }
        })
    });
    // Форма где задают вопросы
    $("#form-question-send").on("click",function(){
        var question_subject = $("#form-question-subject").val().trim();
        var question_name = $("#form-question-name").val().trim();
        var question_phone = $("#form-question-phone").val().trim();
        if(question_name == "") {
            $("#errorMsg").text("Введите Имя");
            return false;
        }else if(question_phone == "") {
            $("#errorMsg").text("Ведите телефон");
            return false;
        }else if(question_subject == "") {
            $("#errorMsg").text("Опишите свой вопрос");
            return false;
        }
        $("#errorMsg").text("");

        $.ajax({
            url: 'form-questions.php',
            type: 'POST',
            cache: false,
            data: { 'question_subject': question_subject, 'question_name': question_name, 'question_phone': question_phone },
            dataType: 'html',
            beforeSend: function() {
                $("#form-question-send").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $("#form-question").trigger("reset");
                    $('#popup-form-success').show();
                    $('#popup-form-success').delay(1000).fadeOut(500);
                }
                $("#form-question-send").prop("disabled",false);
            }
        })
    });
    // Заказать обратный звонок
    $('.order-form').click(function(){
        k1 = 1;
        $('#popup-form').show();
        $(document).mouseup(function (e){
            if (!$('.popup-content').is(e.target) 
                && $('.popup-content').has(e.target).length === 0) { 
                $('#popup-form').hide();
            }
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
            if( k1 == 1){
                $.ajax({
                    url: 'form-callback.php',
                    type: 'POST',
                    cache: false,
                    data: { 'name': name, 'phone': phone },
                    dataType: 'html',
                    beforeSend: function() {
                        $("#send").prop("disabled",true);
                    },
                    success: function(data){
                        if(!data)
                            alert("При отправке сообщения возникли неполадки");
                        else{
                            $('#popup-form').hide();
                            $('#popup-form-success').show();
                            $("#form").trigger("reset");
                            $('#popup-form-success').delay(1000).fadeOut(500);
                        }
                        $("#send").prop("disabled",false);
                    }
                });
                k1 = 0;
            }  
        });
    });
    //форма с рецептурой
    $('#recept').click(function(){
        var name = $('#recipe-name').val().trim();
        var phone = $('#recipe-phone').val().trim();

        if((name == "")||(phone == "")){
            k2 = 1;
            $('#popup-form').show();
            $(document).mouseup(function (e){
                if (!$('.popup-container').is(e.target) 
                    && $('.popup-container').has(e.target).length === 0) { 
                    $('#popup-form').hide();
                }
            });
            $('#send').click(function(){
                name = $("#name").val().trim();
                phone = $("#phone").val().trim();
                var recipe_choice_chernozem = $("#recipe-choice-chernozem").val().trim();
                var recipe_choice_pesok = $("#recipe-choice-pesok").val().trim();
                var recipe_choice_grunt = $("#recipe-choice-grunt").val().trim();
                var recipe_choice_torf = $("#recipe-choice-torf").val().trim();

                var okatish = "";
                var opilki = "";
                var campost = "";
                if( $("#radio-1").is(':checked')){
                    okatish="С окатышем";
                }else{
                    okatish="Без окатыша";
                }
                if( $("#radio-2").is(':checked')){
                    opilki ="С опилками";
                }else{
                    opilki="Без опилок";
                }
                if( $("#radio-3").is(':checked')){
                    campost="С кампостом";
                }else{
                    campost="Без кампоста";
                }

                if(name == "") {
                    $("#errorMsg").text("Введите Имя");
                    return false;
                }else if(phone == "") {
                    $("#errorMsg").text("Введите телефон");
                    return false;
                }
                $("#errorMsg").text("");

                if( k2 == 1){
                    $.ajax({
                        url: 'form-recipe.php',
                        type: 'POST',
                        cache: false,
                        data: { 'name': name, 'phone': phone, 'recipe_choice_chernozem': recipe_choice_chernozem,
                         'recipe_choice_pesok': recipe_choice_pesok, 'recipe_choice_grunt': recipe_choice_grunt,
                        'recipe_choice_torf': recipe_choice_torf, 'okatish': okatish, 'opilki': opilki, 'campost':campost
                        },
                        dataType: 'html',
                        beforeSend: function() {
                            $("#send").prop("disabled",true);
                        },
                        success: function(data){
                            if(!data)
                                alert("При отправке сообщения возникли неполадки");
                            else{
                                $('#popup-form').hide();
                                $('#popup-form-success').show();
                                $("#form").trigger("reset");
                                $('#popup-form-success').delay(1000).fadeOut(500);
                            }
                            $("#send").prop("disabled",false);
                        }
                    });
                    k2 = 0;
                }
            });
        }else{
            k4 = 1;
            var recipe_choice_chernozem = $("#recipe-choice-chernozem").val().trim();
            var recipe_choice_pesok = $("#recipe-choice-pesok").val().trim();
            var recipe_choice_grunt = $("#recipe-choice-grunt").val().trim();
            var recipe_choice_torf = $("#recipe-choice-torf").val().trim();

            var okatish = "";
            var opilki = "";
            var campost = "";
            if( $("#radio-1").is(':checked')){
                okatish="С окатышем";
            }else{
                okatish="Без окатыша";
            }
            if( $("#radio-2").is(':checked')){
                opilki ="С опилками";
            }else{
                opilki="Без опилок";
            }
            if( $("#radio-3").is(':checked')){
                campost="С кампостом";
            }else{
                campost="Без кампоста";
            }

            if(name == "") {
                $("#errorMsg").text("Введите Имя");
                return false;
            }else if(phone == "") {
                $("#errorMsg").text("Введите телефон");
                return false;
            }
            $("#errorMsg").text("");

            if( k4 == 1){
                $.ajax({
                    url: 'form-recipe.php',
                    type: 'POST',
                    cache: false,
                    data: { 'name': name, 'phone': phone, 'recipe_choice_chernozem': recipe_choice_chernozem,
                     'recipe_choice_pesok': recipe_choice_pesok, 'recipe_choice_grunt': recipe_choice_grunt,
                    'recipe_choice_torf': recipe_choice_torf, 'okatish': okatish, 'opilki': opilki, 'campost':campost
                    },
                    dataType: 'html',
                    beforeSend: function() {
                        $("#send").prop("disabled",true);
                    },
                    success: function(data){
                        if(!data)
                            alert("При отправке сообщения возникли неполадки");
                        else{
                            $('#popup-form').hide();
                            $('#popup-form-success').show();
                            $("#form").trigger("reset");
                            $("#recipe-name").val("");
                            $("#recipe-phone").val("");
                            $('#popup-form-success').delay(1000).fadeOut(500);
                        }
                        $("#send").prop("disabled",false);
                    }
                });
                k4 = 0;
            }
        }      
    });
    //Форма с доставкой
    $('#delivery-send').click(function(){
        k3 = 1;
        $('#popup-form').show();
        $(document).mouseup(function (e){
            if (!$('.popup-container').is(e.target) 
                && $('.popup-container').has(e.target).length === 0) { 
                $('#popup-form').hide();
            }
        });
        $('#send').click(function(){
            var name = $("#name").val().trim();
            var phone = $("#phone").val().trim();
            var form_delivery_adress = $("#form-delivery-adress").val().trim();
            var form_delivery_select = $("#form-delivery-select").val().trim();
            var form_delivery_size = $("#form-delivery-size").val().trim();

            var dostavka = "";
            if( $("#cost-1").is(':checked')){
                dostavka="Самосвал";
            }else{
                dostavka="Тонар";
            };
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
                    url: 'form-delivery.php',
                    type: 'POST',
                    cache: false,
                    data: { 'name': name, 'phone': phone, 'form_delivery_adress': form_delivery_adress,
                    'form_delivery_select': form_delivery_select, 'form_delivery_size': form_delivery_size,
                    'dostavka': dostavka
                    },
                    dataType: 'html',
                    beforeSend: function() {
                        $("#send").prop("disabled",true);
                    },
                    success: function(data){
                        if(!data)
                            alert("При отправке сообщения возникли неполадки");
                        else{
                            $('#popup-form').hide();
                            $('#popup-form-success').show();
                            $("#form").trigger("reset");
                            $('#popup-form-success').delay(1000).fadeOut(500);
                        }
                        $("#send").prop("disabled",false);
                    }
                });
                k3 = 0;
            }
        });
    });

});