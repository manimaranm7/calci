$(document).ready(function() {
    $("#calculate").click(function() {
        alert("hello");
        calculateResult();
        return false;
    });
});

function calculateResult() {
    
    var computeUnit = {
        operand1: $("#operand1").val(), operand2: $("#operand2").val(), operationType: $("#operations").val()
    };

    // alert(computeUnit.operand1);

    $.ajax({
        url: 'http://localhost:51543/api/calculation/calculate',
        type: 'POST',
        data: JSON.stringify(computeUnit),
        dataType: 'json',
        contentType: "application/json",
        success: function (data) {
            alert(data.result);
        }
    });
}