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
        updateCurrentPlayer(true)
    }
}
