$(function () {
    console.log("Page is ready");

    $(document).on("click", ".game-button", function (event) {
        event.preventDefault();

        var buttonNumber = $(this).val();
        console.log("Button number " + buttonNumber + " was clicked");
        doButtonUpdate(buttonNumber);
    });
});

function doButtonUpdate(buttonNumber) {
    $.ajax({
        datatype: "json",
        method: 'POST',
        url: '/button/showOneButton',
        data: {
            "buttonNumber": buttonNumber
        },
        success: function (data) {
            console.log(data);
            $('#' + buttonNumber).html(data);
        }
    });
};
