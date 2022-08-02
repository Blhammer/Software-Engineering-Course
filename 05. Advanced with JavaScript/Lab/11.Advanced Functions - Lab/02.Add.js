function solve(n) {
    function add(a, b) {
        return a + b;
    }

    let currentNumber = add.bind(this, n);// return (n) => add(n, currentNumber); 
    return currentNumber;
}

let add5 = solve(5);
console.log(add5(2));
console.log(add5(3));

console.log('----');

let add7 = solve(7);
console.log(add7(2));
console.log(add7(3));