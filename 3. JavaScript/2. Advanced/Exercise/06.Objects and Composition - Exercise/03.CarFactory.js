function solve(inputObj) {
    let result = {};
    let engine = {};
    let carriage = {};

    result.model = inputObj.model;

    if (inputObj.power <= 90) {
        engine.power = 90;
        engine.volume = 1800;
    } else if (inputObj.power <= 120) {
        engine.power = 120;
        engine.volume = 2400;
    } else if (inputObj.power > 120) {
        engine.power = 200;
        engine.volume = 3500;
    }

    carriage.type = inputObj.carriage;
    carriage.color = inputObj.color;

    if (inputObj.wheelsize % 2 === 0) {
        inputObj.wheelsize--;
    }

    result.engine = engine;
    result.carriage = carriage;
    result.wheels = [
        inputObj.wheelsize,
        inputObj.wheelsize,
        inputObj.wheelsize,
        inputObj.wheelsize,
    ];

    return result;
}
console.log(solve({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}
));
console.log(solve({
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17
}
));