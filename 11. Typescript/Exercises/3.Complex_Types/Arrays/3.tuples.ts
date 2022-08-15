// fixed sequence of types:
let ourTuple: [string, number, string, boolean] = [
    "Is",
    7,
    "our favorite number?",
    false,
];

// Type Error! if numbersTuple have more or less than three elements.
let numbersTuple: [number, number, number] = [1, 2, 3];

// Type Error! if the elements are not compatible by the given type of the array.
let mixedTuple: [number, string, boolean] = [3, "hi", true];

let tup: [string, string] = ["hi", "bye"];
let arr: string[] = ["there", "there"];
tup = ["there", "there"]; // No Errors.
