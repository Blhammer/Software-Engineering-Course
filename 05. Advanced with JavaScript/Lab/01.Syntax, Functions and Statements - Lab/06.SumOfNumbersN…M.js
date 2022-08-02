function solve(a, b) {
    let num1 = Number(a);
    let num2 = Number(b);
    let output = 0;
    
    for (let i = num1; i <= num2; i++) {
        output += i;
    }
     
    console.log(output);
}
solve('1', '5');
solve('-8', '20');