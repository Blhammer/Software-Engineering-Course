const { expect } = require('chai');
const mathEnforcer = require('../04.MathEnforcer');

describe('Math Enforcer', () => {
    describe('add Five function that accepts single parameter', () => {
        it('If the parameter is a number, add 5 to it, and return the result', () => {
            expect(mathEnforcer.addFive(-5)).to.equal(0);
            expect(mathEnforcer.addFive(0)).to.equal(5);
            expect(mathEnforcer.addFive(10)).to.equal(15);
            expect(mathEnforcer.addFive(25.5)).to.equal(30.5);
        });
        it('If the parameter is not a number, the function should return undefined.', () => {
            expect(mathEnforcer.addFive('-5')).to.equal(undefined);
            expect(mathEnforcer.addFive('hammer')).to.equal(undefined);
            expect(mathEnforcer.addFive([25, 100])).to.equal(undefined);
            expect(mathEnforcer.addFive({})).to.equal(undefined);
        });
    });

    describe('Subtract ten function that accepts single parameter', () => {
        it('If the parameter is a number, subtract 10 from it, and return the result', () => {
            expect(mathEnforcer.subtractTen(-5)).to.equal(-15);
            expect(mathEnforcer.subtractTen(0)).to.equal(-10);
            expect(mathEnforcer.subtractTen(55)).to.equal(45);
            expect(mathEnforcer.subtractTen(-1.5)).to.equal(-11.5);
            expect(mathEnforcer.subtractTen(5.5)).to.equal(-4.5);
        });
        it('If the parameter is not a number, the function should return undefined.', () => {
            expect(mathEnforcer.subtractTen('-15')).to.equal(undefined);
            expect(mathEnforcer.subtractTen('stone')).to.equal(undefined);
            expect(mathEnforcer.subtractTen([237, 145])).to.equal(undefined);
            expect(mathEnforcer.subtractTen({})).to.equal(undefined);
        });
    });

    describe('Sum two numbers function that accepts two parameters', () => {
        it('If both parameters are numbers, the function should return their sum.', () => {
            expect(mathEnforcer.sum(-15, 5)).to.equal(-10);
            expect(mathEnforcer.sum(0, 5)).to.equal(5);
            expect(mathEnforcer.sum(65, 5)).to.equal(70);
            expect(mathEnforcer.sum(-7.6, 2.6)).to.equal(-5);
            expect(mathEnforcer.sum(-2, -4.4)).to.equal(-6.4);
            expect(mathEnforcer.sum(6.7, 4.3)).to.equal(11);
        });
        it('If any of the 2 parameters is NOT a number, the function should return undefined', () => {
            expect(mathEnforcer.sum('6', '19')).to.equal(undefined);
            expect(mathEnforcer.sum('hi', 9)).to.equal(undefined);
            expect(mathEnforcer.sum(1303, '29')).to.equal(undefined);
            expect(mathEnforcer.sum({}, 46)).to.equal(undefined);
        });
    });
});