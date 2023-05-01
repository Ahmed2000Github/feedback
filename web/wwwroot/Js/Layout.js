$(document).ready(function () {
    //nav bar 
    $(window).scroll(function () {
        var pos = $(this).scrollTop();
        if (pos == 0 && $('.nav-web').hasClass('nav-web-black')) {
            $('.nav-web').removeClass('nav-web-black');
        } else {
            $(".nav-web").addClass('nav-web-black');
        }
    });
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
        if (width + 17 >= 800) {
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
    // logo
    $('#logo img').on("mouseover", function () {
        $(this).attr('src', "../Images/Generales/LigthLogo.png");
    });
    $('#logo img').on("mouseleave", function () {
        $(this).attr('src', "../Images/Generales/DarkLogo.png");
    });
    //login
    $('.close-log').on('click', function () {
        $('.login-container').css("display", "none");
        $('.login').css("display", "flex");
        $('.ExternalLogins').css("display", "none");
        var width = $(window).width();
        if (width + 17 <= 800) {
            $('.nav-side').toggle(500);
        }
    });
    $('.email').on("click", function () {
        $('.login').css("display", "none");
        $('.ExternalLogins').css("display", "flex");
    });
    //$('#login4').on('click', function (e) {
    //    e.preven
    //    $('.login-container').css("display", "flex");
    //    var width = $(window).width();
    //    if (width + 17 <= 800) {
    //        $('.nav-side').toggle(500);
    //    }
    //});
    //$('#login2').on('click', function (e) {
    //    e.preven
    //    $('.login-container').css("display", "flex");
    //    var width = $(window).width();
    //    if (width + 17 <= 800) {
    //        $('.nav-side').toggle(500);
    //    }
    //});
    $('.click-login').on('click', function (e) {
        e.preven
        $('.login-container').css("display", "flex");
        var width = $(window).width();
        if (width + 17 <= 800) {
            $('.nav-side').toggle(500);
        }
    });

});