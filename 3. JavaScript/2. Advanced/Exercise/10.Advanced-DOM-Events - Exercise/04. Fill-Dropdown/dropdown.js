function addItem() {
    let inputText = document.getElementById('newItemText').value;
    let inputValue = document.getElementById('newItemValue').value;

    let options = document.createElement('option');
    options.text = inputText;
    options.value = inputValue;

    let menu = document.getElementById('menu');

    if (inputText !== '' && inputValue !== '') {
        menu.appendChild(options);
    }
    
    document.getElementById('newItemText').value = '';
    document.getElementById('newItemValue').value = '';
}