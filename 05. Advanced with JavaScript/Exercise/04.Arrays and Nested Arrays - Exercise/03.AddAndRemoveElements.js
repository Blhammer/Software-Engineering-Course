function solve(input) {
    let solutionArr = [];
    let currentNumber = 1;

    for (let i = 0; i < input.length; i++) {
        let command = input[i];

        if (command === "add") {
            solutionArr.push(currentNumber);
            currentNumber++;
        } else if (command === "remove") {
            solutionArr.pop();
            currentNumber++;
        }
    }

    if (solutionArr.length === 0) {
        console.log("Empty");
    } else {
        solutionArr.forEach((element) => {
            console.log(element);
        });
    }
}
solve(["add", "add", "add", "add"]);
solve(["add", "add", "remove", "add", "add"]);
solve(["remove", "remove", "remove"]);