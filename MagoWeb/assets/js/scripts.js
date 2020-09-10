$(window).load(windowSize); // при загрузке
$(window).resize(windowSize); 
function windowSize(){
    $width = $(".section-magic-img img").width();
	$(".section-magic-img img").height($width);
}

$('.section-recomend-slider').slick({
	infinite: true,
    slidesToShow: 1,
    slidesToScroll: 1,
    arrows: true,
    dots: true,
    prevArrow: $('.section-recomend-arrow-left img'),
    nextArrow: $('.section-recomend-arrow-right img'), 
});


$(document).ready( function() {
    if ($(window).width() <= 768){
        var  $nav = $('.header-nav-bar');
        $nav.click(function() {
            $('.header').css({
                'background':'url(assets/img/bg_header_m.svg)', 
                'height':'100vh',
                'background-position':'bottom',
                'background-size':'cover',
                'opacity': '1',
                'background-repeat': 'no-repeat'});
            $('.header-nav').css({'flex-direction': 'column'});
            $('.header-nav-bar').hide();
            $('.header-title').show();
            $('.header-nav-items').show();
            $('.header-nav-close').show();
        })
        $('.header-nav-close').click(function(){
            $('.header').css({
                'background':'', 
                'height':'',
                'background-position':'',
                'background-size':'',
                'opacity': '',
                'background-repeat': ''});
            $('.header-nav').css({'flex-direction': ''});
            $('.header-title').hide();
            $('.header-nav-items').hide();
            $('.header-nav-close').hide();
            $('.header-nav-bar').show();
        })
        $('.header-nav-items a').click(function(){
            $('.header').css({
                'background':'', 
                'height':'',
                'background-position':'',
                'background-size':'',
                'opacity': '',
                'background-repeat': ''});
            $('.header-nav').css({'flex-direction': ''});
            $('.header-title').hide();
            $('.header-nav-items').hide();
            $('.header-nav-close').hide();
            $('.header-nav-bar').show();
        })
    };
    $(".callback").click(function(){
        $(".section-form").show();
    });
    $(".section-form-content img").click(function(){
        $(".section-form").hide(); 
    });
    $(document).mouseup(function (e){
        var block = $(".section-form-content");
        var callback = $(".section-form");
        if (!block.is(e.target) 
            && block.has(e.target).length === 0) { 
            callback.hide(); 
        }
    });
})