class Person {
    constructor(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.fullName = `${this.firstName} ${this.lastName}`;
    }

    get firstName() {
        return this._firstName;
    }

    set firstName(value) {
        this._firstName = value;
        this._fullName = `${this.firstName} ${this.lastName}`;
    }

    get lastName() {
        return this._lastName;
    }

    set lastName(value) {
        this._lastName = value;
        this._fullName = `${this.firstName} ${this.lastName}`;
    }

    get fullName() {
        return this._fullName;
    }

    set fullName(value) {
        let regexMatch = /[\w]+\s[\w]+/g;

        if (regexMatch.test(value)) {
            let [firstNameValue, lastNameValue] = value.split(' ');
            this._fullName = `${this.firstName} ${this.lastName}`;
            this.firstName = firstNameValue;
            this.lastName = lastNameValue;
        }
    }
}

/*
let person = new Person("Albert", "Simpson");
console.log(person.fullName);
person.firstName = "Simon";
console.log(person.fullName);
person.fullName = "Peter";
console.log(person.firstName);
console.log(person.lastName);

///Expected output:

///Albert Simpson
///Simon Simpson
///Simon
///Simpson
*/


/*
let person = new Person("Peter", "Ivanov");
console.log(person.fullName);
person.firstName = "George";
console.log(person.fullName);
person.lastName = "Peterson";
console.log(person.fullName);
person.fullName = "Nikola Tesla";
console.log(person.firstName);
console.log(person.lastName);

///Expected output:

///Peter Ivanov
///George Ivanov
///George Peterson
///Nikola
///Tesla
*/