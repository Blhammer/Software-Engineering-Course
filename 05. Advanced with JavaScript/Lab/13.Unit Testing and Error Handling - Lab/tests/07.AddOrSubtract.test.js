const { expect } = require('chai');
const createCalculator = require('../07.AddOrSubtract');

describe('Name of the project', () => {
    it('return an object from the function', () => {
        expect(typeof createCalculator()).to.equal('object');
    });
    it('It should contains the functions add(), subtract() and get() as properties', () => {
        const object = createCalculator();
        expect(object).haveOwnProperty('add');
        expect(object).haveOwnProperty('subtract');
        expect(object).haveOwnProperty('get');
    });
    it('Functionality of add()', () => {
        const object = createCalculator();
        object.add(1);
        object.add(2);
        object.add(6);
        expect(object.get()).to.equal(9);
        object.add(7);
        expect(object.get()).to.equal(16);
    });
    it('Functionality of subtract()', () => {
        const object = createCalculator();
        object.add(54);
        object.subtract(4);
        expect(object.get()).to.equal(50);
        object.subtract(35);
        expect(object.get()).to.equal(15);
    });
    it('Functionality of get()', () => {
        const object = createCalculator();
        object.add(100);
        expect(object.get()).to.equal(100);
    });
    it('Functionality of add() and subtract() works with either a number or a string containing a number', () => {
        const object = createCalculator();
        object.add('5');
        object.add('10');
        object.subtract(4);
        expect(object.get()).to.equal(11);
    });
    it('It returns the value of the internal sum, if it is not either a number or string, it returns NaN', () => {
        const object = createCalculator();
        object.add('car');
        expect(Number.isNaN(object.get())).to.be.true;
    });
});