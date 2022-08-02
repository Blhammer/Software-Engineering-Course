function solve() {
    let textarea = document.querySelectorAll('textarea');
    let tbody = document.querySelector('tbody');

    [...document.querySelectorAll('button')].forEach(btn => btn.addEventListener('click', execute));

    function execute(btn) {
        if (!textarea[0].value)
            return;

        if (btn.target.textContent === 'Generate') {
            let input = JSON.parse(textarea[0].value);
            input.forEach(furniture => {
                tbody.innerHTML += `<tr>
          <td><img src=${furniture.img}></td>
          <td><p>${furniture.name}</p></td>
          <td><p>${furniture.price}</p></td>
          <td><p>${furniture.decFactor}</p></td>
          <td><input type="checkbox"/></td>
          </tr>`
            })
        } else {
            let furnitureName = [];
            let totalPrice = 0;
            let averageDecFactor = 0;
            [...document.querySelectorAll('input:checked')]
                .forEach(furniture => {
                    let parentRow = furniture.parentNode.parentNode;
                    averageDecFactor += Number(parentRow.children[3].textContent);
                    totalPrice += Number(parentRow.children[2].textContent);
                    furnitureName.push(parentRow.children[1].textContent);
                });
            textarea[1].textContent += `Bought furniture: ${furnitureName.join(', ')}\n`;
            textarea[1].textContent += `Total price: ${totalPrice.toFixed(2)}\n`;
            textarea[1].textContent += `Average decoration factor: ${averageDecFactor / furnitureName.length}`;
        }
    }
}