function solve(steps, lengthOfFootprint, speed) {
    let currentSteps = Number(steps);
    let currentLengthOfFootprint = Number(lengthOfFootprint);
    let currentSpeed = Number(speed);

    let convertedSpeed = currentSpeed * (1000 / 3600);
    let distance = currentSteps * currentLengthOfFootprint;
    let time = distance / convertedSpeed;
    
    //Every 500 meters the student rests and takes a 1-minute break
    let distanceBreakTime = 500;
    let sumBreakTime = Math.floor(distance / distanceBreakTime);

    let hours = Math.floor(time / 3600);
    let minutes = Math.floor((time % 3600) / 60);
    let seconds = Math.ceil((time % 3600) % 60);
    
    console.log((hours < 10 ? "0" : "") + hours + ":" + 
        (minutes + sumBreakTime < 10 ? "0" : "") + (minutes + sumBreakTime) + ":" + 
        (seconds < 10 ? "0" : "") + seconds);
}
solve(4000, 0.60, 5);
solve(2564, 0.70, 5.5);