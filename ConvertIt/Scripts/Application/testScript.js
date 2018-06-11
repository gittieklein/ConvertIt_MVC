var clicked = function()
{
    alert("you clicked me");

    $.get('Test/GetMessage',
        function (result) {
            alert(result);
        });
}