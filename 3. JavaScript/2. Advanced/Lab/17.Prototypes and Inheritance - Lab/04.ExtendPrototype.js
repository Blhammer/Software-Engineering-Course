function extendPrototype(classToExtend) {
    classToExtend.prototype.species = 'Human';

    classToExtend.prototype.toSpeciesString = function() {
        return `I am a ${this.species}. ${this.toString()}`;
    }
}

//I had to write a function that receives a class and attaches to it a property species with the value 'Human' and a function toSpeciesString(). 
//When called, the function returns a specific string

//This function will receive a class whose prototype it should extend. 
//There is no output, your function should only attach the properties to the given class’ prototype

/*
result(Person);
let result = new Person('Peter', 'email@hit.bg');
expect(result.species).to.equal('Human', 'No species property');
expect(result.toSpeciesString()).to.equal("I am a Human. Person (name: Peter, email: email@hit.bg)");
*/

/*
result1(Person);
let result1 = new Teacher('Peter' ,'imail@hit.bg","Coding');
expect(result1.species).to.equal('Human','No species property');
expect(result1.toSpeciesString()).to.equal('I am a Human. Teacher (name: Peter, email: imail@hit.bg, subject: Coding)');
*/