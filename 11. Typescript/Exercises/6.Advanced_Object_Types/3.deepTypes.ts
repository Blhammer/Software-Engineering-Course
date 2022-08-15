interface Robot1 {
    about: {
        general: {
            id: number;
            name: string;
        };
    };

    getRobotId: () => string;
}

class OneSeries1212 implements Robot1 {
    about;

    constructor(props: { general: { id: number; name: string } }) {
        this.about = props;
    }

    getRobotId() {
        return `ID: ${this.about.general.id}`;
    }
}

interface Directory {
    addFile: (name: string) => void;

    // Define a config type member here
    config: {
        default: {
            encoding: string;
            permissions: string;
        };
    };
}

class DesktopDirectory1 implements Directory {
    config = {
        default: {
            encoding: "utf-8",
            permissions: "drw-rw-rw-",
        },
    };

    addFile(name: string) {
        console.log(`Adding file: ${name}`);
    }

    showPreview(name: string) {
        console.log(`Opening preview of file: ${name}`);
    }
}

const Desktop1 = new DesktopDirectory1();

console.log(Desktop1.config);
