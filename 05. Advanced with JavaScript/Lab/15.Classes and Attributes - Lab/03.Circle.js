class Circle {
    constructor(radius) { 
        this.radius = radius; 
    }
    
    //property getter
    get diameter() { 
        return 2 * this.radius; 
    }
    
    //property setter
    set diameter(value) {
        this.radius = value / 2;
    }

    //read-only property area
    get area() {
        return Math.PI * (this.radius ** 2);
    }
}
let c = new Circle(2);
console.log(`Radius: ${c.radius}`);
console.log(`Diameter: ${c.diameter}`);
console.log(`Area: ${c.area}`);

c.diameter = 1.6;
console.log(`Radius: ${c.radius}`);
console.log(`Diameter: ${c.diameter}`);
console.log(`Area: ${c.area}`);