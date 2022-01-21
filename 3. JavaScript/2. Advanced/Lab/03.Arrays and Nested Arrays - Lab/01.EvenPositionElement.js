function solve(inputArray) {
    let result = '';
    
    for (let i = 0; i < inputArray.length; i+=2) {
        result += inputArray[i];
        result += ' ';
    }
    console.log(result);
}
solve(['20', '30', '40', '50', '60']);
solve(['5', '10']);