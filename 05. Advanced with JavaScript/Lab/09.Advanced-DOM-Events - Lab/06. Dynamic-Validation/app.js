function validate() {
    let inputElement = document.getElementById('email');
    let regex = /^[a-z]+@[a-z]+\.[a-z]+$/; 

    inputElement.addEventListener('change', function() {
        if (regex.test(inputElement.value)) {
            inputElement.classList.remove('error');
        } else {
            inputElement.classList.add('error');
        }
    });
}