enum Direction {
    North,
    South,
    East,
    West,
}

let whichWayToArcticOcean: Direction;
whichWayToArcticOcean = Direction.North;
whichWayToArcticOcean = Direction.South;
whichWayToArcticOcean = Direction.East;
whichWayToArcticOcean = Direction.West;

let petOnSale = "chinchilla";
let ordersArray = [
    ["rat", 2],
    ["chinchilla", 1],
    ["hamster", 2],
    ["chinchilla", 50],
];

// Write your code below:
enum Pet {
    Hamster,
    Rat,
    Chinchilla,
    Tarantula,
}

const petOnSaleTS: Pet = Pet.Chinchilla;

const ordersArrayTS: [Pet, number][] = [
    [Pet.Rat, 2],
    [Pet.Chinchilla, 1],
    [Pet.Hamster, 2],
    [Pet.Chinchilla, 50],
];
//ordersArrayTS.push([Pet.Jerboa, 3]);

//
// String Enums vs. Numeric Enums
//

let petOnSale1 = "chinchilla";
let ordersArray1 = [
    ["rat", 2],
    ["chinchilla", 1],
    ["hamster", 2],
    ["chinchilla", 50],
];

// Write your code below:
enum Pet {
    Hamster1 = "HAMSTER",
    Rat1 = "RAT",
    Chinchilla1 = "CHINCHILLA",
    Tarantula1 = "TARANTULA",
}

const petOnSaleTS1: Pet = Pet.Chinchilla;

let ordersArrayTS1: [Pet, number][] = [
    [Pet.Rat, 2],
    [Pet.Chinchilla, 1],
    [Pet.Hamster, 2],
    [Pet.Chinchilla, 50],
];

//ordersArrayTS.push(["HAMSTER", 1]); // It is not assignable to type 'Pet'
