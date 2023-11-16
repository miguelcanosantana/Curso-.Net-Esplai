
function calculatePow() {
    var numberValue = document.getElementById('numberInput').value
    var powValue = document.getElementById('powInput').value
    var result = Math.pow(numberValue, powValue)
    document.getElementById("result-p").innerHTML = "Result: " + result;
}