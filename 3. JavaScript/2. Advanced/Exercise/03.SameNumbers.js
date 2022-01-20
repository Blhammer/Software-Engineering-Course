function solve(input) {
    let n = Number(input);
    let sum = 0;
    let isSame = true;
    let tempDigit = n % 10;
    let currentDigit = 0;

    while (n != 0) {
        currentDigit = n % 10;
        sum += currentDigit;
    
        if (currentDigit !== tempDigit)
            isSame = false;
        n = Math.floor(n / 10);
    }

    if (isSame) {
        console.log(`true`);
    } else {
        console.log(`false`);
    }

    console.log(sum);
}
solve(62222);
solve(`1111`);
solve(2222222);
solve(1234);
solve(0000);