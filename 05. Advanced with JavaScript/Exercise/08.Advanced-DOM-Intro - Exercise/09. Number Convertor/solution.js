function solve() {
    const selectMenu = document.getElementById('selectMenuTo');
    const binaryOption = document.createElement('option');

    binaryOption.textContent = 'Binary';
    binaryOption.value = 'binary';

    const hexadecimalOption = document.createElement('option');
    
    hexadecimalOption.textContent = 'Hexadecimal';
    hexadecimalOption.value = 'hexadecimal';

    selectMenu.appendChild(binaryOption);
    selectMenu.appendChild(hexadecimalOption);

    const selectMap = {
        'binary': num => num.toString(2),
        'hexadecimal': num => num.toString(16).toUpperCase()
    }

    const convertBtn = document.querySelector('#container > button');

    convertBtn.addEventListener('click', (evt) => {
        const inputData = document.getElementById('input');
        const outputData = document.getElementById('result');

        outputData.value = selectMap[selectMenu.value](+inputData.value);
    })
}