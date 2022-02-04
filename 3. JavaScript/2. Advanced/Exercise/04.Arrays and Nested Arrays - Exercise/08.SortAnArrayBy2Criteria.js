function solve(input) {
    input.sort((a, b) => a.localeCompare(b))
    input.sort((a, b) => a.length - b.length);

    input.forEach(element => {
        console.log(element);
    });
}
solve(['alpha',
    'beta',
    'gamma']
);
solve(['Isacc',
    'Theodor',
    'Jack',
    'Harrison',
    'George']
);
solve(['test',
    'Deny',
    'omen',
    'Default']
);