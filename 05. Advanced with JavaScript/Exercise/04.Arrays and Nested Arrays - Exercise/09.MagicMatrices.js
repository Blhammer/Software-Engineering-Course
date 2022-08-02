function solve(magicMatrix) {
    let rowSum = magicMatrix[0].reduce((a, b) => a + b);
    let colSum = 0;

    magicMatrix.forEach(row => {
        colSum += row[0];
    });

    let isMagicalMatrix = true;

    for (let i = 0; i < magicMatrix.length; i++) {
        let currentRow = magicMatrix[i].reduce((acc, item) => acc + item);
        let currentCol = 0;

        for (let j = 0; j < magicMatrix.length; j++) {
            let currentSum = magicMatrix[j][i];
            currentCol += currentSum;
        }

        if (currentRow !== rowSum || currentCol !== colSum) {
            isMagicalMatrix = false;
          	break;
        }
    }
    console.log(isMagicalMatrix);
}
solve([
    [4, 5, 6],
    [6, 5, 4],
    [5, 5, 5],
]);
solve([
    [11, 32, 45],
    [21, 0, 1],
    [21, 1, 1],
]);
solve([
    [1, 0, 0],
    [0, 0, 1],
    [0, 1, 0],
]);