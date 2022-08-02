function solve(inputArr) {
    let collection = [];

    const obj = {
        add,
        remove,
        print
    }

    function add(str) {
        collection.push(str);
    }

    function remove(str) {
        collection = collection.filter(x => x !== str);
    }

    function print() {
        console.log(collection.join(','));
    }

    inputArr.forEach(commandLine => {
        const commandArgs = commandLine.split(' ');
        
        const command = commandArgs[0];
        const item = commandArgs[1];

        switch (command) {
            case "add":
                obj.add(item);
                break;
            case "remove":
                obj.remove(item);
                break;
            case "print":
                obj.print();
                break;
        }
    });
}
solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);
console.log('------');
solve(['add pesho', 'add george', 'add peter', 'remove peter', 'print']);