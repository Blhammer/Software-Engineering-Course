function solve(fruit, weight, price) {
    let currentWeight = weight / 1000;
    let currentPrice = price;
    let money = currentWeight * currentPrice;

    console.log(`I need $${money.toFixed(2)} to buy ${currentWeight.toFixed(2)} kilograms ${fruit}.`);
}
solve("orange", 2500, 1.8);
solve("apple", 1563, 2.35);