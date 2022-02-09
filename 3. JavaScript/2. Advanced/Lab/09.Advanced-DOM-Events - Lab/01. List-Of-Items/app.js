function addItem() {
    let inputElement = document.getElementById('newItemText');
    let itemsElement = document.getElementById('items');

    let nextLiElement = document.createElement('li');
    nextLiElement.textContent = inputElement.value;

    itemsElement.appendChild(nextLiElement);

    document.getElementById('newItemText').value = '';
}