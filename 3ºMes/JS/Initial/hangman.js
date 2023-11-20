var isMatchEnd = false
var lives = 7
const words = [
    "lizard", "cat", "dog", "dolphin", "jaguar", "giraffe", "hippopotamus", "cow", "goat", "elephant", "porcupine", "bird", "fox", "wolf", "goose", "duck", "alligator"
]

var randomWord = words[Math.floor(Math.random() * words.length)]
var guessedWord = ""

console.log(randomWord)

for (let index = 0; index < randomWord.length; index++) {
    guessedWord += "-"
}

window.addEventListener("load", (event) => {
    document.getElementById("guessed-word").innerHTML = guessedWord;
    document.getElementById("lives").innerHTML = "Lives: " + lives;
});


function tryAttempt() {

    if (isMatchEnd) return

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

    var randomArray = randomWord.split("")
    var guessedArray = guessedWord.split("")

    console.log(randomArray)

    if (randomWord.includes(letter)) {

        for (var i = 0; i < randomArray.length; i++) {

            if (randomArray[i] == letter) {
                guessedArray[i] = letter
            }
        }
        guessedWord = guessedArray.join("");
    }
    else {
        lives--
        document.getElementById("hang-image").src="hangman/" + (7 - lives) + ".png";
    }

    var playerInput = document.getElementById('playerInput').value = null

    if (guessedWord == randomWord && lives > 0) {
        document.getElementById("win-text").innerHTML = "You Won!";
        isMatchEnd = true
    }
    else if (lives <= 0) {
        guessedWord = "Word was: " + randomWord
        document.getElementById("lost-text").innerHTML = "Game Over!";
        document.getElementById("hang-image").src="hangman/7.png";
        isMatchEnd = true
    }
}


function tryGuessWord(word) {

    if (word == randomWord) {
        guessedWord = word
        document.getElementById("win-text").innerHTML = "You Won!";
    }
    else {
        lives = 0
        guessedWord = "Word was: " + randomWord
        document.getElementById("lost-text").innerHTML = "Game Over!";
        document.getElementById("hang-image").src="hangman/7.png";
    }
    isMatchEnd = true
}