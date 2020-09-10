$(document).ready( function() {
    $(".header-catalog-show").click(function(){
        $(".header-catalog-show").hide();
        $(".header-catalog").css({'display':'flex'});
        $(".header-contacts a").css({'color':'#ffffff'});
    });
    $(".header-catalog-hide").click(function(){
        $(".header-catalog-show").show();
        $(".header-catalog").hide();
        $(".header-contacts a").css({'color':'#000000'});
    });
    var k=0;
    $('#mobile-header-burger').click(function(){
        if(k==0){
            $('.mobile-header-hiden').show();
            k=1;
        }
        else{
            $('.mobile-header-hiden').hide();
            k=0;
        }
    });
    $('.mobile-header-nav-items>li>a').click(function(){
        $('.mobile-header-hiden').hide();
        k=0;
    });

    $('.order-form').click(function(){
        $('.mobile-header-hiden').hide();
        k=0;
    });

    //Установка значений по умолчанию занчений в рецептуре
    // $('#recipe-range-chernozem').val($('#recipe-choice-chernozem').val());
    // $('#recipe-range-pesok').val($('#recipe-choice-pesok').val());
    // $('#recipe-range-grunt').val($('#recipe-choice-grunt').val());
    // $('#recipe-range-torf').val($('#recipe-choice-torf').val());
    // $('#recipe-value-chernozem').text( $('#recipe-range-chernozem').val()+'%');
    // $('#recipe-value-pesok').text( $('#recipe-range-pesok').val()+'%');
    // $('#recipe-value-grunt').text( $('#recipe-range-grunt').val()+'%');
    // $('#recipe-value-torf').text( $('#recipe-range-torf').val()+'%');
    // $('.recipe-order-img').html('<img src="assets/img/recipe-1_1.png">');

    // $('#recipe-choice-chernozem').change(function(){
    //     $('#recipe-range-chernozem').val($('#recipe-choice-chernozem').val());
    //     sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
    //     if(sum > 10){
    //         alert('Значение не может быть больше 100%');
    //         $('#recipe-range-chernozem').val("0");
    //         $('#recipe-choice-chernozem').val("0");
    //     }
    //     if($('#recipe-range-chernozem').val() == 0){
    //         $('#recipe-value-chernozem').text( $('#recipe-range-chernozem').val()+'%');
    //     }else{
    //         $('#recipe-value-chernozem').text( $('#recipe-range-chernozem').val()+'0%');
    //     }
    //     var a = parseInt($('#recipe-choice-chernozem').val());
    //     var b = parseInt($('#recipe-choice-pesok').val());
    //     var c = parseInt($('#recipe-choice-grunt').val());
    //     var d = parseInt($('#recipe-choice-torf').val());
    //     if( (a>=b) && (a>=c) && (a>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
    //     }
    //     if( (b>=a) && (b>=c) && (b>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
    //     }
    //     if( (c>=a) && (c>=b) && (c>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
    //     }
    //     if( (d>=a) && (d>=b) && (d>=c) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
    //     }
    // });
    // $('#recipe-range-chernozem').change(function(){
    //     $('#recipe-choice-chernozem').val($('#recipe-range-chernozem').val());
    //     sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
    //     if(sum > 10){
    //         alert('Значение не может быть больше 100%');
    //         $('#recipe-range-chernozem').val("0");
    //         $('#recipe-choice-chernozem').val("0");
    //     }
    //     if($('#recipe-range-chernozem').val() == 0){
    //         $('#recipe-value-chernozem').text( $('#recipe-range-chernozem').val()+'%');
    //     }else{
    //         $('#recipe-value-chernozem').text( $('#recipe-range-chernozem').val()+'0%');
    //     }
    //     var a = parseInt($('#recipe-choice-chernozem').val());
    //     var b = parseInt($('#recipe-choice-pesok').val());
    //     var c = parseInt($('#recipe-choice-grunt').val());
    //     var d = parseInt($('#recipe-choice-torf').val());
    //     if( (a>=b) && (a>=c) && (a>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
    //     }
    //     if( (b>=a) && (b>=c) && (b>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
    //     }
    //     if( (c>=a) && (c>=b) && (c>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
    //     }
    //     if( (d>=a) && (d>=b) && (d>=c) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
    //     }
    // });
    // $('#recipe-choice-pesok').change(function(){
    //     $('#recipe-range-pesok').val($('#recipe-choice-pesok').val());
    //     sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
    //     if(sum > 10){
    //         alert('Значение не может быть больше 100%');
    //         $('#recipe-range-pesok').val("0");
    //         $('#recipe-choice-pesok').val("0");
    //     }
    //     if($('#recipe-range-pesok').val() == 0){
    //         $('#recipe-value-pesok').text( $('#recipe-range-pesok').val()+'%');
    //     }else{
    //         $('#recipe-value-pesok').text( $('#recipe-range-pesok').val()+'0%');
    //     }
    //     var a = parseInt($('#recipe-choice-chernozem').val());
    //     var b = parseInt($('#recipe-choice-pesok').val());
    //     var c = parseInt($('#recipe-choice-grunt').val());
    //     var d = parseInt($('#recipe-choice-torf').val());
    //     if( (a>=b) && (a>=c) && (a>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
    //     }
    //     if( (b>=a) && (b>=c) && (b>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
    //     }
    //     if( (c>=a) && (c>=b) && (c>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
    //     }
    //     if( (d>=a) && (d>=b) && (d>=c) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
    //     }
    // });
    // $('#recipe-range-pesok').change(function(){
    //     $('#recipe-choice-pesok').val($('#recipe-range-pesok').val());
    //     sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
    //     if(sum > 10){
    //         alert('Значение не может быть больше 100%');
    //         $('#recipe-range-pesok').val("0");
    //         $('#recipe-choice-pesok').val("0");
    //     }
    //     if($('#recipe-range-pesok').val() == 0){
    //         $('#recipe-value-pesok').text( $('#recipe-range-pesok').val()+'%');
    //     }else{
    //         $('#recipe-value-pesok').text( $('#recipe-range-pesok').val()+'0%');
    //     }
    //     var a = parseInt($('#recipe-choice-chernozem').val());
    //     var b = parseInt($('#recipe-choice-pesok').val());
    //     var c = parseInt($('#recipe-choice-grunt').val());
    //     var d = parseInt($('#recipe-choice-torf').val());
    //     if( (a>=b) && (a>=c) && (a>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
    //     }
    //     if( (b>=a) && (b>=c) && (b>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
    //     }
    //     if( (c>=a) && (c>=b) && (c>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
    //     }
    //     if( (d>=a) && (d>=b) && (d>=c) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
    //     }
    // });
    // $('#recipe-choice-grunt').change(function(){
    //     $('#recipe-range-grunt').val($('#recipe-choice-grunt').val());
    //     sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
    //     if(sum > 10){
    //         alert('Значение не может быть больше 100%');
    //         $('#recipe-range-grunt').val("0");
    //         $('#recipe-choice-grunt').val("0");
    //     }
    //     if($('#recipe-range-grunt').val() == 0){
    //         $('#recipe-value-grunt').text( $('#recipe-range-grunt').val()+'%');
    //     }else{
    //         $('#recipe-value-grunt').text( $('#recipe-range-grunt').val()+'0%');
    //     }
    //     var a = parseInt($('#recipe-choice-chernozem').val());
    //     var b = parseInt($('#recipe-choice-pesok').val());
    //     var c = parseInt($('#recipe-choice-grunt').val());
    //     var d = parseInt($('#recipe-choice-torf').val());
    //     if( (a>=b) && (a>=c) && (a>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
    //     }
    //     if( (b>=a) && (b>=c) && (b>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
    //     }
    //     if( (c>=a) && (c>=b) && (c>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
    //     }
    //     if( (d>=a) && (d>=b) && (d>=c) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
    //     }
    // });
    // $('#recipe-range-grunt').change(function(){
    //     //alert($('#recipe-range-chernozem').val());
    //     $('#recipe-choice-grunt').val($('#recipe-range-grunt').val());
    //     sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
    //     if(sum > 10){
    //         alert('Значение не может быть больше 100%');
    //         $('#recipe-range-grunt').val("0");
    //         $('#recipe-choice-grunt').val("0");
    //     }
    //     if($('#recipe-range-grunt').val() == 0){
    //         $('#recipe-value-grunt').text( $('#recipe-range-grunt').val()+'%');
    //     }else{
    //         $('#recipe-value-grunt').text( $('#recipe-range-grunt').val()+'0%');
    //     }
    //     var a = parseInt($('#recipe-choice-chernozem').val());
    //     var b = parseInt($('#recipe-choice-pesok').val());
    //     var c = parseInt($('#recipe-choice-grunt').val());
    //     var d = parseInt($('#recipe-choice-torf').val());
    //     if( (a>=b) && (a>=c) && (a>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
    //     }
    //     if( (b>=a) && (b>=c) && (b>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
    //     }
    //     if( (c>=a) && (c>=b) && (c>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
    //     }
    //     if( (d>=a) && (d>=b) && (d>=c) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
    //     }
    // });
    // $('#recipe-choice-torf').change(function(){
    //     $('#recipe-range-torf').val($('#recipe-choice-torf').val());
    //     sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
    //     if(sum > 10){
    //         alert('Значение не может быть больше 100%');
    //         $('#recipe-range-torf').val("0");
    //         $('#recipe-choice-torf').val("0");
    //     }
    //     if($('#recipe-range-torf').val() == 0){
    //         $('#recipe-value-torf').text( $('#recipe-range-torf').val()+'%');
    //     }else{
    //         $('#recipe-value-torf').text( $('#recipe-range-torf').val()+'0%');
    //     }
    //     var a = parseInt($('#recipe-choice-chernozem').val());
    //     var b = parseInt($('#recipe-choice-pesok').val());
    //     var c = parseInt($('#recipe-choice-grunt').val());
    //     var d = parseInt($('#recipe-choice-torf').val());
    //     if( (a>=b) && (a>=c) && (a>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
    //     }
    //     if( (b>=a) && (b>=c) && (b>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
    //     }
    //     if( (c>=a) && (c>=b) && (c>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
    //     }
    //     if( (d>=a) && (d>=b) && (d>=c) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
    //     }
    // });
    // $('#recipe-range-torf').change(function(){
    //     $('#recipe-choice-torf').val($('#recipe-range-torf').val());
    //     sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
    //     if(sum > 10){
    //         alert('Значение не может быть больше 100%');
    //         $('#recipe-range-torf').val("0");
    //         $('#recipe-choice-torf').val("0");
    //     }
    //     if($('#recipe-range-torf').val() == 0){
    //         $('#recipe-value-torf').text( $('#recipe-range-torf').val()+'%');
    //     }else{
    //         $('#recipe-value-torf').text( $('#recipe-range-torf').val()+'0%');
    //     }
    //     var a = parseInt($('#recipe-choice-chernozem').val());
    //     var b = parseInt($('#recipe-choice-pesok').val());
    //     var c = parseInt($('#recipe-choice-grunt').val());
    //     var d = parseInt($('#recipe-choice-torf').val());
    //     if( (a>=b) && (a>=c) && (a>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
    //     }
    //     if( (b>=a) && (b>=c) && (b>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
    //     }
    //     if( (c>=a) && (c>=b) && (c>=d) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
    //     }
    //     if( (d>=a) && (d>=b) && (d>=c) ){
    //          $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
    //     }
    // });

    $('#recipe-choice-chernozem').val("0");
    $('#recipe-choice-pesok').val("0");
    $('#recipe-choice-grunt').val("0");
    $('#recipe-choice-torf').val("0");
    $('#recipe-value-chernozem').text( $('#recipe-choice-chernozem').val()+'%');
    $('#recipe-value-pesok').text( $('#recipe-choice-pesok').val()+'%');
    $('#recipe-value-grunt').text( $('#recipe-choice-grunt').val()+'%');
    $('#recipe-value-torf').text( $('#recipe-choice-torf').val()+'%');
    $('.recipe-order-img').html('<img src="assets/img/recipe-1_1.png">');

    $('#recipe-choice-chernozem').change(function(){
        sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
        if(sum > 10){
            alert('Значение не может быть больше 100%');
            $('#recipe-choice-chernozem').val("0");
        }
        if($('#recipe-choice-chernozem').val() == 0){
            $('#recipe-value-chernozem').text( $('#recipe-choice-chernozem').val()+'%');
        }else{
            $('#recipe-value-chernozem').text( $('#recipe-choice-chernozem').val()+'0%');
        }
        var a = parseInt($('#recipe-choice-chernozem').val());
        var b = parseInt($('#recipe-choice-pesok').val());
        var c = parseInt($('#recipe-choice-grunt').val());
        var d = parseInt($('#recipe-choice-torf').val());
        if( (a>=b) && (a>=c) && (a>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
        }
        if( (b>=a) && (b>=c) && (b>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
        }
        if( (c>=a) && (c>=b) && (c>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
        }
        if( (d>=a) && (d>=b) && (d>=c) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
        }
    });
    $('#recipe-choice-pesok').change(function(){
        sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
        if(sum > 10){
            alert('Значение не может быть больше 100%');
            $('#recipe-choice-pesok').val("0");
        }
        if($('#recipe-choice-pesok').val() == 0){
            $('#recipe-value-pesok').text( $('#recipe-choice-pesok').val()+'%');
        }else{
            $('#recipe-value-pesok').text( $('#recipe-choice-pesok').val()+'0%');
        }
        var a = parseInt($('#recipe-choice-chernozem').val());
        var b = parseInt($('#recipe-choice-pesok').val());
        var c = parseInt($('#recipe-choice-grunt').val());
        var d = parseInt($('#recipe-choice-torf').val());
        if( (a>=b) && (a>=c) && (a>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
        }
        if( (b>=a) && (b>=c) && (b>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
        }
        if( (c>=a) && (c>=b) && (c>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
        }
        if( (d>=a) && (d>=b) && (d>=c) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
        }
    });
    $('#recipe-choice-grunt').change(function(){
        sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
        if(sum > 10){
            alert('Значение не может быть больше 100%');
            $('#recipe-choice-grunt').val("0");
        }
        if($('#recipe-choice-grunt').val() == 0){
            $('#recipe-value-grunt').text( $('#recipe-choice-grunt').val()+'%');
        }else{
            $('#recipe-value-grunt').text( $('#recipe-choice-grunt').val()+'0%');
        }
        var a = parseInt($('#recipe-choice-chernozem').val());
        var b = parseInt($('#recipe-choice-pesok').val());
        var c = parseInt($('#recipe-choice-grunt').val());
        var d = parseInt($('#recipe-choice-torf').val());
        if( (a>=b) && (a>=c) && (a>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
        }
        if( (b>=a) && (b>=c) && (b>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
        }
        if( (c>=a) && (c>=b) && (c>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
        }
        if( (d>=a) && (d>=b) && (d>=c) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
        }
    });
    $('#recipe-choice-torf').change(function(){
        sum = parseInt($('#recipe-choice-chernozem').val()) +  parseInt($('#recipe-choice-pesok').val()) +  parseInt($('#recipe-choice-grunt').val()) +  parseInt($('#recipe-choice-torf').val());
        if(sum > 10){
            alert('Значение не может быть больше 100%');
            $('#recipe-choice-torf').val("0");
        }
        if($('#recipe-choice-torf').val() == 0){
            $('#recipe-value-torf').text( $('#recipe-choice-torf').val()+'%');
        }else{
            $('#recipe-value-torf').text( $('#recipe-choice-torf').val()+'0%');
        }
        var a = parseInt($('#recipe-choice-chernozem').val());
        var b = parseInt($('#recipe-choice-pesok').val());
        var c = parseInt($('#recipe-choice-grunt').val());
        var d = parseInt($('#recipe-choice-torf').val());
        if( (a>=b) && (a>=c) && (a>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_2.png">');
        }
        if( (b>=a) && (b>=c) && (b>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_3.png">');
        }
        if( (c>=a) && (c>=b) && (c>=d) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_4.png">');
        }
        if( (d>=a) && (d>=b) && (d>=c) ){
             $('.recipe-order-img').html('<img src="assets/img/recipe-1_5.png">');
        }
    });


    //slider-catalog
    $('.catalog-slider').slick({
        infinite: true,
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: true,
        dots: true,
        prevArrow: $('.catalog-slider-arrow-left'),
        nextArrow: $('.catalog-slider-arrow-right')
    });

    //slider-whyus
    $(".whyus-slider").owlCarousel({
        loop: true,
        dots: true,
        navContainer: '.whyus-slider-arrow',
        
        nav: true,
        // animateOut: 'fadeOut',
        responsiveClass:true,
        addClassActive: true,
        responsive:{
            0:{
                navText:['<img class="whyus-left" src="assets/img/whyus-left-mob.svg" alt="">',
        '<img class="whyus-right" src="assets/img/whyus-right-mob.svg" alt="">'
        ],
                center: false,
                items:1,
            },
            768:{
                navText:['<img class="whyus-left" src="assets/img/whyus-left-mob.svg" alt="">',
                '<img class="whyus-right" src="assets/img/whyus-right-mob.svg" alt="">'
                ],
                center: false,
                items:2,
            },
            1000:{
                navText:['<img class="whyus-left" src="assets/img/whyus-left.svg" alt="">',
        '<img class="whyus-right" src="assets/img/whyus-right.svg" alt="">'
        ],
                center: true,
                items:5,
            }
        }
    });
    $(".whyus-slider").on("translated.owl.carousel", setCls);
    function setCls() {
        $(".whyus-slider>.owl-stage-outer>.owl-stage>.owl-item").removeClass("sl1").filter(".active").eq(0).addClass("sl1");
        $(".whyus-slider>.owl-stage-outer>.owl-stage>.owl-item").removeClass("sl5").filter(".active").eq(4).addClass("sl5");
    }
    setCls();


    //about-слайдер только на мобильные устройства
    function mobileOnlySlider() {
    $(document).ready(function(){
        $('.about-slider').slick({
                slidesToShow: 1,
                slidesToScroll: 1,
                arrows: true,
                touchMove:true,
                dots: false,
                prevArrow: $('.about-slider-arrow-left'),
                nextArrow: $('.about-slider-arrow-right'), 
                    pauseOnHover: false,
                    responsive: [{
                        breakpoint: 769,
                        settings: {
                            slidesToShow: 1,
                            settings:"unslick"
                    }
                }]
            });
        });
    }
    if(window.innerWidth < 769) {
        mobileOnlySlider();
    }
    $(window).resize(function(e){
        if(window.innerWidth < 769) {
            if(!$('.about-slider').hasClass('slick-initialized')){
                mobileOnlySlider();
            }

        }else{
            if($('.about-slider').hasClass('slick-initialized')){
                $('.about-slider').slick('unslick');
            }
        }
    });

    $('.header-catalog-button').click(function(){
        $('.header-catalog').hide();
         $('.header-catalog-show').show();
         $(".header-contacts a").css({'color':'#000000'});
    });

})