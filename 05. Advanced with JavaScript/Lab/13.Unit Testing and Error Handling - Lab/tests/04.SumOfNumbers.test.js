const { expect } = require('chai');
const sum = require('../04.SumOfNumbers');

describe('Sum of Numbers', () => {
    it('It sums all of the elements in the array properly', () => {
        expect(sum([4, 3, 7])).to.equal(14);
    })
    it('sums the array elements properly with negative number', () => {
        expect(sum([4, -3, 7])).to.equal(8);
    })
    it('sums the array elements properly with 0', () => {
        expect(sum([4, 3, 0])).to.equal(7);
    })
});