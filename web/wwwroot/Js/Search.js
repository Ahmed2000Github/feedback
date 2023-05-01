// input-search

$("body").click(function (e) {
    $(".suggetion").css("display", "none");
});
$("#search").click(function (e) {
    e.stopPropagation()
    if ($("#search").val() == "") {
        $(".suggetion").css("display", "none");
    }
    if ($(".suggetion ul").is(':empty')) {
        $(".suggetion").css("display", "none");
    }
});