function show() {
    var fname = document.getElementById("txtbox1").value;
    var lname = document.getElementById("txtbox2").value;
    var age = document.getElementById("age").value;
    var address = document.getElementById("address").value;
    var gender = document.getElementById("gender").value;
    confirm("You have Entered:" + "\nName:" + fname + "" + lname + "\nAge:" + age + "\naddress:" + address +"\nGender:"+gender);
}
function changeColor(val) {
    if ((val.value == " ") || (val.value == null)) {
        val.style.background = "pink";

    }
    else {
        val.style.background = "green";
    }
}