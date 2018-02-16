$(document).ready(function () {
    var primaryColor = $("#primaryColor").val();
    var secondaryColor = $("#secondaryColor").val();
    $(".primary").css("fill", primaryColor);
    $(".secondary").css("fill", secondaryColor);
});
function changePrimary(color) {
    $(".primary").css("fill", color);
}
function changeSecondary(color) {
    $(".secondary").css("fill", color);
}
