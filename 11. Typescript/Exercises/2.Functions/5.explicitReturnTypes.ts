// This code is an example when we’re working with other people’s code
// It is for learning purpose!!!

// Note: resources file is not given so there would be an error if you start the code

import {
    getUserChoice,
    f1,
    f2,
    f3,
    f4,
    f5,
    f6,
    f7,
    f8,
    f9,
    f10,
    f11,
    f12,
} from "./resources";

function returnFruit(): string {
    let num = getUserChoice();
    switch (num) {
        case 1:
            return f1();
        case 2:
            return f2();
        case 3:
            return f3();
        case 4:
            return f4();
        case 5:
            return f5();
        case 6:
            return f6();
        case 7:
            return f7();
        case 8:
            return f8();
        case 9:
        // The problematic function is f9() because it is of type number
        //return f9();
        case 10:
            return f10();
        case 11:
            return f11();
        case 12:
            return f12();
    }
    return "ball.jpg";
}

console.log(returnFruit());
