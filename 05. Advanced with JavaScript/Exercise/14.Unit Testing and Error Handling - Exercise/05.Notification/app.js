function notify(message) {
    const notificationElement = document.getElementById('notification');

    notificationElement.textContent = message;
    notificationElement.hidden = false;
    notificationElement.style.display = 'block';

    notificationElement.addEventListener('click', display); 
    
    function display(ev) {
        ev.target.hidden = true;
        ev.target.style.display = 'none';
    };
}