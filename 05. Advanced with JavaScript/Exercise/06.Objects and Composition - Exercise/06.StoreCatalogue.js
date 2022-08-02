function solve(inputArr) {
    inputArr = inputArr.sort((a, b) => a.localeCompare(b));
    let currentCharLetter = '';

    for (const iterator of inputArr) {
        let [productName, productPrice] = iterator.split(' : ');

        if (iterator.charAt(0) !== currentCharLetter)
            console.log(iterator.charAt(0));
        currentCharLetter = iterator.charAt(0);

        console.log(`  ${productName}: ${productPrice}`);
    }
}
solve(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']
);
console.log('----------------------');
solve(['Banana : 2',
    'Rubics Cube : 5',
    'Raspberry P : 4999',
    'Rolex : 100000',
    'Rollon : 10',
    'Rali Car : 2000000',
    'Pesho : 0.000001',
    'Barrel : 10']
);