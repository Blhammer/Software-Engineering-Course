function addItem() {
    let inputElement = document.getElementById('newItemText');
    let listElements = document.getElementById('items');

    let addLiElement = document.createElement('li');
    addLiElement.textContent = inputElement.value;
    inputElement.value = '';

    let deleteLiElement = document.createElement('a');
    deleteLiElement.href = '#';
    deleteLiElement.textContent = '[Delete]';

    deleteLiElement.addEventListener('click', (e) => {
        e.currentTarget.parentElement.remove();
    });

    addLiElement.appendChild(deleteLiElement);
    listElements.appendChild(addLiElement);
}