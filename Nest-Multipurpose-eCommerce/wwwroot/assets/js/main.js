AOS.init();

$(window).scroll(function () {
    var header = $('.header-bottom'),
        scroll = $(window).scrollTop();

    if (scroll >= 200) header.addClass('fixed');
    else header.removeClass('fixed');
});

$(window).scroll(function () {
    var header = $('.header-bottom-2'),
        scroll = $(window).scrollTop();

    if (scroll >= 200) header.addClass('fixed').css('box-shadow', '0 8px 20px 0 rgba(0, 0, 0, 0.05)');
    else header.removeClass('fixed').css('box-shadow', 'none');
});

$(window).scroll(function () {
    var header = $('#mobile-header'),
        scroll = $(window).scrollTop();

    if (scroll >= 200) header.addClass('fixed').css('box-shadow', '0 8px 20px 0 rgba(0, 0, 0, 0.05)');
    else header.removeClass('fixed').css('box-shadow', 'none');
});

$(window).scroll(function () {
    if ($(window).scrollTop() > 400) {
        $('#scrollToTop').css({
            'opacity': '1',
            'visibility': 'visible'
        });
    } else {
        $('#scrollToTop').css({
            'opacity': '0',
            'visibility': 'hidden'
        });
    }
})

$('#scrollToTop').click(function () {
    $('html,body').animate({
        scrollTop: 0
    }, 900)
})

$(document).ready(function () {
    $('.welcome-slider').slick({
        dots: false,
        infinite: true,
        autoplay: true,
        autoplaySpeed: 2000,
        adaptiveHeight: true,
        speed: 300,
        slidesToShow: 3,
        slidesToScroll: 1,
        prevArrow: '<i class="fi-rs-arrow-small-left slick-prev"></i>',
        nextArrow: '<i class="fi-rs-arrow-small-right slick-next"></i>',
        responsive: [{
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 1,
                    infinite: true,
                    dots: false
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    });
});

$(document).ready(function () {
    $('.news-flash').slick({
        infinite: true,
        slidesToShow: 1,
        slidesToScroll: 1,
        autoplay: true,
        vertical: true,
        arrows: false
    });
});

$('.sidebar-menu i').click(function () {
    $(this).parents('.dropdown').find('.dropdown').not($(this).siblings('ul')).slideUp();
    $(this).siblings('ul').stop(true, true).slideToggle();
});

$('#btn-open-navbar, #btn-close-navbar, .overlay').click(function () {
    $('.overlay, .sidebar').toggleClass('active');
});