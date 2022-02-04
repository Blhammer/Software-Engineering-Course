function solve(inputArr) {
    let food = '{ ';

    for (let i = 0; i < inputArr.length; i+=2) {
        let propKey = inputArr[i];
        let propValue = inputArr[i + 1];
        
        food += `"${propKey}" : ${propValue}`;

        if (inputArr[i + 2] != undefined) {
            food += ', ';
        } else {
            food += ' ';
        }
    }

    food += '}';
    console.log(JSON.parse(food));
}
solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
solve(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);