let examAnswers = [true, false, false];

examAnswers[3] = true;

let tupleOfExamAnswers: [boolean, boolean, boolean] = [true, false, false];
// tupleOfExamAnswers[3] = true; // Error

let tup1: [number, number, number] = [1, 2, 3];
let concatResult = tup1.concat([4, 5, 6]);

let dogTuple: [string, string, string, string] = [
    "dog",
    "brown fur",
    "curly tail",
    "sad eyes",
];

// Your code goes here:
let myArr = dogTuple.concat("run");

myArr[50] = "not a dog";

console.log(myArr[50]);
