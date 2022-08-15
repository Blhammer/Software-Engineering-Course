let customersArray = [
    "Bob Smith",
    "Bob Sky",
    "Tom Hall",
    3432434,
    "Luke Brain",
    "Kyle Christopher",
    3432435,
    "Katy",
    456745776
];

let val = "qwerty123";

function stringPush(val) {
    if (typeof val === "string") {
        customersArray.push(val);
    }
}

function checkCustomersArray() {
    customersArray.map((x) => {
        if (typeof x !== "string") {
            console.log(`Type error: ${x} should be a string!`);
        }
    });
}

stringPush(val);

console.log(customersArray);

checkCustomersArray();
