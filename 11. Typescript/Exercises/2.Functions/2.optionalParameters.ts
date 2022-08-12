function proclaim1(status?: string) {
    console.log(`I'm ${status || "not ready..."}`);
}

function greet(greeting: string, name?: string) {
    return greeting + " " + (name || "neighbor") + "!";
}

proclaim1();
proclaim1("ready?");
proclaim1("ready!");

greet("Hi");
greet("Bob, hello");
greet("Hello", "Bob");
