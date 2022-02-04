function solve(a, b) {
    let width = a;
    let height = b;

    let counter = 1;
    let startCol = 0;
    let endCol = height - 1;
    let startRow = 0;
    let endRow = height - 1;

    let matrix = [];

    for (let i = 0; i < width; i++) {
        matrix.push([]);
    }

    while (startCol <= endCol && startCol <= endRow) {
        //*Top row
        for (let i = startCol; i <= endCol; i++) {
            matrix[startRow][i] = counter;
            counter++;
        }
        startRow++;

        //*Right col
        for (let i = startRow; i <= endRow; i++) {
            matrix[i][endCol] = counter;
            counter++;
        }
        endCol--;

        //*Bottom row
        for (let i = endCol; i >= startCol; i--) {
            matrix[endRow][i] = counter;
            counter++;
        }
        endRow--;

        //*Left col
        for (let i = endRow; i >= startRow; i--) {
            matrix[i][startCol] = counter;
            counter++;
        }
        startCol++;
    }

    console.log(matrix.map(row => row.join(" ")).join("\n"));
}
solve(5, 5);
solve(3, 3);