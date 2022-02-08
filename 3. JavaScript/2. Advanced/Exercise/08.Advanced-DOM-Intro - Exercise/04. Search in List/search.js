function search() {
    let townsElement = Array.from(document.querySelectorAll('#towns li'));//parent - child
    let inputWord = document.getElementById('searchText').value;
    let result = document.getElementById('result');
    let count = 0;

    for (const town of townsElement) {
        if (town.textContent.includes(inputWord)) {
            town.style.fontWeight = 'bold';
            town.style.textDecoration = 'underline';
            count++;
        } else {
            town.style.fontWeight = 'normal';
            town.style.textDecoration = 'none';
        }
    }

    result.textContent = `${count} matches found`;
}