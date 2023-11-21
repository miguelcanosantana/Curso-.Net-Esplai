var currentPlayer = Math.round(Math.random())
var currentPlayerName = getPlayerName()

updateCurrentPlayer(false)


function getPlayerName() {
    if (currentPlayer == 0) {
        return "X"
    } else {
        return "O"
    }
}



//Update current player turn
function updateCurrentPlayer(isChangingPlayer) {

    if (isChangingPlayer == true){

        if (currentPlayer == 0) {
            currentPlayer = 1
        }
        else {
            currentPlayer = 0
        }
    }

    currentPlayerName = getPlayerName()

    document.getElementById("current-player-text").innerHTML = currentPlayerName + "'s round."
}


function clickCell(cellId) {

    let cell = document.getElementById(cellId)

    if (cell.innerHTML != "X" && cell.innerHTML != "O") {
        cell.innerHTML = currentPlayerName

        var winner = checkWinner(currentPlayerName)

        //TODO
        //if (winner)

        updateCurrentPlayer(true)
    }
}


function checkWinner(symbol) {

    //Horizontal checks
    if (document.getElementById("cell-1").innerHTML == symbol &&
        document.getElementById("cell-2").innerHTML == symbol &&
        document.getElementById("cell-3").innerHTML == symbol ||
        document.getElementById("cell-4").innerHTML == symbol &&
        document.getElementById("cell-5").innerHTML == symbol &&
        document.getElementById("cell-6").innerHTML == symbol ||
        document.getElementById("cell-7").innerHTML == symbol &&
        document.getElementById("cell-8").innerHTML == symbol &&
        document.getElementById("cell-9").innerHTML == symbol) {
            return symbol
    }

    //Vertical checks
    if (document.getElementById("cell-1").innerHTML == symbol &&
        document.getElementById("cell-4").innerHTML == symbol &&
        document.getElementById("cell-7").innerHTML == symbol ||
        document.getElementById("cell-2").innerHTML == symbol &&
        document.getElementById("cell-5").innerHTML == symbol &&
        document.getElementById("cell-8").innerHTML == symbol ||
        document.getElementById("cell-3").innerHTML == symbol &&
        document.getElementById("cell-6").innerHTML == symbol &&
        document.getElementById("cell-9").innerHTML == symbol) {
            return symbol
    }

    //Diagonal checks
    if (document.getElementById("cell-1").innerHTML == symbol &&
        document.getElementById("cell-5").innerHTML == symbol &&
        document.getElementById("cell-9").innerHTML == symbol ||
        document.getElementById("cell-7").innerHTML == symbol &&
        document.getElementById("cell-5").innerHTML == symbol &&
        document.getElementById("cell-3").innerHTML == symbol) {
            return symbol
    }

    return null
}
