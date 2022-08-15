let myCoordinates: [number, number, string, number, number, string] = [
    40,
    43.2,
    "N",
    73,
    59.8,
    "W",
];
let bermudaCoordinates: [number, number, string, number, number, string] = [
    25,
    0,
    "N",
    71,
    0,
    "W",
];

function gpsNavigate(
    startLatitudeDegrees: number,
    startLatitudeMinutes: number,
    startNorthOrSouth: string,
    startLongitudeDegrees: number,
    startLongitudeMinutes: number,
    startEastOrWest: string,
    endLatitudeDegrees: number,
    endLatitudeMinutes: number,
    endNorthOrSouth: string,
    endLongitudeDegrees: number,
    endLongitudeMinutes: number,
    endEastOrWest: string
) {}

function performDanceMove(
    moveName: string,
    moveReps: number,
    hasFlair: boolean
): void {
    console.log(`I do the ${moveName} ${moveReps} times !`);
    if (hasFlair) {
        console.log("I do it with flair!");
    }
}

let danceMoves: [string, number, boolean][] = [
    ["chicken beak", 4, false],
    ["wing flap", 4, false],
    ["tail feather shake", 4, false],
    ["clap", 4, false],
    ["chicken beak", 4, true],
    ["wing flap", 4, true],
    ["tail feather shake", 4, true],
    ["clap", 4, true],
];

gpsNavigate(...myCoordinates, ...bermudaCoordinates);
gpsNavigate(...bermudaCoordinates, ...myCoordinates);

danceMoves.forEach((move) => performDanceMove(...move));
