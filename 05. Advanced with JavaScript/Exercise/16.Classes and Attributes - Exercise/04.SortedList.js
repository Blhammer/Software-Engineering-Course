class List {
    constructor() {
        this.result = []; //every new instance will create a new array
        this.size = this.result.length;
    }

    add(value) {
        this.result.push(value);
        this.size = this.result.length;
        this.result.sort((a, b) => a - b);
    }

    remove(index) {
        if (index < 0 || index >= this.result.length) {
            throw new Error('Invalid index!');
        }

        this.result.splice(index, 1);
        this.size = this.result.length;
    }

    get(index) {
        if (index < 0 || index >= this.result.length) {
            throw new Error('Invalid index!');
        }

        return this.result[index];
    }
}

let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));