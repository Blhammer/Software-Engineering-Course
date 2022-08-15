function getFilledArray<T>(value: T, n: number): T[] {
    return Array(n).fill(value);
}

let stringArray: string[];
let numberArray: number[];
let personArray: { name: string; age: number }[];
let coordinateArray: [number, number][];

stringArray = getFilledArray<string>("Run", 123);
numberArray = getFilledArray<number>(1, 2);
personArray = getFilledArray<{ name: string; age: number }>(
    { name: "Bob", age: 12 },
    21
);
coordinateArray = getFilledArray<[number, number]>([3, 4], 6);

//if you wanted an array of 4 copies of the tuple ['cheese', true], you would write:
getFilledArray<[string, boolean]>(["cheese", true], 4);
//getFilledArray(value: [string, boolean], n: number): [string, boolean][]
