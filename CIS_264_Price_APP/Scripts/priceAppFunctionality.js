function login() {

  close.onclick = function() {
    placeholder.innerText = "";
    document.getElementById('popup').style.display = "none";
    result.value = "";
  }
      if (sessionStorage.getItem("isAdmin") == "false") {
        document.getElementById('popupbox').style.visibility="visible";
        document.getElementById('popup').style.display="block";
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
    document.getElementById('popupbox').style.visibility="hidden";
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

let loginBtn = document.getElementById('login');
let result = document.getElementById("password");
let placeholder = document.getElementById("placeholder");
let close = document.getElementById('close');
let pw = 'pwd';

if (!sessionStorage.getItem("isAdmin")) {
  sessionStorage.setItem("isAdmin", false);
}

if (sessionStorage.getItem("isAdmin") == "true") {
  loginBtn.innerText="Logout";
}

loginBtn.addEventListener('click', login);
