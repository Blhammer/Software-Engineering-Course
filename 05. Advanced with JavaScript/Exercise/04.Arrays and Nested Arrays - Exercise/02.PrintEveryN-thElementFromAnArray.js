function solve(input, number) {
    let solution = [];

    for (let i = 0; i < input.length; i += number) {
        solution.push(input[i]);
    }

    return solution;
}
solve(['5',
        '20',
        '31',
        '4',
        '20'
    ],
    2
);
solve(['dsa',
        'asd',
        'test',
        'tset'
    ],
    2
);
solve(['1',
        '2',
        '3',
        '4',
        '5'
    ],
    6
);