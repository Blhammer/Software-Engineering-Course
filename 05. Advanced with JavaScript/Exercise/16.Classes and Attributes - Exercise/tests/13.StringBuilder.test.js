const { expect } = require('chai');
const StringBuilder = require('../13.StringBuilder');

describe('String Builder', () => {
    describe('Check the constructors', () => {
        it('It works with a string', () => {
            const sb = new StringBuilder('hammer');
            expect(sb.toString()).to.equal('hammer');
            expect(sb._stringArray).to.deep.equal(['h', 'a', 'm', 'm', 'e', 'r']);
            expect(sb._stringArray.length).to.equal(6);
            expect(typeof sb).to.equal('object');
            expect(sb).to.be.instanceOf(StringBuilder);
        })
        it('It works with an empty constructor', () => {
            const sb = new StringBuilder();
            expect(sb.toString()).to.equal('');
        })
        it('It returns empty array if the parameter is undefined', () => {
            const sb = new StringBuilder(undefined);
            expect(sb._stringArray).to.deep.equal([]);
        })
        it('Throws error if invalid type parameters are passed to the constructor', () => {
            expect(() => { new StringBuilder(55)}).to.throw('Argument must be a string');
            expect(() => { new StringBuilder([])}).to.throw('Argument must be a string');
            expect(() => { new StringBuilder({})}).to.throw('Argument must be a string');
            expect(() => { new StringBuilder(true)}).to.throw('Argument must be a string');
        })
    });

    describe('Check the append functionality', () => {
        it('It appends the parameter', () => {
            const sb = new StringBuilder('suN');
            sb.append('Earth');
            expect(sb.toString()).to.equal('suNEarth');
        })
        it('It works combined with the other similar methods', () => {
            const sb = new StringBuilder('drive');
            sb.prepend(' gogo');
            sb.insertAt('they', 3);
            expect(sb.toString()).to.equal(' gotheygodrive');
        })
        it('Throws error if invalid parameter is passed or append', () => {
            const sb = new StringBuilder('khfa6');
            expect(() => { sb.append(55) }).to.throw('Argument must be a string');
            expect(() => { sb.append([])}).to.throw('Argument must be a string');
            expect(() => { sb.append({})}).to.throw('Argument must be a string');
            expect(() => { sb.append(true)}).to.throw('Argument must be a string');
        })
    });

    describe('Check the prepend functionality', () => {
        it('It prepends the parameter', () => {
            const sb = new StringBuilder('plwa');
            sb.prepend('zoooT');
            expect(sb.toString()).to.equal('zoooTplwa');
        })
        it('Throws error if invalid parameter is passed or prepend', () => {
            const sb = new StringBuilder('qwertyu');
            expect(() => { sb.prepend(56) }).to.throw('Argument must be a string');
            expect(() => { sb.prepend([]) }).to.throw('Argument must be a string');
            expect(() => { sb.prepend({}) }).to.throw('Argument must be a string');
            expect(() => { sb.prepend(true) }).to.throw('Argument must be a string');
        })
        it('It works combined with the other similar methods',() => {
            const sb = new StringBuilder('snowy');
            sb.append('klz');
            sb.prepend('Mq');
            expect(sb.toString()).to.equal('Mqsnowyklz');
        })
    });

    describe('Check the insertAt functionality', () => {
        it('It inserts at the given index', () => {
            const sb = new StringBuilder('erty');
            sb.insertAt('hammer', 3);
            expect(sb.toString()).to.equal('erthammery');
        })
        it('Throws error if invalid parameter is passed or insertAt', () => {
            const sb = new StringBuilder('dog');
            expect(() => { sb.insertAt(55, 325) }).to.throw('Argument must be a string');
            expect(() => { sb.insertAt([], 555) }).to.throw('Argument must be a string');
            expect(() => { sb.insertAt({}, 3) }).to.throw('Argument must be a string');
            expect(() => { sb.insertAt(true, 4) }).to.throw('Argument must be a string');
        })
        it('It works combined with the other similar methods', () => {
            const sb = new StringBuilder('eat');
            sb.append('Run');
            sb.prepend('water');
            sb.insertAt('box', 5);
            expect(sb.toString()).to.equal('waterboxeatRun');
        })
    });

    describe('Check the remove functionality', () => {
        it('Ir removes a substring', () => {
            const sb = new StringBuilder('snow');
            sb.remove(1, 2);
            expect(sb.toString()).to.equal('sw');
        })
        it('It works combined with the other similar methods', () => {
            const sb = new StringBuilder('fper');
            sb.append('home');
            sb.prepend('RTP');
            sb.insertAt('PC', 4);
            sb.remove(3, 5);
            expect(sb.toString()).to.equal('RTPrhome');
        })
    });
});