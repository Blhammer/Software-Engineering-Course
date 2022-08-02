function colorize() {
    let index = 0;
    let rowElements = document.querySelectorAll('table tr');

    for (const row of rowElements) {
        index++;
        if (index % 2 == 0) {
            row.style.backgroundColor = 'teal';
        }
    }
}