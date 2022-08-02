function subtract() {
    let firstNum = document.getElementById('firstNumber');
    let secondNum = document.getElementById('secondNumber');

    let subtraction = Number(firstNum.value) - Number(secondNum.value);

    let res = document.getElementById('result');
    res.textContent = subtraction;
}