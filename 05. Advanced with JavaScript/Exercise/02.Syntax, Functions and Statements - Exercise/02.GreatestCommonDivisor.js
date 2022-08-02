function solve(a, b) {
    let num1 = a;
    let num2 = b;

    if (typeof num1 !== `number` || typeof num2 !== `number`) {
        return false;
    } else {
        num1 = Math.abs(num1);
        num2 = Math.abs(num2);

        while (num1 != 0) {
            var temp = num1;
            num1 = num2 % num1;
            num2 = temp;
        }

        console.log(num2);
    }
}
solve(15, 5);
solve(2154, 458);