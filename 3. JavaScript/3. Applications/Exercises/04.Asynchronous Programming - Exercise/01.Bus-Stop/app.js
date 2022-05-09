function getInfo() {
    let button = document.querySelector('#submit');
    let busesList = document.querySelector('#buses');
    let stopName = document.querySelector('#stopName');

    button.addEventListener('click', () => {
        let inputField = document.querySelector('#stopId');
        let stopId = inputField.value;
        const url = `http://localhost:3030/jsonstore/bus/businfo/${stopId}`;

        fetch(url)
            .then((res) => {
                if (res.ok === true) return res.json();
                throw new Error(res.status);
            })
            .then(data => {
                stopName.textContent = '';
                busesList.innerHTML = '';
                stopName.textContent = data.name;

                for (entry in data.buses) {
                    let liElement = document.createElement('li');
                    liElement.textContent = `Bus ${entry} arrives in ${data.buses[entry]} minutes`;
                    busesList.appendChild(liElement);
                }
            })
            .catch(error => {
                stopName.textContent = 'Error';
                busesList.innerHTML = '';
            });
    });
}