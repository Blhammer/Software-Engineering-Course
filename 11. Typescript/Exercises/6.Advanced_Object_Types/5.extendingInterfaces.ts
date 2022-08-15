interface Shape {
    color: string;
}

interface Square extends Shape {
    sideLength: number;
}

const mySquare: Square = { sideLength: 10, color: "blue" };

interface Developer extends Human1 {
    code: () => void;
}

interface Human1 {
    name: string;
    hobbies: string[];
}

const me: Developer = {
    code: () => console.log("Headphones on. Coffee brewed. Editor open."),
    name: "Bob",
    hobbies: ["Building rockets"],
};

me.code();
