$(window).scroll(function () { 
    var pos = $(this).scrollTop();
   if (pos==0 && $('.nav-min').hasClass('nav-min-black')) {
    $('.nav-min').removeClass('nav-min-black');
   } else {
       $(".nav-min").addClass('nav-min-black');
    }
});
$(window).resize(function () { 
   var width = $(window).width();
   if (width >=502) {
    $('.nav-min').css('display', 'none');
    $('.nav-side').css('display', 'none');
   }
   else{
       if ($('.nav-min').css('display')=='none'&& $('.nav-side').css('display')=='none' ) {
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
// input file
$('#File').on('change', function () {
    var file =  $('#File').get(0).files[0];
    if (file) {
        var reader = new FileReader();
        reader.onload = ()=>{
            $('#avatar').attr('src', reader.result);
        }
        reader.readAsDataURL(file);
    }
});