$(window).scroll(function () {
    var pos = $(this).scrollTop();
    if (pos == 0 && $('.nav-min').hasClass('nav-min-black')) {
        $('.nav-min').removeClass('nav-min-black');
    } else {
        $(".nav-min").addClass('nav-min-black');
    }
});
$(window).resize(function () {
    var width = $(window).width();
    if (width >=524) {
        $('.nav-min').css('display', 'none');
        $('.nav-side').css('display', 'none');
    }
    else {
        if ($('.nav-min').css('display') == 'none' && $('.nav-side').css('display') == 'none') {
            $('.nav-min').css('display', 'flex');
        }
    }
});
$('.menu').on('click', function () {

    $('.nav-min').css('display', 'none');
    $('.nav-side').css('display', 'flex');

});
$('.close').on('click', function () {
    $('.nav-side').css('display', 'none');
    $('.nav-min').css('display', 'flex');
});
//login
$('.close-log').on('click', function () {
    $('.login-container').css("display", "none");
    var width = $(window).width();
    if (width + 17 <= 800) {
        $('.nav-side').toggle(500);
    }
});
$('#login').on('click', function (e) {
    e.preven
    $('.login-container').css("display", "flex");
    var width = $(window).width();
    if (width + 17 <= 800) {
        $('.nav-side').toggle(500);
    }
});
$('#login1').on('click', function () {
    $('.login-container').css("display", "flex");
    var width = $(window).width();
    if (width + 17 <= 800) {
        $('.nav-side').toggle(500);
    }
});
 // logo
    $('#logo img').on("mouseover", function () {
        $(this).attr('src', "/Images/Generales/LigthLogo.png");
    });
    $('#logo img').on("mouseleave", function () {
        $(this).attr('src', "/Images/Generales/DarkLogo.png");
    });
