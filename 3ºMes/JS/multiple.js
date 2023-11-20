function changeColor(buttonId, color) {

    var button = document.getElementById(buttonId)
    button.style.backgroundColor = color
}


function changeColorOfElement(color) {

    if(document.getElementById('entire-doc-radio').checked) {
        document.body.style.backgroundColor = color

    } else if(document.getElementById('layer-radio').checked) {
        document.getElementById('small-layer').style.backgroundColor = color
    }

}