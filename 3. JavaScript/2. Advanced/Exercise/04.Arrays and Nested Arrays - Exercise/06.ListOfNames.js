function solve(input) {
    let counter = 0;
    input.sort((a, b) => a.localeCompare(b));

    input.forEach((el) => {
        counter++;
        console.log(`${counter}.${el}`);
    });
}
solve(["John", "Bob", "Christina", "Ema"]);
solve(["John", "bob", "Christina", "ema"]);