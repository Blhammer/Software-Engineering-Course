function validate() {
    let usernameElement = document.getElementById('username');
    let emailElement = document.getElementById('email');
    let passwordElement = document.getElementById('password');
    let confirmPasswordElement = document.getElementById('confirm-password');

    let clickedBoxElement = document.getElementById("valid");
    let companyCheckboxElement = document.getElementById("company");
    let companyNumberElement = document.getElementById("companyNumber");

    let submitButton = document.getElementById("submit");

    companyCheckboxElement.addEventListener("change", (ev) => {
        if (ev.currentTarget.checked) {
            document.getElementById("companyInfo").style.display = "block";
        } else {
            document.getElementById("companyInfo").style.display = "none";
        }
    });

    submitButton.type = "button";
    submitButton.addEventListener("click", validation);

    let usernameRegEx = /^[A-Za-z0-9]{3,20}$/g;
    let passwordRegEx = /^[\w]{5,15}$/g;
    let emailRegEx = /^[^@.]+\@[^@]*\.[^@]*$/g;;

    function validation(ev) {
        ev.preventDefault();

        let username = usernameElement.value;
        let email = emailElement.value;
        let password = passwordElement.value;
        let confirmPassword = confirmPasswordElement.value;
        let companyNumber = undefined;
        let checker = true;

        if (!usernameRegEx.test(username)) {
            usernameElement.style.borderColor = "red";
            checker = false;
        } else {
            usernameElement.style.border = "none";
        }

        if (!emailRegEx.test(email)) {
            emailElement.style.borderColor = "red";
            checker = false;
        } else {
            emailElement.style.border = "none";
        }

        if (password !== confirmPassword || (!passwordRegEx.test(password) || passwordRegEx.test(confirmPassword))) {
            passwordElement.style.borderColor = "red";
            confirmPasswordElement.style.borderColor = "red";
            checker = false;
        } else {
            passwordElement.style.border = "none";
            confirmPasswordElement.style.border = "none";
        }

        if (companyCheckboxElement.checked) {
            companyNumber = Number(companyNumberElement.value);
        }

        if (companyNumber !== undefined && (companyNumber < 1000 || companyNumber > 9999)) {
            companyNumberElement.style.borderColor = "red";
            checker = false;
        } else {
            companyNumberElement.style.border = "none";
        }

        if (checker === true) {
            clickedBoxElement.style.display = "block";
        } else {
            clickedBoxElement.style.display = "none";
        }
    }
}