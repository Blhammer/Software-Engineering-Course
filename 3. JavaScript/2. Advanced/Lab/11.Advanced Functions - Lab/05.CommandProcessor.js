function solve() {
    let str = '';
    
    return {
        append: (currentStr) => str += currentStr,
        removeStart: (num) => str = str.substring(num),
        removeEnd: (num) => str = str.substring(0, str.length - num),
        print: () => console.log(str)
    }
}
let firstZeroTest = solve();
firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.removeStart(3);
firstZeroTest.removeEnd(4);
firstZeroTest.print();

console.log('-----');

let secondZeroTest = solve();
secondZeroTest.append('123');
secondZeroTest.append('45');
secondZeroTest.removeStart(2);
secondZeroTest.removeEnd(1);
secondZeroTest.print();