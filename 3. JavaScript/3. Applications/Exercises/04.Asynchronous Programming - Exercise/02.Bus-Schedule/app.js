function solve() {
    const spanElement = document.querySelector('.info');
    const departButton = document.querySelector('#depart');
    const arriveButton = document.querySelector('#arrive');
    
    let stopId = 'depot';
    const url = `http://localhost:3030/jsonstore/bus/schedule/${stopId}`;

    async function depart() {
        departButton.disabled = true;
        const res = await fetch(url);

        if (res.ok !== true) {
            spanElement.textContent = 'Error!';
            arriveButton.disabled = true;
            departButton.disabled = true;
            alert('Wrong data!');
        }

        stopId = await res.json();
        spanElement.textContent = `Next stop ${stopId.name}`;
        arriveButton.disabled = false;
    }

    function arrive() {
        spanElement.textContent = `Arriving at ${stopId.name}`;
        departButton.disabled = false;
        arriveButton.disabled = true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();