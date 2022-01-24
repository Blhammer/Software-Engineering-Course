function solve(input) {
    let neighbors = 0;
 
    for (let row = 0; row < input.length - 1; row++) {
        for (let col = 0; col < input[row].length; col++) {
            if (input[row][col] == input[row + 1][col]) {
                neighbors++;
            }
            if (input[row][col] == input[row][col + 1]) {
                neighbors++;
            }
            if (row == input.length - 2 && 
                input[row + 1][col] == input[row + 1][col + 1]) {
                neighbors++;
            }
        }
    }
    return neighbors;
}
solve([['2', '3', '4', '7', '0'],
['4', '0', '5', '3', '4'],
['2', '3', '5', '4', '2'],
['9', '8', '7', '5', '4']]
);
solve([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']]
);