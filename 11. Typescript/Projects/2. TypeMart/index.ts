import products from "./products";

const productName: string = "shirt";
let shipping: number = 0;
let taxPercent: number = 0;
let taxTotal: number = 0;
let total: number = 0;

const shippingAddress: string = "Main Street"; //"575 Broadway, New York City, New York"

const product = products.filter((product) => product.name === productName)[0];

if (product.preOrder === "true") {
    console.log("We will send a message!");
}

if (Number(product.price) >= 25) {
    shipping = 0;
    console.log("Free shipping!");
} else if (Number(product.price) < 25) {
    shipping = 5;
}

if (shippingAddress.match("New York")) {
    taxPercent = 0.1;
} else {
    taxPercent = 0.05;
}

taxTotal = Number(product.price) * taxPercent;
total = Number(product.price) + taxTotal + shipping;

console.log(`
    Product:  ${product.name}
    Address:  ${shippingAddress}
    Price:    $${product.price}
    Tax:      $${taxTotal.toFixed(2)}
    Shipping: $${shipping.toFixed(2)}
    Total:    $${total.toFixed(2)}
`);
