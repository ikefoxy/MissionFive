// Simple calculator logic
$(document).ready(function () {

    var ratePerHour = 30; // flat hourly rate
    $("#rate").val(ratePerHour);

    $("#calcBtn").on("click", function () {

        // Get user input
        var hoursText = $("#hours").val();
        var hours = Number(hoursText);

        // Validate input
        if (!hoursText || isNaN(hours) || hours <= 0) {
            alert("Please enter a positive number of hours.");
            $("#total").val("");
            return;
        }

        // Calculate total
        var total = hours * ratePerHour;

        // Display result
        $("#total").val("$" + total.toFixed(2));
    });
});