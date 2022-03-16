function loadRepos() {
    let url = 'https://api.github.com/users/testnakov/repos';
    const httpRequest = new XMLHttpRequest();

    httpRequest.addEventListener('readystatechange', function () {
        if (httpRequest.readyState == 4 && httpRequest.status == 200) {
            document.querySelector('#res').textContent = httpRequest.responseText;
        }
    });

    httpRequest.open('GET', url);
    httpRequest.send();
}