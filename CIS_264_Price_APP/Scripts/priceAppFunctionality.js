sessionStorage.setItem("isAdmin", false);

function toggleLogInOut() {
    let protectedItems = document.querySelectorAll('.protected');

    protectedItems.forEach(item => item.classList.toggle('disable'))

    document.getElementById("login").classList.toggle('disable');
    document.getElementById("logout").classList.toggle('disable');

    sessionStorage.setItem("isAdmin", false);
}

function login() {
    let pw = 'pwd';
    let result = prompt('Enter password', '');

    while (result != "pwd" && result != null) result = prompt('Incorrect Password, Try Again');

    if (pw == 'pwd') {
        toggleLogInOut();
        sessionStorage.setItem("isAdmin", true);
    }
}

document.getElementById("login").addEventListener("click", login);
document.getElementById("logout").addEventListener('click', toggleLogInOut);