function solve(inputArr) {
    let objCars = {};

    const obj = {
        create,
        createInherit,
        set,
        print
    }

    function create(name) {
        objCars[name] = {};
    }

    function createInherit(name, nameToInherit) {
        create(name);
        let carObj = objCars[name];
        carObj = Object.setPrototypeOf(carObj, objCars[nameToInherit]);
    }

    function set(name, key, val) {
        objCars[name][key] = val;
    }

    function print(name) {
        let print = '';
        const carToPrint = objCars[name];
        
        for (const car in carToPrint) {
            print += `${car}:${carToPrint[car]},`;
        }

        console.log(print.slice(0, -1));
    }

    inputArr.forEach(commandLine => {
        const commandArgs = commandLine.split(' ');

        const command = commandArgs[0];
        const name = commandArgs[1];

        switch (command) {
            case 'create':
                if (commandArgs[2]) {
                    const nameToInheritFrom = commandArgs[3];
                    obj.createInherit(name, nameToInheritFrom);
                } else {
                    obj.create(name);
                }
                break;
            case 'set':
                const key = commandArgs[2];
                const value = commandArgs[3];
                obj.set(name, key, value);
                break;
            case 'print':
                obj.print(name);
                break;
        }
    });
}
solve(['create c1',
    'create c2 inherit c1',
    'set c1 color red',
    'set c2 model new',
    'print c1',
    'print c2']
);