const { expect } = require('chai');
const lookupChar = require('../03.CharLookup');

describe('Char Lookup', () => {
    it('It returns undefined because of not valid types of the arguments', () => {
        expect(lookupChar(52, 52)).to.equal(undefined);
        expect(lookupChar('Alex', '4')).to.equal(undefined);
        expect(lookupChar(7, 'school')).to.equal(undefined);
    });
    it('It returns "Incorrect index" if the value is not in the range', () => {
        expect(lookupChar('job', 4)).to.equal('Incorrect index');
        expect(lookupChar('job', 3)).to.equal('Incorrect index');
        expect(lookupChar('job', -2)).to.equal('Incorrect index');
    });
    it('It returns the character at the specified index in the string, if it works properly', () => {
        expect(lookupChar('iron', 3)).to.equal('n');
        expect(lookupChar('book', 0)).to.equal('b');
        expect(lookupChar('design', 4)).to.equal('g');
    });
    it('It returns undefined with floating-point numbers', () => {
        expect(lookupChar('iron', 2.7)).to.equal(undefined);
        expect(lookupChar('stone', 42.6)).to.equal(undefined);
    });
});