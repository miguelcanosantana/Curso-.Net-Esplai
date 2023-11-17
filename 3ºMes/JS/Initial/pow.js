
function calculatePow() {
    var numberValue = document.getElementById('numberInput').value
    var exponentValue = document.getElementById('powInput').value

    var result = 1

    for (i = 0; i < exponentValue; i++) {
        result *= numberValue;
    }

    document.getElementById("result-p").innerHTML = "Result: " + result;
}