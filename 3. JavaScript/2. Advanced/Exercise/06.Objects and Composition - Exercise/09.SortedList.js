function solve() {
    const sortedArr = [];

    return {
        add(element) {
            sortedArr.push(element);
            sortedArr.sort((a, b) => a - b);
        },
        remove(index) {
            if (index >= 0 && index < sortedArr.length) {
                sortedArr.splice(index, 1);
                sortedArr.sort((a, b) => a - b);
            }
        },
        get(index) {
            if (index < 0 || index >= sortedArr.length) {
                throw new Error(`Index doesn't exist`);
            }
            return sortedArr[index];
        },
        get size() {
            return sortedArr.length;
        }
    }
}

let list = solve();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));