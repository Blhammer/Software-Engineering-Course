function solve(input, count) {
    while (count !== 0) {
        let lastElement = input.pop();
        input.unshift(lastElement);   
        count--;     
    }

    console.log(input.join(' '));
}
solve(['1',
    '2',
    '3',
    '4'],
    2
);
solve(['Banana',
    'Orange',
    'Coconut',
    'Apple'],
    15
);