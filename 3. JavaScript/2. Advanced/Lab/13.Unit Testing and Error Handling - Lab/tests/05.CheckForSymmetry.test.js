const { expect } = require('chai');
const isSymmetric = require('../05.CheckForSymmetry');

describe('Check for symmetry', () => {
    it('Take non-array as an argument', () => {
        expect(isSymmetric('Hello, boy!')).to.be.false;
        expect(isSymmetric(45)).to.be.false;
        expect(isSymmetric('a' + 'b')).to.be.false;
    });
    it('Return true if the input array is symmetric with numbers', () => {
        expect(isSymmetric([1, 4, 5, 4, 1])).to.be.true;
        expect(isSymmetric([6, 14, 15, 14, 6])).to.be.true;
    });
    it('Return true if the input array is symmetric with strings', () => {
        expect(isSymmetric(['a', 'q', 'k', 'q', 'a'])).to.be.true;
        expect(isSymmetric(['s', 'h', 'm', 'e', 'm', 'h', 's'])).to.be.true;
    });
    it('Return false if the input array is not symmetric with strings', () => {
        expect(isSymmetric(['a', 'l', 'k', 'o', 'a'])).to.be.false;
        expect(isSymmetric(['s', 'h', 'a', 'e', 'm', 'u', 's'])).to.be.false;
        expect(isSymmetric([1, 8, 0, 2, 0, 7, 1])).to.be.false;
    });
    it('Return false if the input array is symmetric with different data types', () => {
        expect(isSymmetric(['a', '57', 'k', 57, 'a'])).to.be.false;
        expect(isSymmetric(['200', 'h', 'a', 'e', 'm', 'u', 200])).to.be.false;
        expect(isSymmetric([1, 5, 8, '5', 1])).to.be.false;
    });
});