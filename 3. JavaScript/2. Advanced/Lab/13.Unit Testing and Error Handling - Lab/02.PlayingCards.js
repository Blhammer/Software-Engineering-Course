function cardFactory(face, suit) {
    const faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    const suits = {
        'S': '\u2660',
        'H': '\u2665',
        'D': '\u2666',
        'C': '\u2663'
    };

    if (!(faces.includes(face) && Object.keys(suits).includes(suit))) {
        throw new Error('Error');
    }

    let card = {
        face,
        suit: suits[suit],
        toString() {
            return `${this.face}${this.suit}`;
        }
    };

    return card;
}

let card = cardFactory('A', 'S');
console.log(card.toString());
let card1 = cardFactory('10', 'H');
console.log(card1.toString());
let card2 = cardFactory('1', 'C');
console.log(card2.toString());