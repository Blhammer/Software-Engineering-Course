function solve(a, b, operation) {
    let num1 = a;
    let num2 = b;
    let arithmeticOperator = operation;
    let result;

    switch (arithmeticOperator) {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            result = num1 / num2;
            break;
        case '%':
            result = num1 % num2;
            break;
        case '**':
            result = num1 ** num2;
            break;
        default:
            break;
    }
    console.log(result);
}
solve(5, 6, '+');
solve(3, 5.5, '*');