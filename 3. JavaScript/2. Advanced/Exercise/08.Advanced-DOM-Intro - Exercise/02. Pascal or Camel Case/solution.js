function solve() {
    let input = document.getElementById('text').value;
    let currentCase = document.getElementById('naming-convention').value;
    let resultElement = document.getElementById('result');

    let currentText = '';

    input = input.toLowerCase().split(' ');

    if (currentCase === 'Camel Case') {
        currentText += input[0];

        for (let i = 1; i < input.length; i++) {
            input[i] = input[i][0].charAt(0).toUpperCase() + input[i].substring(1);
            currentText += input[i];
        }
    } else if (currentCase === 'Pascal Case') {
        for (let i = 0; i < input.length; i++) {
            input[i] = input[i][0].charAt(0).toUpperCase() + input[i].substring(1);
            currentText += input[i];
        }
    } else {
        currentText = 'Error!';
    }

    resultElement.textContent = currentText;
}