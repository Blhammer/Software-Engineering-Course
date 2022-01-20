function solve(input) {
    let result = input.toUpperCase().match(/\w+/g).join(", ");

    console.log(result);
}
solve("Hi, how are you?");
solve("hello");