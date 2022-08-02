function solve(input) {
    let size;
    let space = '';

    if (input == undefined) {
        size = 5;
    } else {
        size = input;
    }

    for (let i = 0; i < size; i++) {
        for (let j = 0; j < size; j++) {
            space += '*' + ' ';
        }
        space += '\n';
    }

    console.log(space);
}
solve(1);
solve(2);
solve(5);
solve(7);
solve();