/**
 * @author TBD(L)
 * @file priceAppFunctionality.js
 * Nov 2021
 **/

// static password set here
// change this value to change the password
const pw = 'pwd';

function login() {
    // hides pop-up if user clicks 'x' button
    close.onclick = function() {
        placeholder.innerText = "";
        document.getElementById('popup').style.display = "none";
        result.value = "";
    }
    // displays pop-up for user login
    if (sessionStorage.getItem("isAdmin") == "false") {
        document.getElementById('popupbox').style.visibility="visible";
        document.getElementById('popup').style.display = "block";

        // allows use of enter key to for confirming password
        result.addEventListener("keyup", function (event) {
            if (event.keyCode === 13) {
                event.preventDefault();
                document.getElementById("submit").click();
            }
         });
        // calls validate() when user clicks submit button
        document.getElementById('submit').addEventListener('click', validate);
    }
    // logs user out and hides archived items
    else if (sessionStorage.getItem("isAdmin") == "true"){
        sessionStorage.setItem("isAdmin", false);
        toggleLogInOut();

        let archiveBtn = document.querySelectorAll('.archive');
        archiveBtn.forEach(btn => btn.addEventListener("change", toggleArchive));
    }

}

function validate() {
    // checks if user enters correct password
    // if correct, toggleLogInOut() is called
    // archived items are made visible
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

function toggleDetail(btn) {
    console.log("run");
    //console.log(document.querySelector('#detailsBtn').innerText);
    //document.querySelector('#detailsBtn').innerText = 'Close Details';
    console.log(btn);
}

/*
function toggleArchive() {
    // marks as archived when logged in and hides archived items when logged out
    if (this.checked) {
        this.parentElement.parentElement.classList.add('protected', 'archived');
    } else {
        // un-archive item
        this.parentElement.parentElement.className = "";
    }
}*/

// additional variables
let loginBtn = document.getElementById('login');
let result = document.getElementById('password');
let close = document.getElementById('close');
let placeholder = document.getElementById('placeholder');
let detailsBtns = document.querySelectorAll('.detailsBtn');

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

//detailBtns.forEach(item => addEventListener('click', toggleDetail));
for (let i = 0; i < detailsBtns.length; i++) {
    detailsBtns[i].addEventListener('click', function () { toggleDetail(detailsBtn[i]); });
}
