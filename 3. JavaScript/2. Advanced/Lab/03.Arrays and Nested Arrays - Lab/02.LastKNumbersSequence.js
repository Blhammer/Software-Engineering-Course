function solve(n, k) {
    let arr = new Array(n);
    arr[0] = 1;

    for (let i = 1; i < n; i++) {
        let currNumber = i - 1;
        let count = 0;
        let sum = 0;

        while (currNumber >= 0 && count < k) {
            sum += arr[currNumber];
            currNumber--;
            count++;
        }

        arr[i] = sum;
    }

    return arr;
}
solve(6, 3);
solve(8, 2);