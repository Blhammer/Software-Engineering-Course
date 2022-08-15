let ID: string | number;

ID = 1;
ID = "01";

console.log(`The ID is ${ID}.`);

function getMarginLeft(margin: string | number) {
    return { marginLeft: margin };
}

function printNumbersAndStrings(statement: string | number) {
    console.log(`ℹ️ LOG:: ${statement}`);
}

printNumbersAndStrings(1234);
printNumbersAndStrings("hello!");
