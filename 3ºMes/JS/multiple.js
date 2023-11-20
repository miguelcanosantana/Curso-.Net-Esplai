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
        "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.goodhousekeeping.com%2Flife%2Fpets%2Fg4531%2Fcutest-dog-breeds%2F&psig=AOvVaw3_SQJTtos4azNylk3Gl8o9&ust=1700580666605000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCPiq_eTy0oIDFQAAAAAdAAAAABAE",
        "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.goodhousekeeping.com%2Flife%2Fpets%2Fa43276342%2Fcat-instagram-captions%2F&psig=AOvVaw1i4ps3VkqBC2230E2xZTXU&ust=1700580690788000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCIj4g_Hy0oIDFQAAAAAdAAAAABAR",
        "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.worldanimalprotection.us%2Fblogs%2F6-wild-facts-about-lizards&psig=AOvVaw2TLp8PDDi1dSd4dFxmVZHf&ust=1700580723617000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCJDlk4Dz0oIDFQAAAAAdAAAAABAJ",
        "https://as1.ftcdn.net/v2/jpg/00/28/08/40/1000_F_28084010_bGRJetPfBwNcO3YuRC2C3Pz7qASocWQ4.jpg",
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