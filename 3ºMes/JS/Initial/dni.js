function validateDNI() {

    var isValid = false

    try {

        var dniValue = document.getElementById('dniInput').value

        var numbers = dniValue.substr(0, 8);
        console.log(numbers)

        var module = numbers % 23
        console.log(module)

        var letters = "TRWAGMYFPDXBNJZSQVHLCKE"
        var letterResult = letters[module]
        console.log(letterResult)
        console.log(dniValue[8])

        if (dniValue[8] == letterResult) {
            isValid = true
        }
        
    } catch (error) {
        
    }

    document.getElementById("result-p").innerHTML = "Is valid: " + isValid;
}