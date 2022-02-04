function solve(inputArr) {
    let result = [];

    let [Town, Latitude, Longitude] = inputArr[0].split('|');
    inputArr.shift();

    for (const currentTown of inputArr) {
        let [townName, townLatitude, townLongitude] = currentTown.split('|').filter(x => x);
        Town = townName.toString().trim();

        townLatitude = Number(townLatitude).toFixed(2);
        Latitude = Number(townLatitude);

        townLongitude = Number(townLongitude).toFixed(2);
        Longitude = Number(townLongitude);

        result.push({ Town, Latitude, Longitude });
    }

    console.log(JSON.stringify(result));
}
solve(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
);
solve(['| Town | Latitude | Longitude |',
    '| Veliko Turnovo | 43.0757 | 25.6172 |',
    '| Monatevideo | 34.50 | 56.11 |']
);