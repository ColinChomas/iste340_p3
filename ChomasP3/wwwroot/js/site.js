// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Initialize tabs and accordions
$(function () {
    // People page
    $("#pepTab").tabs();
    $('#allPeople').fadeIn(500);

    // Degrees page
    $("#degreeTab").tabs();
    $('#allDegrees').fadeIn(500);

    $("#undrgrdAcc, #gradAcc, #minorAcc").accordion({
        collapsible: true,
        active: false,
        heightStyle: "content"
    });

    $(document).tooltip({
        position: {
            my: "center bottom-20",
            at: "center top",
            using: function (position, feedback) {
                $(this).css(position);
                $("<div>")
                    .addClass("arrow")
                    .addClass(feedback.vertical)
                    .addClass(feedback.horizontal)
                    .appendTo(this);
            }
        }
    });

    try {
        let table = $('#coopTable').DataTable();
        console.log("DataTable initialized successfully");
    } catch (e) {
        console.error("DataTable initialization error:", e);
    }
});
