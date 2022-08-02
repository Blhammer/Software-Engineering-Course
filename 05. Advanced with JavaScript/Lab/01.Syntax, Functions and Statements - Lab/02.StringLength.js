function solve(arr1, arr2, arr3) {
    let sumLength;
    let averageLength;

    let firstString = arr1.length;
    let secondString = arr2.length;
    let thirdString = arr3.length;

    sumLength = firstString + secondString + thirdString;
    averageLength = Math.floor(sumLength / 3);

    console.log(sumLength);
    console.log(averageLength);
}
solve('chocolate', 'ice cream', 'cake');
solve('pasta', '5', '22.3');