function solve(input) {
    let arr = input.map(i => Number(i));
    
    let firstNum = arr.shift();
    let lastNum = arr.pop();

    let sum = firstNum + lastNum;

    return sum;
}
solve(['20', '30', '40']);
solve(['5', '10']);