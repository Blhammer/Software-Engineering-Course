function solve(input) {
    let radius;
    const inputType = typeof input;
    let circleArea;

    if (inputType === "number") {
        radius = input;
        circleArea = Math.PI * radius ** 2;
        console.log(circleArea.toFixed(2));
    } else {
        console.log(
            `We can not calculate the circle area, because we receive a ${inputType}.`
        );
    }
}
solve(5);
solve(`name`);
