type Tennis = {
    serve: () => void;
};

type Soccer = {
    kick: () => void;
};

// The in operator checks if a property exists on an object itself or
// anywhere within its prototype chain:
function play(sport: Tennis | Soccer) {
    if ("serve" in sport) {
        return sport.serve();
    }

    if ("kick" in sport) {
        return sport.kick();
    }
}

type Cat = {
    name: string;
    run: () => string;
};

type Fish = {
    name: string;
    swim: () => string;
};

const siameseCat = {
    name: "Proxie",
    run: () => "pitter pat",
};

const bettaFish = {
    name: "Neptune",
    swim: () => "bubble blub",
};

function move(pet: Cat | Fish) {
    if ("run" in pet) {
        return pet.run();
    } else if ("swim" in pet) {
        return pet.swim();
    }
}

console.log(move(siameseCat));
