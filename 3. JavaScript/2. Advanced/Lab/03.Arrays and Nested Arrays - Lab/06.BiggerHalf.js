function solve(input) {
    let inputArr = input.sort((a, b) => a - b);
    const middle = Math.floor(inputArr.length / 2);
    let solution = inputArr.slice(middle);

    return solution;
}
solve([4, 7, 2, 5]);
solve([3, 19, 14, 7, 2, 19, 6]);