function solve(input) {
    let dayOfTheWeek = input;
    let output;

    switch (dayOfTheWeek) {
        case 'Monday':
            output = 1;
            break;
        case 'Tuesday':
            output = 2;
            break;
        case 'Wednesday':
            output = 3;
            break;
        case 'Thursday':
            output = 4;
            break;
        case 'Friday':
            output = 5;
            break;
        case 'Saturday':
            output = 6;
            break;
        case 'Sunday':
            output = 7;
            break;
        default:
            output = 'error';
            break;
    }
    
    console.log(output);
}
solve('Monday');
solve('Friday');
solve('Invalid');