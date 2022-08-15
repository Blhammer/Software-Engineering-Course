interface About {
    general: {
        id: number;
        name: string;
        version: {
            versionNumber: number;
        };
    };
}

interface About {
    general: General;
}

interface General {
    id: number;
    name: string;
    version: Version;
}

interface Version {
    versionNumber: number;
}
//

//
interface Directory {
    addFile: (name: string) => void;
    config: Config;
}

interface DefaultConfig {
    encoding: string;
    permissions: string;
}

interface Config {
    default: DefaultConfig;
}

class DesktopDirectoryNew implements Directory {
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

const DesktopNew = new DesktopDirectoryNew();

console.log(DesktopNew.config);
