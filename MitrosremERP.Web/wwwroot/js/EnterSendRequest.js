$(document).ready(function () {
    $(document).keypress(function (event) {
        // Proverite da li je pritisnut taster Enter (keyCode 13)
        if (event.keyCode == 13) {

             $("#forma").submit();
        }
    });
});