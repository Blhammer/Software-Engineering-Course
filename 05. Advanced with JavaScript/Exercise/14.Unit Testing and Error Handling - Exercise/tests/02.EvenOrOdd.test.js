const { expect } = require('chai');
const isOddOrEven = require('../02.EvenOrOdd');

describe('Even or Odd', () => {
    it('Parameters that are not of type string and expecting it to return undefined.', () => {
        expect(isOddOrEven(85)).to.equal(undefined);
        expect(isOddOrEven([5, 1])).to.equal(undefined);
    });
    it('return even if the string is with even length', () => {
        expect(isOddOrEven('Monday')).to.equal('even');
        expect(isOddOrEven('wood')).to.equal('even');
        expect(isOddOrEven('Avengers')).to.equal('even');
    });
    it('return odd if the string is with odd length', () => {
        expect(isOddOrEven('car')).to.equal('odd');
        expect(isOddOrEven('run')).to.equal('odd');
        expect(isOddOrEven('Avenger')).to.equal('odd');
    });
});