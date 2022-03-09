const { expect } = require('chai');
const PaymentPackage = require('../12.PaymentPackage');

describe('Payment Package', () => {
    describe('Two parameters', () => {
        it('Can be instantiated with two parameters', () => {
            const obj = new PaymentPackage('Computer', 2300);
            expect(obj.name === 'Computer').to.be.true;
            expect(obj.value === 2300).to.be.true;
        })
    });

    describe('Accessor name', () => {
        it('Accessor name - used to get and set the value of the name', () => {
            const obj = new PaymentPackage('Computer', 2300);
            obj.name = 'Chair';
            expect(obj.name).to.equal('Chair');
        });
    });

    describe('Accessor value', () => {
        it('Accessor value - used to get and set the value of the value', () => {
            const obj = new PaymentPackage('Computer', 2300);
            obj.value = 2600;
            expect(obj.value).to.equal(2600);
        });
    });

    describe('Accessor VAT', () => {
        it('Accessor VAT - used to get and set the value of the VAT', () => {
            const obj = new PaymentPackage('Computer', 2300);
            obj.VAT = 20;
            expect(obj.VAT).to.equal(20);
        });
        it('It gets the value of VAT property when instantiated', () => {
            const obj = new PaymentPackage('Computer', 2300);
            expect(obj.VAT).to.equal(20);
        })
        it('Throw error when given VAT parameter is not a number or a negative number', () => {
            const obj = new PaymentPackage('Computer', 2300);
            expect(() => { obj.VAT = -150 }).to.throw('VAT must be a non-negative number');
            expect(() => { obj.VAT = '333' }).to.throw('VAT must be a non-negative number');
            expect(() => { obj.VAT = {} }).to.throw('VAT must be a non-negative number');
        })
        it('It returns toString result when VAT is 0', () => {
            const obj = new PaymentPackage('Computer', 0);
            obj.VAT = 0;

            let output = [
                `Package: Computer`,
                `- Value (excl. VAT): 0`,
                `- Value (VAT 0%): 0`
            ];
            const result = output.join('\n');

            expect(obj.toString()).to.equal(result);
        })
    });

    describe('Accessor active', () => {
        it('Get should work', () => {
            const obj = new PaymentPackage('Computer', 2300);
            expect(obj.active).to.equal(true);
        })
        it('Set should work', () => {
            const obj = new PaymentPackage('Computer', 2300);
            obj.active = false;
            expect(obj.active).to.be.false;
        })
        it('Throw error if the active parameters are not boolean', () => {
            const obj = new PaymentPackage('Computer', 2300);
            expect(() => { obj.active = 3 }).to.throw('Active status must be a boolean');
            expect(() => { obj.active = '3' }).to.throw('Active status must be a boolean');
            expect(() => { obj.active = {} }).to.throw('Active status must be a boolean');
        })
        it('It returns proper toString result when active is true', () => {
            const obj = new PaymentPackage('Computer', 2300);

            const output = [
                `Package: Computer`,
                `- Value (excl. VAT): 2300`,
                `- Value (VAT 20%): 2760`
            ];
            const result = output.join('\n');

            expect(obj.toString()).to.equal(result);
        })
        it('It returns proper toString result when active is false', () => {
            const obj = new PaymentPackage('Computer', 2300);
            obj.active = false;

            const output = [
                `Package: Computer (inactive)`,
                `- Value (excl. VAT): 2300`,
                `- Value (VAT 20%): 2760`
            ];
            const result = output.join('\n');

            expect(obj.toString()).to.equal(result);
        })
    });

    describe('Throw Errors', () => {
        it('It throws error if the name is empty string or it is not a string', () => {
            expect(() => { new PaymentPackage(54, 2300) }).to.throw('Name must be a non-empty string');
            expect(() => { new PaymentPackage('', 2300) }).to.throw('Name must be a non-empty string');
            expect(() => { new PaymentPackage(true, 2300) }).to.throw('Name must be a non-empty string');
            expect(() => { new PaymentPackage([], 2300) }).to.throw('Name must be a non-empty string');
            expect(() => { new PaymentPackage({}, 2300) }).to.throw('Name must be a non-empty string');
        })
        it('It throws error if the value is not a number or negative', () => {
            expect(() => { new PaymentPackage('Computer', '54') }).to.throw('Value must be a non-negative number');
            expect(() => { new PaymentPackage('Computer', 'black') }).to.throw('Value must be a non-negative number');
            expect(() => { new PaymentPackage('Computer', true) }).to.throw('Value must be a non-negative number');
            expect(() => { new PaymentPackage('Computer', []) }).to.throw('Value must be a non-negative number');
            expect(() => { new PaymentPackage('Computer', {}) }).to.throw('Value must be a non-negative number');
        })
    });
});