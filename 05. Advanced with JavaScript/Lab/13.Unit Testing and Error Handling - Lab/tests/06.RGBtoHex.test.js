const { expect } = require('chai');
const rgbToHexColor = require('../06.RGBtoHex');

describe('RGB to Hex', () => {
    it('return undefined if each of the colors is out of the range [0...255]', () => {
        expect(rgbToHexColor(-25, 27, 216)).to.equal(undefined);
        expect(rgbToHexColor(25, -27, 216)).to.equal(undefined);
        expect(rgbToHexColor(25, 27, -216)).to.equal(undefined);
        
        expect(rgbToHexColor(256, 27, 25)).to.equal(undefined);
        expect(rgbToHexColor(27, 500, 6)).to.equal(undefined);
        expect(rgbToHexColor(27, 3, 560)).to.equal(undefined);
    });
    it('Return the same color in hexadecimal format as a string', () => {
        expect(rgbToHexColor(157, 14, 2)).to.equal('#9D0E02');
        expect(rgbToHexColor(12, 155, 1)).to.equal('#0C9B01');
        expect(rgbToHexColor(16, 25, 52)).to.equal('#101934');

        expect(rgbToHexColor(0, 0, 2)).to.equal('#000002');
        expect(rgbToHexColor(1, 2, 0)).to.equal('#010200');
        expect(rgbToHexColor(255, 0, 16)).to.equal('#FF0010');
    });
    it('Return undefined if any of the input parameters are of an invalid type or not in the expected range', () => {
        expect(rgbToHexColor('17', '14', 202)).to.equal(undefined);
        expect(rgbToHexColor(19, '27', 111)).to.equal(undefined);
        expect(rgbToHexColor(1, '2', 3)).to.equal(undefined);
    });
});