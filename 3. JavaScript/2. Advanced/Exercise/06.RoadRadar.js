function solve(speed, area) {
    let currentSpeed = Number(speed);
    let currentArea = area;

    let speedLimit = 0;
    let status = '';
    let output = '';

    if (currentArea === 'residential') {
        speedLimit = 20;
    } else if (currentArea === 'city') {
        speedLimit = 50;
    } else if (currentArea === 'interstate') {
        speedLimit = 90;
    } else if (currentArea === 'motorway') {
        speedLimit = 130;
    }
    
    let differenceSpeed = 0;

    if (currentSpeed <= speedLimit && currentSpeed > 0) {
        output = (`Driving ${currentSpeed} km/h in a ${speedLimit} zone`);
    } else {
        differenceSpeed = currentSpeed - speedLimit;

        if (differenceSpeed<=20) {
            status = 'speeding';
        } else if (differenceSpeed>20 && differenceSpeed<=40) {
            status = 'excessive speeding';
        } else {
            status = 'reckless driving';
        }

        output = `The speed is ${differenceSpeed} km/h faster than the allowed speed of ${speedLimit} - ${status}`;
    }

    console.log(output);
};
solve(40, 'city');
solve(21, 'residential');
solve(120, 'interstate');
solve(200, 'motorway');