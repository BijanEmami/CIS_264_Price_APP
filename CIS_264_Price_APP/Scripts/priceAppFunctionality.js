/**
 * @author TBD(L) 
 * @file priceAppFunctionality.js
 * Nov 2021
 **/

// static password set here
// change this value to change the password
let pw = 'pwd';

function login() {
  close.onclick = function() {
    placeholder.innerText = "";
    document.getElementById('popup').style.display = "none";
    result.value = "";
  }
      if (sessionStorage.getItem("isAdmin") == "false") {
        document.getElementById('popupbox').style.visibility="visible";
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

          let archiveBtn = document.querySelectorAll('.archive');
          archiveBtn.forEach(btn => btn.addEventListener("change", toggleArchive));
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

      let archiveBtn = document.querySelectorAll('.archive');
      archiveBtn.forEach(btn => btn.addEventListener("change", toggleArchive));
  }
  else {
    placeholder.innerText = "Incorrect Password";
  }

}

function toggleLogInOut() {
  // get items to disable when logged out
  let protectedItems = document.querySelectorAll('.protected');

    if (sessionStorage.getItem("isAdmin") == "true") {
      // login user and enable protected features
      loginBtn.innerText = "Logout";
      protectedItems.forEach(item => item.classList.remove('disable'));
  }
    else if (sessionStorage.getItem("isAdmin") == "false") {
      // logout user and disable protected features
      loginBtn.innerText = "Login";
      protectedItems.forEach(item => item.classList.add('disable'));
  }

}

function toggleArchive() {
    // marks as archived when logged in and hides archived items when logged out
    if (this.checked) {
        this.parentElement.parentElement.classList.add('protected', 'archived');
    } else {
        // un-archive item
        this.parentElement.parentElement.className = "";
    }
}

// additional variables
let loginBtn = document.getElementById('login');
let result = document.getElementById('password');
let close = document.getElementById('close');

let placeholder = document.getElementById('placeholder');

// check if user is logged in or out
if (!sessionStorage.getItem("isAdmin")) {
  sessionStorage.setItem("isAdmin", false);
}

// log in user if logged in on previous page
if (sessionStorage.getItem("isAdmin") == "true") {
  loginBtn.innerText="Logout";
}

// logout user or open login pop-up box when login/logout button is clicked
loginBtn.addEventListener('click', login);
