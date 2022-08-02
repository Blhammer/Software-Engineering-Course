function solve(inputArr) {
    let width = inputArr[0];
    let height = inputArr[1];
    let x = inputArr[2];
    let y = inputArr[3];

    let matrix = [];

    //Creating the matrix with the given dimensions 
    for (let i = 0; i < width; i++) {
        matrix.push([]);
    }

    //Given inputs' coordinates data of (x, y) are the starting point and always are equal to 1
    for (let row = 0; row < width; row++) {
        for (let col = 0; col < height; col++) {
            matrix[row][col] = (Math.max(Math.abs(row - x), Math.abs(col - y)) + 1);
        }                                                            
    }

    printMatrix(matrix);

    function printMatrix(matrix) {
        for (var i = 0; i < matrix.length; i++) {
            console.log(matrix[i].join(' '));
        }
    }
}
solve([4, 4, 0, 0]);
solve([5, 5, 2, 2]);
solve([3, 3, 2, 2]);