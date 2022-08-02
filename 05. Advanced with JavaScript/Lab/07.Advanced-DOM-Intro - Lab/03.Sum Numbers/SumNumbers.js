function calc() {
    let number_1 = document.getElementById('num1');
    let number_2 = document.getElementById('num2');

    let currentSum = Number(number_1.value) + Number(number_2.value);

    let result = document.getElementById('sum');
    result.value = currentSum;
}