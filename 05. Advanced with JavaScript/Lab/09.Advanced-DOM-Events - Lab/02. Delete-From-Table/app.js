function deleteByEmail() {
    let emailInputElement = document.querySelector('input[name="email"]');
    let emailCellElements = document.querySelectorAll('tr td:nth-of-type(2)');
    let resultElement = document.getElementById('result');

    let emailElements = Array.from(emailCellElements);
    let targetElement = emailElements.find(x => x.textContent == emailInputElement.value)

    if (targetElement) {
        targetElement.parentElement.remove();
        resultElement.textContent = 'Deleted.';
    } else {
        resultElement.textContent = 'Not found.';
    }
}