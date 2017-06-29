
    
$("#SeatsNumber").change(function () {
    if ($("#SeatsNumber option:selected").val() == 1) {
        $("#Traveler1Name").hide();
    } else {
        $("#Traveler1Name").show();
    }
});
