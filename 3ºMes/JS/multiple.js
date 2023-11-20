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


function calculateAge() {

    let name = document.getElementById("name-input").value
    let age = document.getElementById("age-input").value

    if (name == null || name == "") {
        window.alert("Name was left empty");
        return
    }

    if (age == null || age == "" || age < 0) {
        window.alert("Age was not correct");
        return
    }

    document.getElementById("name-result-text").innerHTML = "Name: " + name;
    document.getElementById("age-result-text").innerHTML = "Age: " + age;
    document.getElementById("lived-result-text").innerHTML = "Lived: " + age * 365 + " days";
}


function selectImage() {

    let value = document.getElementById("image-selector").value

    let imageList = [
        "https://images.unsplash.com/photo-1517849845537-4d257902454a?q=80&w=1935&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
        "https://images.unsplash.com/photo-1608848461950-0fe51dfc41cb?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
        "https://images.unsplash.com/photo-1504450874802-0ba2bcd9b5ae?q=80&w=2080&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
        "https://images.unsplash.com/photo-1605559911160-a3d95d213904?q=80&w=1924&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
      ];

    switch (value) {
        case "1":
            document.getElementById("selector-image").src = imageList[0];
            break;
        case "2":
            document.getElementById("selector-image").src = imageList[1];
            break;
        case "3":
            document.getElementById("selector-image").src = imageList[2];
            break;
        case "4":
            document.getElementById("selector-image").src = imageList[3];
            break;
        default:
            document.getElementById("selector-image").src="";
    }
      

}