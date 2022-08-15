const batteryStatus: boolean | number = false;

batteryStatus.toString(); // No TypeScript error
//batteryStatus.toFixed(2); // TypeScript error

type Goose = {
    isPet: boolean;
    hasFeathers: boolean;
    canThwartAPicnic: boolean;
};

type Moose = {
    isPet: boolean;
    hasHoofs: boolean;
};

//const pettingZooAnimal: Goose | Moose = { isPet: true };

//console.log(pettingZooAnimal.isPet); // No TypeScript error
//console.log(pettingZooAnimal.hasHoofs); // TypeScript error
//

//
type Like = {
    username: string;
    displayName: string;
};

type Share = {
    username: string;
    displayName: string;
};

function getFriendNameFromEvent(event: Like | Share) {
    return event.displayName || event.username;
}

const newEvent = {
    username: "vkrauss",
    displayName: "Veronica Krauss",
};

const friendName = getFriendNameFromEvent(newEvent);

console.log(`You have an update from ${friendName}.`);
