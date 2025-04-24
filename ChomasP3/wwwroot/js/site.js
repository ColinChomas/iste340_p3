// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    //people page
    $("#testAcc").accordion();
    $("#pepAcc").accordion(
        { collapsible: true, active: false, heightStyle: "content" }
    );

    $("#pepTab").tabs();
    $('#allPeople').fadeIn(500);

    //about page...
})