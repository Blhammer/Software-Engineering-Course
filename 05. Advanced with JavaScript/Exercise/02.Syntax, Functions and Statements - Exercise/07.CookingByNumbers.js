function solve(n, a, b, c, d, e) {
    let number = Number(n);
    let arr = [a, b, c, d, e];
    arr = arr.reverse();
    
    while (arr.length != 0) {
        let command = arr.pop();

        if (command === 'chop') {
            number = number / 2;
        } else if (command == 'dice') {
            number = Math.sqrt(number);
        } else if (command == 'spice') {
            number = number + 1;
        } else if (command == 'bake') {
            number = number * 3;
        } else if (command == 'fillet') {
            number = number - (number * 0.20);
        }
        console.log(number);
    }
}
solve("32", "chop", "chop", "chop", "chop", "chop");
solve("9", "dice", "spice", "chop", "bake", "fillet");