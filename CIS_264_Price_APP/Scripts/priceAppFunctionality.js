function login() {
  // tyler's code here for pop up

  close.onclick = function() {
    document.getElementById('popup').style.display = "none";
  }
  if (loginBtn.id == "login") {
    document.getElementById('popupbox').style.visibility="visible";
    document.getElementById('popup').style.display="block";
    document.getElementById('submit').addEventListener('click', validate);
  }
  else if (loginBtn.id == "logout"){
    toggleLogInOut();
  }

  //while (result != "pwd" && result != null) result = document.getElementById("placeholder").innerText;

}

function validate() {

  let result = document.getElementById("password");
  let placeholder = document.getElementById("placeholder");

  if (result.value == pw) {
    result.value = "";
    document.getElementById('popupbox').style.visibility="hidden";
    document.getElementById('popup').style.display="none";
    toggleLogInOut();
  }
  else {
    placeholder.innerText = "Incorrect Password";
  }

}

function toggleLogInOut() {
  //let protectedItems = document.querySelectorAll('.protected');
  //protectedItems.forEach(item => item.classList.toggle('disable'));
  console.log(loginBtn.innerText);
  if (loginBtn.id == "login") {
    loginBtn.id="logout";
    loginBtn.innerText="Logout";
  }
  else if (loginBtn.id == "logout"){
    loginBtn.id="login";
    loginBtn.innerText="Login";
  }
  console.log(loginBtn.innerText);
}

let loginBtn = document.getElementById('login');
loginBtn.addEventListener('click', login);
let close = document.getElementById('close');
let pw = 'pwd';
