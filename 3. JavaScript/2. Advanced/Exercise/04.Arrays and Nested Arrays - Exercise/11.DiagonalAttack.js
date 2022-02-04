function solve(inputMatrix) {
    let matrix = inputMatrix.map(
        row => row.split(' ').map(Number)
    );

    let firstDiagonalSum = 0;
    let secondDiagonalSum = 0;

    let firstIndex = 0;
    let secondIndex = matrix[0].length - 1;

    matrix.forEach((array) => {
        firstDiagonalSum += array[firstIndex++];
        secondDiagonalSum += array[secondIndex--];
    });

    if (firstDiagonalSum == secondDiagonalSum) {
        for (var row = 0; row < matrix.length; row++) {
            for (var col = 0; col < matrix.length; col++) {
                if (row != col && row != matrix.length - 1 - col) {
                    matrix[row][col] = firstDiagonalSum;
                }
            }
        }
        printMatrix(matrix);
    } else {
        printMatrix(matrix);
    }

    function printMatrix(matrix) {
        for (var i = 0; i < matrix.length; i++) {
            console.log(matrix[i].join(' '));
        }
    }
}
solve(['5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1']
);
solve(['1 1 1',
    '1 1 1',
    '1 1 0']
);