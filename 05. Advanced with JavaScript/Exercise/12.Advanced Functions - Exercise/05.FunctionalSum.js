function add(numberParam) {
    let sum = 0;

    function innerFunction(num) {
        sum += num;
        return innerFunction;
    }

    innerFunction.toString = () => {
        return sum;
    }

    return innerFunction(numberParam);
}
console.log(add(1).toString());
console.log(add(1)(6)(-3).toString());