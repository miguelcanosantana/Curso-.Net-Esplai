var numberInput = document.getElementsByName('numberInput')[0]
var powInput = document.getElementsByName('powInput')[0]


function calculatePow() {
    var pow = Math.pow(numberInput.value, powInput.value)
}