$(document).ready( function() { 

    $('.main-slider').slick({
        autoplay: true,
        autoplaySpeed: 2000,
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        touchMove:true,
        dots: true,
        // pauseOnHover: false,
    });

    $('.design-mob-slider').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        touchMove:true,
        dots: true,
        pauseOnHover: false,
    });

    $('.portfolio-slider').slick({
        slidesToShow: 3,
        slidesToScroll: 1,
        arrows: true,
        dots: false,
        touchMove:true,
        // dots: true,
        prevArrow: $('.portfolio-slider-arrows-left'),
        nextArrow: $('.portfolio-slider-arrows-right'),
        pauseOnHover: false,
        responsive: [
            {
                breakpoint: 992,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    infinite: true,
                    arrows: false,
                    dots: true
                }
            },
        ] 
    });

    var dots = $('.portfolio-slider li');
    //вешаем обработчик на наши точки
    dots.click(function(){
        var $this = $(this);
        dots.removeClass('before after');
        //отображаем 2 предыдущие точки
        $this
            .prev().addClass('before')
            .prev().addClass('before');
        //отображаем 2 следующие точки
        $this
            .next().addClass('after')
            .next().addClass('after');

    
      //если мы в самом начале - добавляем пару последующих точек
        if(!$this.prev().length) {
        $this.next().next().next()
            .addClass('after').next()
              .addClass('after');
    }
        //на 2й позиции - добавляем одну точку
      if(!$this.prev().prev().length) {
        $this.next().next().next()
          .addClass('after');
    }
        //в самом конце - добавляем пару доп. предыдущих точек
        if(!$this.next().length) {
            $this.prev().prev().prev()
                .addClass('before').prev()
                .addClass('before');
        }
        //предпоследний элемента - добавляем одну пред. точку
        if(!$this.next().next().length) {
            $this.prev().prev().prev()
                .addClass('before');
        }   
    });
    dots.eq(0).click();//кликаем на первую точку
   

    $('.reviews-mob').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        touchMove:true,
        dots: true,
        pauseOnHover: false,
    });


    var s1=false;
    var s2=false;
    var s3=false;
    $('#serv-tab-1').click(function(){
        if(!s1){
                $('#serv-tab-1').css({'background':'url(assets/img/services-arrow-top.svg) #CDDEF0 no-repeat 95% center'});
            $('#services-1').show();
            s1=true;
        }else{
            $('#serv-tab-1').css({'background':'url(assets/img/services-arrow-down.svg) #CDDEF0 no-repeat 95% center'});
            $('#services-1').hide();
            s1=false;
        }
    });
    $('#serv-tab-2').click(function(){
        if(!s2){
                $('#serv-tab-2').css({'background':'url(assets/img/services-arrow-top.svg) #CDDEF0 no-repeat 95% center'});
            $('#services-2').show();
            s2=true;
        }else{
            $('#serv-tab-2').css({'background':'url(assets/img/services-arrow-down.svg) #CDDEF0 no-repeat 95% center'});
            $('#services-2').hide();
            s2=false;
        }
    });
    $('#serv-tab-3').click(function(){
        if(!s3){
                $('#serv-tab-3').css({'background':'url(assets/img/services-arrow-top.svg) #CDDEF0 no-repeat 95% center'});
            $('#services-3').show();
            s3=true;
        }else{
            $('#serv-tab-3').css({'background':'url(assets/img/services-arrow-down.svg) #CDDEF0 no-repeat 95% center'});
            $('#services-3').hide();
            s3=false;
        }
    });


    $('#show-popup-1').click(function(){
        $('#popup-1').show();
        $('.popup-close').click(function(){
            $('#popup-1').hide();
        });
    });
    $('#show-popup-2').click(function(){
        $('#popup-2').show();
        $('.popup-close').click(function(){
            $('#popup-2').hide();
        });
    });
    $('#show-popup-3').click(function(){
        $('#popup-3').show();
        $('.popup-close').click(function(){
            $('#popup-3').hide();
        });
    });
    $('#show-popup-4').click(function(){
        $('#popup-4').show();
        $('.popup-close').click(function(){
            $('#popup-4').hide();
        });
    });
    $('#show-popup-5').click(function(){
        $('#popup-5').show();
        $('.popup-close').click(function(){
            $('#popup-5').hide();
        });
    });
    $('#show-popup-6').click(function(){
        $('#popup-6').show();
        $('.popup-close').click(function(){
            $('#popup-6').hide();
        });
    });
    $('#show-popup-7').click(function(){
        $('#popup-7').show();
        $('.popup-close').click(function(){
            $('#popup-7').hide();
        });
    });
    $('#show-popup-8').click(function(){
        $('#popup-8').show();
        $('.popup-close').click(function(){
            $('#popup-8').hide();
        });
    });
    $('#show-popup-9').click(function(){
        $('#popup-9').show();
        $('.popup-close').click(function(){
            $('#popup-9').hide();
        });
    });


    $('#show-popupm-1').click(function(){
        $('#popup-1').show();
        $('.popup-close').click(function(){
            $('#popup-1').hide();
        });
    });
    $('#show-popupm-2').click(function(){
        $('#popup-2').show();
        $('.popup-close').click(function(){
            $('#popup-2').hide();
        });
    });
    $('#show-popupm-3').click(function(){
        $('#popup-3').show();
        $('.popup-close').click(function(){
            $('#popup-3').hide();
        });
    });
    $('#show-popupm-4').click(function(){
        $('#popup-4').show();
        $('.popup-close').click(function(){
            $('#popup-4').hide();
        });
    });
    $('#show-popupm-5').click(function(){
        $('#popup-5').show();
        $('.popup-close').click(function(){
            $('#popup-5').hide();
        });
    });
    $('#show-popupm-6').click(function(){
        $('#popup-6').show();
        $('.popup-close').click(function(){
            $('#popup-6').hide();
        });
    });
    $('#show-popupm-7').click(function(){
        $('#popup-7').show();
        $('.popup-close').click(function(){
            $('#popup-7').hide();
        });
    });
    $('#show-popupm-8').click(function(){
        $('#popup-8').show();
        $('.popup-close').click(function(){
            $('#popup-8').hide();
        });
    });
    $('#show-popupm-9').click(function(){
        $('#popup-9').show();
        $('.popup-close').click(function(){
            $('#popup-9').hide();
        });
    });

    $('#show-popupf-1').click(function(){
        $('#popup-1').show();
        $('.popup-close').click(function(){
            $('#popup-1').hide();
        });
    });
    $('#show-popupf-2').click(function(){
        $('#popup-2').show();
        $('.popup-close').click(function(){
            $('#popup-2').hide();
        });
    });
    $('#show-popupf-3').click(function(){
        $('#popup-3').show();
        $('.popup-close').click(function(){
            $('#popup-3').hide();
        });
    });
    $('#show-popupf-4').click(function(){
        $('#popup-4').show();
        $('.popup-close').click(function(){
            $('#popup-4').hide();
        });
    });
    $('#show-popupf-5').click(function(){
        $('#popup-5').show();
        $('.popup-close').click(function(){
            $('#popup-5').hide();
        });
    });
    $('#show-popupf-6').click(function(){
        $('#popup-6').show();
        $('.popup-close').click(function(){
            $('#popup-6').hide();
        });
    });
    $('#show-popupf-7').click(function(){
        $('#popup-7').show();
        $('.popup-close').click(function(){
            $('#popup-7').hide();
        });
    });
    $('#show-popupf-8').click(function(){
        $('#popup-8').show();
        $('.popup-close').click(function(){
            $('#popup-8').hide();
        });
    });
    $('#show-popupf-9').click(function(){
        $('#popup-9').show();
        $('.popup-close').click(function(){
            $('#popup-9').hide();
        });
    });
})