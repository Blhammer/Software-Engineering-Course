function solve(inputArr) {
    let solutionArr = [inputArr[0]];

    inputArr.reduce((curr, bigger) => {
        let currentPopNumber = solutionArr[solutionArr.length - 1];
        if (bigger >= currentPopNumber) {
            solutionArr.push(bigger);
        }
    });

    return solutionArr;
}
solve([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24]
);
solve([1,
    2,
    3,
    4]
);
solve([20,
    3,
    2,
    15,
    6,
    1]
);