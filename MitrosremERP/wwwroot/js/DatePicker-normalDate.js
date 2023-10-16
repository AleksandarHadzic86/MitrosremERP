$(function () {
    $('.datepickerNormalDate').datepicker({
        dateFormat: 'dd.MM.yy',
        yearRange: "-100:+50",
        autoSize: true,
        showOtherMonths: true,
        selectOtherMonths: true,
        changeMonth: true,
        changeYear: true,
        regional: "sr-SR",
        maxDate: new Date()
    });
});