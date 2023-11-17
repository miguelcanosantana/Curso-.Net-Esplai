var lives = 3
const words = [
    "lizard", "cat", "dog", "dolphin", "jaguar", "giraffe", "hippopotamus", "cow", "goat", "elephant", "porcupine", "bird", "fox", "wolf", "goose", "duck", "alligator"
]

var randomWord = words[Math.floor(Math.random() * words.length)]
var guessedWord = ""

for (let index = 0; index < randomWord.length; index++) {
    guessedWord += "-"
}

window.addEventListener("load", (event) => {
    document.getElementById("guessed-word").innerHTML = guessedWord;
    document.getElementById("lives").innerHTML = "Lives: " + lives;
});


function tryAttempt() {

    var playerInput = document.getElementById('playerInput').value
    
    if (playerInput.length == 1) {
        tryGuessLetter(playerInput)
    }
    else {
        tryGuessWord(playerInput)
    }

    document.getElementById("guessed-word").innerHTML = guessedWord;
    document.getElementById("lives").innerHTML = "Lives: " + lives;
}


function tryGuessLetter(letter) {

    if (randomWord.includes(letter)) {

    }
    else {
        lives--
    }

}


function tryGuessWord(word) {
    
}



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