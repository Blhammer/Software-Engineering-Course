//Ctrl+shift+P

function solve(a, b) {
    let currentNumber = a + b;
    console.log(currentNumber);

    let name = `Maria`;
    const age = 35;
    let isOldEnough = true;
    let money = 50000;
    let symbolDollar = `$`;

    //--undefined
    //let y;
    //console.log(y);

    //--undeclared
    //console.log(nameOfThePrince); //ReferenceError: nameOfThePrince is not defined

    //--Used to declare variables:
    //let - allows reassignment
    //const - once assigned it cannot be modified
    //var - defines a variable in the function scope regardless of block scope

    /*--data types
    String
    Number
    Boolean
    undefined
    null
    BigInt
    Symbol
    */
}
solve(220, 450);

/*
//camel case - printStars
function printStars(count) {
    console.log("*".repeat(count));
}
printStars(6);//Invoke the function

//Declaring Functions:
//1.Function declaration:
function walk(printIt) {
    console.log("walking");
}
//2.Function expression:
const walk = function () {
    console.log("walking");
}
//3.Arrow function:
const walk = () => {
    console.log("walking");
}
*/

//--parameters and returned value
//functions can yield a value with the return operator
function identity(param) {
    return param;
}
console.log(identity(5)); //5

function stringLowerCases(a, b, c, d, e) {
    let name = a;
    const age = b;
    let isOldEnough = c;
    let money = d;
    let symbolDollar = e;

    if (age > 30) {
        isOldEnough = false;
        console.log("Old...");
    } else {
        console.log("Okay...");
    }

    if (money >= 50000) {
        console.log(
            `${name} is ${age} years old and has got some money but how exactly: ${money}${symbolDollar}`
        );
    } else {
        console.log(
            `${name} is ${age} years old and has got some money but how exactly: ${money}${symbolDollar}`.toLowerCase()
        );
    }
}
stringLowerCases(`Maria`, 25, false, 5000, `$`);

//--Default Function Parameter Values
//Functions can have default parameter values
function printStarsSecond(count = 5) {
    console.log("*".repeat(count));
}
printStarsSecond(); // *****
printStarsSecond(2); // **
printStarsSecond(3, 5, 8); // *** 5 and 8 are ignored

/*
Addition (+)
Subtraction (-)
Multiplication (*)
Division (/) 15/5=3
Remainder (%) 15/5=0 //without remainder
Exponentiation (**) 5^2=25
*/

/*
    EQUAL value ==
    EQUAL value and type ===
*/

//"truthy" - a value that coerces to true when evaluated in a boolean context
//The following values are "falsy" - false, null, undefined, NaN, 0, 0n and ""
function logTruthiness(val) {
    if (val) {
        console.log("Truthy!");
    } else {
        console.log("Falsy.");
    }
}
logTruthiness(3.14); //Truthy!
logTruthiness({}); //Truthy!
logTruthiness(NaN); //Falsy.
logTruthiness("NaN"); //Truthy!
logTruthiness([]); //Truthy!
logTruthiness(null); //Falsy.
logTruthiness(""); //Falsy.
logTruthiness(undefined); //Falsy.
logTruthiness(0); //Falsy.

/*
const val = !true
console.log(val); // false
const val = !false;
console.log(val); // true
*/

//--Typeof Operator
//The typeof operator returns a string indicating the type of an operand

function printCodeNewLine() {
    let playerName = `Rick`;
    let nameSchool = `Washington`;

    console.log(`${playerName} ${nameSchool} \n`);
}
printCodeNewLine();



