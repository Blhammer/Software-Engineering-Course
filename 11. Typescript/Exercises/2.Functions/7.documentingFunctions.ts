/**
 * Returns the sum of two numbers.
 *
 * @param x - The first input number
 * @param y - The second input number
 * @returns The sum of `x` and `y`
 *
 */

function getSum(x: number, y: number): number {
    return x + y;
}

/**
 * Prints a concatenation of strings
 * @param fruit1 - The first parameter
 * @param fruit2 - The second parameter
 * @returns In this case, nothing
 */
function makeFruitSalad(fruit1: string, fruit2: string): void {
    let salad = fruit1 + fruit2 + fruit2 + fruit1 + fruit2 + fruit1 + fruit1;
    console.log(salad);
}

/**
 * Prints the user's status
 * @param status - The first parameter
 * @param repeat - The second parameter
 * @returns In this case, nothing
 */
function proclaim(status = "not ready...", repeat = 1) {
    for (let i = 0; i < repeat; i += 1) {
        console.log(`I'm ${status}`);
    }
}
