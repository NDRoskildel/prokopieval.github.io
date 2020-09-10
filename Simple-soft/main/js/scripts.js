$(document).ready(function(){
	$("#brif-choice-1").addClass("brif-choice-line");
	$("#brif-choice-1").click(function(){
		$("#brif-choice-1").addClass("brif-choice-line");
		$("#brif-choice-2").removeClass("brif-choice-line");
		$("#brif-choice-3").removeClass("brif-choice-line");
		$("#brif-choice-4").removeClass("brif-choice-line");
		$("#brif-form-1").show();
		$("#brif-form-2").hide();
		$("#brif-form-3").hide();
		$("#brif-form-4").hide();
	});
	$("#brif-choice-2").click(function(){
		$("#brif-choice-1").removeClass("brif-choice-line");
		$("#brif-choice-2").addClass("brif-choice-line");
		$("#brif-choice-3").removeClass("brif-choice-line");
		$("#brif-choice-4").removeClass("brif-choice-line");
		$("#brif-form-1").hide();
		$("#brif-form-2").show();
		$("#brif-form-3").hide();
		$("#brif-form-4").hide();		
	});
	$("#brif-choice-3").click(function(){
		$("#brif-choice-1").removeClass("brif-choice-line");
		$("#brif-choice-2").removeClass("brif-choice-line");
		$("#brif-choice-3").addClass("brif-choice-line");
		$("#brif-choice-4").removeClass("brif-choice-line");
		$("#brif-form-1").hide();
		$("#brif-form-2").hide();
		$("#brif-form-3").show();
		$("#brif-form-4").hide();		
	});
	$("#brif-choice-4").click(function(){
		$("#brif-choice-1").removeClass("brif-choice-line");
		$("#brif-choice-2").removeClass("brif-choice-line");
		$("#brif-choice-3").removeClass("brif-choice-line");
		$("#brif-choice-4").addClass("brif-choice-line");
		$("#brif-form-1").hide();
		$("#brif-form-2").hide();
		$("#brif-form-3").hide();
		$("#brif-form-4").show();		
	});

	 //Форма заказть звонок
    $('.section-callback-button').click(function(){
        k1 = 1;
        $('#popup-form').show();
        $(document).mouseup(function (e){
            if (!$('.popup-content').is(e.target) 
                && $('.popup-content').has(e.target).length === 0) { 
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
            var message = $("#message").val().trim();
            if(name == "") {
                $("#errorMsg").text("Введите Имя");
                return false;
            }else if(phone == "") {
                $("#errorMsg").text("Введите телефон");
                return false;
            }
            else if(phone == "") {
                $("#errorMsg").text("Введите текст сообщения");
                return false;
            }
            $("#errorMsg").text("");

            if(k1 == 1){
                $.ajax({
                    url: 'form-callback.php',
                    type: 'POST',
                    cache: false,
                    data: { 'name': name, 'phone': phone, 'message' : message},
                    dataType: 'html',
                    beforeSend: function() {
                        $("#send").prop("disabled",true);
                    },
                    success: function(data){
                        if(!data)
                            alert("При отправке сообщения возникли неполадки");
                        else{
                            $('#popup-form').hide();
                            $("#form").trigger("reset");
                        }
                        $("#send").prop("disabled",false);
                    }
                });
                k1 = 0;
            }
        });
    });
    

    $('.section-button').click(function(){
        k1 = 1;
        $('#popup-form').show();
        $(document).mouseup(function (e){
            if (!$('.popup-content').is(e.target) 
                && $('.popup-content').has(e.target).length === 0) { 
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
            var message = $("#message").val().trim();
            if(name == "") {
                $("#errorMsg").text("Введите Имя");
                return false;
            }else if(phone == "") {
                $("#errorMsg").text("Введите телефон");
                return false;
            }
            else if(phone == "") {
                $("#errorMsg").text("Введите текст сообщения");
                return false;
            }
            $("#errorMsg").text("");

            if(k1 == 1){
                $.ajax({
                    url: 'form-callback.php',
                    type: 'POST',
                    cache: false,
                    data: { 'name': name, 'phone': phone, 'message' : message},
                    dataType: 'html',
                    beforeSend: function() {
                        $("#send").prop("disabled",true);
                    },
                    success: function(data){
                        if(!data)
                            alert("При отправке сообщения возникли неполадки");
                        else{
                            $('#popup-form').hide();
                            $("#form").trigger("reset");
                        }
                        $("#send").prop("disabled",false);
                    }
                });
                k1 = 0;
            }
        });
    });

	//Форма 1
    $('#brif-1').click(function(){
    	var type = $('[name="type-1"]:checked').val().trim();
    	var time = $('[name="time-1"]:checked').val().trim();
    	var range = $('[name="range-1"]').val().trim();
    	var message = $('[name="message-1"]').val().trim();
        var name = $('[name="name-1"]').val().trim();
        var email = $('[name="email-1"]').val().trim();
        if(name == "") {
            alert("Вы забыли указать своё имя")
            return false;
        }else if(email == "") {
            $("#errorMsg").text("Вы забыли указать почту");
            return false;
        }
        $.ajax({
            url: 'form-1.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'email': email, 'type': type, 'time': time, 'range': range, 'message': message},
            dataType: 'html',
            beforeSend: function() {
                $("#brif-1").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $("#brif-form-1").trigger("reset");
                }
                $("#brif-1").prop("disabled",false);
            }
        });
    });
    //Форма 2
    $('#brif-2').click(function(){
    	var type = $('[name="type-2"]:checked').val().trim();
    	var time = $('[name="time-2"]:checked').val().trim();
    	var range = $('[name="range-2"]').val().trim();
    	var message = $('[name="message-2"]').val().trim();
        var name = $('[name="name-2"]').val().trim();
        var email = $('[name="email-2"]').val().trim();
        if(name == "") {
            alert("Вы забыли указать своё имя")
            return false;
        }else if(email == "") {
            $("#errorMsg").text("Вы забыли указать почту");
            return false;
        }
        $.ajax({
            url: 'form-2.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'email': email, 'type': type, 'time': time, 'range': range, 'message': message},
            dataType: 'html',
            beforeSend: function() {
                $("#brif-2").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $("#brif-form-2").trigger("reset");
                }
                $("#brif-2").prop("disabled",false);
            }
        });
    });

    //Форма 3
    $('#brif-3').click(function(){
    	var type = $('[name="type-3"]:checked').val().trim();
    	var time = $('[name="time-3"]:checked').val().trim();
    	var range = $('[name="range-3"]').val().trim();
    	var message = $('[name="message-3"]').val().trim();
        var name = $('[name="name-3"]').val().trim();
        var email = $('[name="email-3"]').val().trim();
        if(name == "") {
            alert("Вы забыли указать своё имя")
            return false;
        }else if(email == "") {
            $("#errorMsg").text("Вы забыли указать почту");
            return false;
        }
        $.ajax({
            url: 'form-3.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'email': email, 'type': type, 'time': time, 'range': range, 'message': message},
            dataType: 'html',
            beforeSend: function() {
                $("#brif-3").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $("#brif-form-3").trigger("reset");
                }
                $("#brif-3").prop("disabled",false);
            }
        });
    });

    //Форма 4
    $('#brif-4').click(function(){
    	var type = $('[name="type-4"]:checked').val().trim();
    	var time = $('[name="time-4"]:checked').val().trim();
    	var range = $('[name="range-4"]').val().trim();
    	var message = $('[name="message-4"]').val().trim();
        var name = $('[name="name-4"]').val().trim();
        var email = $('[name="email-4"]').val().trim();
        if(name == "") {
            alert("Вы забыли указать своё имя")
            return false;
        }else if(email == "") {
            $("#errorMsg").text("Вы забыли указать почту");
            return false;
        }
        $.ajax({
            url: 'form-4.php',
            type: 'POST',
            cache: false,
            data: { 'name': name, 'email': email, 'type': type, 'time': time, 'range': range, 'message': message},
            dataType: 'html',
            beforeSend: function() {
                $("#brif-4").prop("disabled",true);
            },
            success: function(data){
                if(!data)
                    alert("При отправке сообщения возникли неполадки");
                else{
                    $("#brif-form-4").trigger("reset");
                }
                $("#brif-4").prop("disabled",false);
            }
        });
    });

    $('.section-case-slider').slick({
	slidesToShow: 3,
	slidesToScroll: 1,
	arrows: true,
	prevArrow: $('.section-case-arrow-left'),
	nextArrow: $('.section-case-arrow-right'),
	responsive: [
			{
				breakpoint: 992,
				settings: 
				{
					slidesToShow: 1
				}
			}
		]
	});

    // -------------------------------------------------------------
    // Должно быть в самом конце иначе не работают остальные скрипты
	$(".section-case-img").fancybox({
    	openEffect	: 'none',
		closeEffect	: 'none'
    });
    // Должно быть в самом конце иначе не работают остальные скрипты
    // -------------------------------------------------------------
});