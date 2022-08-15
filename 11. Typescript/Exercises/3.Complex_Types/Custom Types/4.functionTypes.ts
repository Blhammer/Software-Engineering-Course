// Math Operations
function add(a: any, b: any) {
    return a + b;
}
function subtract(a: number, b: number) {
    return a - b;
}
function multiply(a: number, b: number) {
    return a * b;
}
function divide(a: number, b: number) {
    return a / b;
}
function wrongAdd(a: string, b: string) {
    return a + b + "";
}

// Add your function type below:
type OperatorFunction = (a: number, b: number) => number;

// Math Tutor Function That Accepts a Callback
function mathTutor(operationCallback: OperatorFunction) {
    console.log("Let's learn how to", operationCallback.name, "!");
    let value25 = operationCallback(2, 5);
    console.log(
        "When we",
        operationCallback.name,
        "2 and 5, we get",
        value25,
        "."
    );
    console.log(
        "When we",
        operationCallback.name,
        value25,
        "and 7, we get",
        operationCallback(value25, 7),
        "."
    );
    console.log("Now fill out this worksheet.");
}

// Call your functions below:
mathTutor(multiply);
