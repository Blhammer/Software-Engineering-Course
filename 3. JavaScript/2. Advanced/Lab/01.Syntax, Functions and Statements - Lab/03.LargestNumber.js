function solve(a, b, c) {
    if (a > b && a > c) {
        console.log(`The largest number is ${a}.`);
    } else if (b > a && b > c) {
        console.log(`The largest number is ${b}.`);
    } else {
        console.log(`The largest number is ${c}.`);
    }
}
solve(5, -3, 16);
solve(-3, -5, -22.5);