var currentPlayer = Math.round(Math.random())
var currentPlayerName = null

updateCurrentPlayer(false)


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

    if (currentPlayer == 0) {
        currentPlayerName = "X"
    } else {
        currentPlayerName = "O"
    }

    document.getElementById("current-player-text").innerHTML = currentPlayerName + "'s round."
}


function clickCell(cellId) {

    updateCurrentPlayer(true)
}
