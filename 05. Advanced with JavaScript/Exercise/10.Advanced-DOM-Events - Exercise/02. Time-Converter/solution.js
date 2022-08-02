function attachEventsListeners() {
    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');

    let infoTime = {
        days: 1,
        hours: 24,
        minutes: 1440,
        seconds: 86400
    };

    document.getElementById('daysBtn').addEventListener('click', clickConvert);
    document.getElementById('hoursBtn').addEventListener('click', clickConvert);
    document.getElementById('minutesBtn').addEventListener('click', clickConvert);
    document.getElementById('secondsBtn').addEventListener('click', clickConvert);

    function convert(value, unit) {
        let days = value / infoTime[unit];

        return {
            days: days,
            hours: days * infoTime.hours,
            minutes: days * infoTime.minutes,
            seconds: days * infoTime.seconds
        };
    }

    function clickConvert(event) {
        let input = event.target.parentElement.querySelector('input[type="text"]');
    
        let time = convert(Number(input.value), input.id);
        
        days.value = time.days;
        hours.value = time.hours;
        minutes.value = time.minutes;
        seconds.value = time.seconds;
    }
}