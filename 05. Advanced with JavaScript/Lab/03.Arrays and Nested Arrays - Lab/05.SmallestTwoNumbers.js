function solve(input) {
    let currentArr = input.sort((a, b) => b - a);
    
    let a = currentArr.pop();
    let b = currentArr.pop();

    console.log(`${a} ${b}`);
}
solve([30, 15, 50, 5]);
solve([3, 0, 10, 4, 7, 3]); 