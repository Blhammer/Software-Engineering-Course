function validate() {
    let emailButton = document.getElementById('email');
    
    emailButton.addEventListener('change', validation);

    function validation(ev) {
        if (/^[a-z]+@[a-z]+\.[a-z]+$/.test(ev.target.value)) {
            ev.target.classList.remove('error');
        } else {
            ev.target.classList.add('error');
        }
    }
}