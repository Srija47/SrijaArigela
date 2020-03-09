


var x;
x = document.getElementById("amount1").value;
if (isNaN(x) || x < 1 || x > 100) {
    alert("Not a valid amount")
} else {
    document.getElementById("name").focus();
}
function f1() {
    let t11 = document.getElementById("digit1").value;
    if (t11 != null && t11 != 0)
        document.getElementById("digit2").focus();
}
function f2() {
    let t12 = document.getElementById("digit2").value;
    if (t12 != null)
        document.getElementById("digit3").focus();
}
function f3() {
    let t13 = document.getElementById("digit3").value;
    if (t13 != null)
        document.getElementById("digit4").focus();
}
function f4() {
    let t14 = document.getElementById("digit4").value;
    if (t14 != null)
        document.getElementById("digit5").focus();
}
function f5() {
    let t15 = document.getElementById("digit5").value;
    if (t15 != null)
        document.getElementById("digit6").focus();
}
function f6() {
    let t16 = document.getElementById("digit6").value;
    if (t16 != null)
        document.getElementById("digit7").focus();
}
function f7() {
    let t17 = document.getElementById("digit7").value;
    if (t17 != null)
        document.getElementById("digit8").focus();
}
function f8() {
    let t18 = document.getElementById("digit8").value;
    if (t18 != null)
        document.getElementById("digit9").focus();
}
function f9() {
    let t19 = document.getElementById("digit9").value;
    if (t19 != null)
        document.getElementById("digit10").focus();
}
function f10() {
    let t10 = document.getElementById("digit10").value;
    if (t10 != null)
        document.getElementById("email").focus();
}
window.onload = function () {
    var input = document.getElementById("amount").focus();
}
function myFunction(){
    var name = document.getElementById("name").value;
        var pat = /^[a-zA-Z]+$/;
        if (!pat.test(name)) {
            alert("please provide your name");
            document.getElementById("name").focus();
            return false;
        }
    var name1 = document.getElementById("name1").value;
    var pat1 = /^[a-zA-Z]+$/;
    if (!pat1.test(name1)) {
        alert("please provide your name");
        document.getElementById("name1").focus();
        return false;
    }
    var name2 = document.getElementById("name2").value;
    var pat2 = /^[a-zA-Z]+$/;
    if (!pat2.test(name2)) {
        alert("please provide your name");
        document.getElementById("name2").focus();
        return false;
    }
    var name3 = document.getElementById("name3").value;
    var pat3 = /^[a-zA-Z]+$/;
    if (!pat3.test(name3)) {
        alert("please provide your name");
        document.getElementById("name3").focus();
        return false;
    }
    var emailID = document.myForm.email.value;
    atpos = emailID.indexOf("@");
    dotpos = emailID.lastIndexOf(".");

    if (atpos < 1 || (dotpos - atpos < 2)) {
        alert("Please enter correct email ID")
        document.myForm.email.focus();
        return false;
    }
    return (true);

    //if (document.myForm.zip.value == "" || isNaN(document.myForm.zip.value) || (document.myForm.zip.value.length !=6))
    //    {
    //        alert("Please provide a zip in Format ####");
    //        document.myForm.zip.focus();
    //        return false;
    //    }
    var pat1 = ^\d{6}$;
    var pin_code = document.getElementById("zip");
    if (!pat1.test(pin_code.value)) {
        alert("Pin code should be 6 digits ");
        pin_code.focus();
       return false;
    }

    if (document.myForm.country.value == "-1") {
        alert("please provide your country");
        return false;
    }
}
function validate() {
    if (!myfuntion()) {
        jsShow('submit-error');
        producePrompt('Please fix errors to submit.', 'submit-error', 'red');
        setTimeout(function () { jsHide('submit-error'); }, 2000);
        return false;
    }
    else {
    }
}

function jsShow(id) {
    document.getElementById(id).style.display = 'block';
}

function jsHide(id) {
    document.getElementById(id).style.display = 'none';
}
function producePrompt(message, promptLocation, color) {

    document.getElementById(promptLocation).innerHTML = message;
    document.getElementById(promptLocation).style.color = color;
}
