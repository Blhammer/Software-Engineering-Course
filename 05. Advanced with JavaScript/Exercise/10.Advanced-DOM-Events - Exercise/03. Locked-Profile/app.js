function lockedProfile() {
    Array.from(document.querySelectorAll('.profile button'))
    .forEach(button => button.addEventListener('click', onClick));

    function onClick(event) {
        let profile = event.target.parentElement;
        let isButtonUnlocked = profile.querySelector('input[value="unlock"]').checked;

        if (isButtonUnlocked) {
            let infoShowMore = Array.from(profile.querySelectorAll('div'))
            .find(p => p.id.includes('HiddenFields'));
            
            if (event.target.textContent === 'Show more') {
                event.target.textContent = 'Hide it';
                infoShowMore.style.display = 'block';
            } else {
                event.target.textContent = 'Show more';
                infoShowMore.style.display = 'none';
            }
        }
    }
}