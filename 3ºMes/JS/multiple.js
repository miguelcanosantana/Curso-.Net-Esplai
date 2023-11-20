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


function showAlertAge() {

    let name = prompt("Enter your name:");

    if (name == null || name == "") {
        window.alert("Name was left empty");
        return
    }

    let age = prompt("Enter your age:");

    if (age == null || age == "" || age < 0) {
        window.alert("Age was not correct");
        return
    }

    document.getElementById("name-result-prompt").innerHTML = "Name: " + name;
    document.getElementById("age-result-prompt").innerHTML = "Age: " + age;
    document.getElementById("lived-result-prompt").innerHTML = "Lived: " + age * 365 + " days";
}