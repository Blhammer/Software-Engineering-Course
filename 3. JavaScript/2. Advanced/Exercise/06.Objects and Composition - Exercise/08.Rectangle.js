function solve(width, height, color) {
    return rectObj = {
        width,
        height,
        color: color.charAt(0).toUpperCase() + color.substring(1),
        calcArea: () => {
            return Number(width * height);
        },
    }
}

let rect = solve(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());