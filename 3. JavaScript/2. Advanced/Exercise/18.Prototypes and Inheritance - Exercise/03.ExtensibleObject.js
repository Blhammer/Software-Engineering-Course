function extensibleObject() {
    return {
        extend(template) {
            for (const [key, value] of Object.entries(template)) {
                if (typeof value === 'function') {
                    Object.getPrototypeOf(this)[key] = value;
                } else {
                    this[key] = value;
                }
            }
        }
    }
}

//It should return the extensible object instance.
//The extend() function of the object will receive a valid object as an input parameter and has no output.

//Output:
const myObj = extensibleObject();

const template = {
    extensionMethod: function () { },
    extensionProperty: 'someString'
}
myObj.extend(template);

console.log(template);