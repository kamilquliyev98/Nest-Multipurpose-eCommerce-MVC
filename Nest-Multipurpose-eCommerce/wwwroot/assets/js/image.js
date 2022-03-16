$(document).ready(function () {
    $('.product-image-slider').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        fade: true,
        asNavFor: '.product-slider-nav'
    });

    $('.product-slider-nav').slick({
        slidesToShow: 4,
        slidesToScroll: 1,
        asNavFor: '.product-image-slider',
        dots: false,
        infinite: true,
        centerMode: false,
        focusOnSelect: true,
        prevArrow: '<i class="fi-rs-arrow-small-left slick-prev"></i>',
        nextArrow: '<i class="fi-rs-arrow-small-right slick-next"></i>'
    });

    $('#zoom_in').ezPlus({
        zoomType: 'inner',
        cursor: 'crosshair',
        scrollZoom: true,
        zoomWindowFadeIn: 500,
        zoomWindowFadeOut: 750
    });
});