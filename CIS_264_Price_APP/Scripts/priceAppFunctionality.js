function login() {

  close1.onclick = function() {
    placeholder.innerText = "";
    document.getElementById('popup').style.display = "none";
    result.value = "";
  } 

      if (sessionStorage.getItem("isAdmin") == "false") {
        document.getElementById('popupbox1').style.visibility="visible";
        document.getElementById('popup').style.display = "block";

        result.addEventListener("keyup", function (event) {
            if (event.keyCode === 13) {
                event.preventDefault();
                document.getElementById("submit").click();
            }
         });

        document.getElementById('submit').addEventListener('click', validate);
      }
      else if (sessionStorage.getItem("isAdmin") == "true"){
        sessionStorage.setItem("isAdmin", false);
        toggleLogInOut();
      }

}

function validate() {

  if (result.value == pw) {
    sessionStorage.setItem("isAdmin", true);
    result.value = "";
    placeholder.innerText = "";
    document.getElementById('popupbox1').style.visibility="hidden";
    document.getElementById('popup').style.display="none";
    toggleLogInOut();
  }
  else {
    placeholder.innerText = "Incorrect Password";
  }

}

function toggleLogInOut() {

  let protectedItems = document.querySelectorAll('.protected');

  if (sessionStorage.getItem("isAdmin") == "true") {
      loginBtn.innerText = "Logout";
      protectedItems.forEach(item => item.classList.remove('disable'));
  }
  else if (sessionStorage.getItem("isAdmin") == "false"){
      loginBtn.innerText = "Login";
      protectedItems.forEach(item => item.classList.add('disable'));
  }

}

function changePassword() {

    document.getElementById('popupbox1').style.visibility = "hidden";
    document.getElementById('popupbox2').style.visibility = "visible";
    document.getElementById('confirmNew').style.visibility = "visible";

    close2.onclick = function () {
        placeholder.innerText = "";
        document.getElementById('popup').style.display = "none";
        result.value = "";
    }



}

let loginBtn = document.getElementById('login');
let result = document.getElementById('password');
let p1 = document.getElementById('p1')
let p2 = document.getElementById('p2');
let placeholder = document.getElementById('placeholder');
let close1 = document.getElementById('close1');
let close2 = document.getElementById('close2');
let change = document.getElementById('change');
let pw = localStorage.password;

if (!pw) {
    pw.password = 'admin';
}

if (!sessionStorage.getItem("isAdmin")) {
  sessionStorage.setItem("isAdmin", false);
}

if (sessionStorage.getItem("isAdmin") == "true") {
  loginBtn.innerText="Logout";
}

loginBtn.addEventListener('click', login);
change.addEventListener('click', changePassword);
