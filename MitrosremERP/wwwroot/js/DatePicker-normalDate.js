$(function () {
    $('.datepickerNormalDate').datepicker({
        dateFormat: 'dd.MM.yy',
        yearRange: '0:c+1',
        autoSize: true,
        showOtherMonths: true,
        selectOtherMonths: true,
        changeMonth: true,
        changeYear: true,
        regional: "sr-SR",
        minDate: new Date()
    });
});