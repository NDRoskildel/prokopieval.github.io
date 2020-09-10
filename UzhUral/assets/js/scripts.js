$(document).ready( function() { 
    //слайдер только на мобильные устройства
    function mobileOnlySlider() {
    $(document).ready(function(){
        $('.section-license-slider').slick({
                slidesToShow: 2,
                slidesToScroll: 2,
                arrows: false,
                touchMove:true,
                dots: true,
                    pauseOnHover: false,
                    responsive: [{
                        breakpoint: 992,
                        settings: {
                            slidesToShow: 2,
                            settings:"unslick"
                    }
                }]
            });
        });
    }
    if(window.innerWidth < 992) {
        mobileOnlySlider();
    }
    $(window).resize(function(e){
        if(window.innerWidth < 992) {
            if(!$('.section-license-slider').hasClass('slick-initialized')){
                mobileOnlySlider();
            }

        }else{
            if($('.section-license-slider').hasClass('slick-initialized')){
                $('.section-license-slider').slick('unslick');
            }
        }
    });

})