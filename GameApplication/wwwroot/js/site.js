$(function () {
    console.log("Page is ready");

    /*
    $(document).on("click", ".game-button", function (event) {
        event.preventDefault();

        var buttonNumber = $(this).val();
        console.log("Button number " + buttonNumber + " was clicked");
        doButtonUpdate(buttonNumber);
    }); 
    */

    $(document).bind("contextmenu", function (e) {
        e.preventDefault();
        console.log("Right Click")
    });

    $(document).on("mousedown", ".game-button", function (event) {
        switch (event.which) {
            case 1:
                event.preventDefault()
                var buttonNum = $(this).val();
                console.log(buttonNum + " button was left clicked");
                doButtonUpdate(buttonNum, "/button/ShowOneButton");
                break;
            case 2:
                alert('Middle mouse button pressed');
                break;
            case 3:
                event.preventDefault()
                var buttonNum = $(this).val();
                console.log(buttonNum + " button was left clicked");
                doButtonUpdate(buttonNum, "/button/RightClickShowOneButton");
                break;
            default:
                alert('Nothing');
        }
    });

    
});

function doButtonUpdate(buttonNumber, urlString) {
    $.ajax({
        datatype: "json",
        method: 'POST',
        url: urlString,
        data: {
            "buttonNumber": buttonNumber
        },
        success: function (data) {
            console.log(data);
            $('#' + buttonNumber).html(data);
        }
    });
};
