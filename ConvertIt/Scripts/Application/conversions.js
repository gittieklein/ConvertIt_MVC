var resetResults = function()
{
    $('#calcResult').val("Result");
}

var calculateCurrency = function () {
    var input = document.getElementsByName('input')[0].value;
    var from = document.getElementsByName('from')[0].value;
    var to = document.getElementsByName('to')[0].value;

    if (input == '' || from == '' || to == '') {
        $('.input-error').removeClass('hide');
        return;
    }
    
    $('.loader-holder').append('<div class="loader"></div>');

    $.get('CalculateCurrency?input=' + input + '&to=' + to + '&from=' + from,
        function (result) {
            $('.input-error').addClass('hide');
            $('#calcResult').val(result);
            $('.loader').remove();
        });
}

var calculateLength = function ()
{
    var input = document.getElementsByName('input')[0].value;
    var from = document.getElementsByName('from')[0].value;
    var to = document.getElementsByName('to')[0].value;

    if (input == '' || from == '' || to == '')
    {
        $('.input-error').removeClass('hide');
        return;
    }

    $.get('CalculateLength?input=' + input + '&to=' + to + '&from=' + from,
        function (result) {
            $('.input-error').addClass('hide');
            $('#calcResult').val(result);
        });
}

var calculateTemp = function () {
    var input = document.getElementsByName('input')[0].value;
    var from = document.getElementsByName('from')[0].value;
    var to = document.getElementsByName('to')[0].value;

    if (input == '' || from == '' || to == '') {
        $('.input-error').removeClass('hide');
        return;
    }

    $.get('CalculateTemperature?input=' + input + '&to=' + to + '&from=' + from,
        function (result) {
            $('.input-error').addClass('hide');
            $('#calcResult').val(result);
        });
}

var calculateTime = function () {
    var input = document.getElementsByName('input')[0].value;
    var from = document.getElementsByName('from')[0].value;
    var to = document.getElementsByName('to')[0].value;

    if (input == '' || from == '' || to == '') {
        $('.input-error').removeClass('hide');
        return;
    }

    $.get('CalculateTime?input=' + input + '&to=' + to + '&from=' + from,
        function (result) {
            $('.input-error').addClass('hide');
            $('#calcResult').val(result);
        });
}

var calculateWeight = function () {
    var input = document.getElementsByName('input')[0].value;
    var from = document.getElementsByName('from')[0].value;
    var to = document.getElementsByName('to')[0].value;

    if (input == '' || from == '' || to == '') {
        $('.input-error').removeClass('hide');
        return;
    }

    $.get('CalculateWeight?input=' + input + '&to=' + to + '&from=' + from,
        function (result) {
            $('.input-error').addClass('hide');
            $('#calcResult').val(result);
        });
}

