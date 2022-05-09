function attachEvents() {
    let url = "http://localhost:3030/jsonstore/forecaster/";

    let locationInputElement = document.querySelector("#location");
    let forecastDiv = document.querySelector("#forecast");
    let currentConditionsDivElement = document.querySelector("#current");
    let threeDayForecastDivElement = document.querySelector("#upcoming");

    let button = document.querySelector("#submit");
    button.addEventListener('click', getWeather);

    function getSymbol(condition) {
        switch (condition) {
            case 'Sunny':
                return "&#x2600";
            case 'Partly sunny':
                return "&#x26C5";
            case 'Overcast':
                return "&#x2601";
            case 'Rain':
                return "&#x2614;";
            case 'Degree':
                return "&#176";
            case 'Degree':
                return "&#176";
        }
    }

    async function getWeather(event) {
        event.preventDefault();

        try {
            let location = locationInputElement.value;

            currentConditionsDivElement.innerHTML = '<div class="label">Current conditions</div>';
            threeDayForecastDivElement.innerHTML = '<div class="label">Three-day forecast</div>';

            let divElements = Array.from(forecastDiv.children);
            divElements.forEach((x) => (x.style.display = 'block'));

            let paragraphs = Array.from(forecastDiv.querySelectorAll('p'));
            paragraphs.forEach(x => x.remove());

            let responseLocation = await fetch(`${url}locations`);
            let locations = await responseLocation.json();

            let specLocation = locations.find((x) => x.name === location);
            
            let responseToday = await fetch(`${url}today/${specLocation.code}`);
            let forecastForToday = await responseToday.json();
            
            let responseForecastInfo = await fetch(`${url}upcoming/${specLocation.code}`);
            let upcomingForecastInfo = await responseForecastInfo.json();

            forecastDiv.style.display = "inline";

            let weatherSymbol = getSymbol(forecastForToday.forecast.condition);

            let forecastDivElement = document.createElement("div");
            forecastDivElement.classList.add("forecasts");

            let conditionSpanElement = document.createElement("span");
            conditionSpanElement.classList.add("condition");
            conditionSpanElement.classList.add("symbol");
            conditionSpanElement.innerHTML = weatherSymbol;
            forecastDivElement.appendChild(conditionSpanElement);

            let forecastDataSpanElement = document.createElement("span");
            forecastDataSpanElement.classList.add("condition");

            let locationSpanElement = document.createElement("span");
            locationSpanElement.classList.add("forecast-data");
            locationSpanElement.textContent = forecastForToday.name;
            forecastDataSpanElement.appendChild(locationSpanElement);

            let degreesSpanElement = document.createElement("span");
            degreesSpanElement.classList.add("forecast-data");
            degreesSpanElement.innerHTML = `${forecastForToday.forecast.low}${getSymbol('Degree')}/${forecastForToday.forecast.high}${getSymbol('Degree')}`;
            forecastDataSpanElement.appendChild(degreesSpanElement);

            let weatherSpanElement = document.createElement("span");
            weatherSpanElement.classList.add("forecast-data");
            weatherSpanElement.textContent = forecastForToday.forecast.condition;
            forecastDataSpanElement.appendChild(weatherSpanElement);

            forecastDivElement.appendChild(forecastDataSpanElement);
            currentConditionsDivElement.appendChild(forecastDivElement);

            let upcomingForecastInfoDiv = document.createElement("div");
            upcomingForecastInfoDiv.classList.add("forecast-info");

            upcomingForecastInfo.forecast.forEach((x) => {
                weatherSymbol = getSymbol(x.condition);

                let upcomingSpan = document.createElement("span");
                upcomingSpan.classList.add("upcoming");

                let weatherSymbolSpan = document.createElement("span");
                weatherSymbolSpan.classList.add("symbol");
                weatherSymbolSpan.innerHTML = weatherSymbol;
                upcomingSpan.appendChild(weatherSymbolSpan);

                let degreesSpan = document.createElement("span");
                degreesSpan.classList.add("forecast-data");
                degreesSpan.innerHTML = `${x.low}${getSymbol('Degree')}/${x.high}${getSymbol('Degree')}`;
                upcomingSpan.appendChild(degreesSpan);

                let conditionSpan = document.createElement("span");
                conditionSpan.classList.add("forecast-data");
                conditionSpan.textContent = x.condition;
                upcomingSpan.appendChild(conditionSpan);

                upcomingForecastInfoDiv.appendChild(upcomingSpan);
            });

            threeDayForecastDivElement.appendChild(upcomingForecastInfoDiv);
        } catch {
            forecastDivElement.style.display = 'inline';
            let divElements = Array.from(forecastDivElement.children);
            divElements.forEach((x) => (x.style.display = 'none'));

            let paragraph = document.createElement('p');
            paragraph.textContent = 'Error';
            forecastDivElement.appendChild(paragraph);
        }
    };
}

attachEvents();