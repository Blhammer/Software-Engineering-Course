interface Robot {
    identify: (id: number) => void;
}

class OneSeries implements Robot {
    identify(id: number) {
        console.log(`beep! I'm ${id.toFixed(2)}.`);
    }

    answerQuestion() {
        console.log("42!");
    }
}
/*
In the example, there’s an interface named Robot and a class named OneSeries. 
The implements keyword is then used to apply the type Robot to OneSeries.

Notice that Robot has an .identify() method. Since Robot is applied to OneSeries, 
OneSeries must include a method named .identify() that matches the Robot interface. 
Additionally, OneSeries can have methods and properties of its own, like the .answerQuestion() method.

implements and interface allow us to create types that match a variety of class patterns,
 which makes interface a good tool for use on object-oriented programs.
*/

// Write an interface here
interface Directory12 {
    addFile: (name: string) => void;
}

class DesktopDirectory12 implements Directory12 {
    addFile(name: string) {
        console.log(`Adding file: ${name}`);
    }

    showPreview(name: string) {
        console.log(`Opening preview of file: ${name}`);
    }
}

const Desktop = new DesktopDirectory12();

Desktop.addFile("lesson-notes.txt");
Desktop.showPreview("lesson-notes.txt");
