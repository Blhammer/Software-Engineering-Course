function solve(input) {
    input.sort((a, b) => a - b);
    let solutionArr = [];
    
    while (input.length != 0) {
        let smallestNum = input.shift();
        let biggestNum = input.pop();
        
        solutionArr.push(smallestNum);        
        solutionArr.push(biggestNum);        
    }

    return solutionArr;
}
solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);