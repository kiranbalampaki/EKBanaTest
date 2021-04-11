$("#DateOfBirth").change(function () {
    debugger

    var TodayDate = new Date();
    var selectedDate = new Date(Date.parse($("#DateOfBirth").val()));

    if (selectedDate > TodayDate) {
        alert("Date Entered is greater than Current Date ");
        $("#DateOfBirth").val("");
    }
});