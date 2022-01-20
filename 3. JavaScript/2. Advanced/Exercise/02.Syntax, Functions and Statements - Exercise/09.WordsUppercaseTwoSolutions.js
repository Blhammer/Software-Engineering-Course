function solve(text) {
    let result = text
        .toUpperCase()
        .split(/[\W]+/g) //without /g only the first word will be used
        .filter((w) => w.length > 0)
        .join(", ");

    console.log(result);
}

function solve(input) {
    let result = input.toUpperCase().match(/\w+/g).join(", ");

    console.log(result);
}

solve("Hi, how are you?");
solve("hello");