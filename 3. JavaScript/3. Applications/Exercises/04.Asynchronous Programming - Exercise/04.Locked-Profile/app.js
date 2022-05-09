async function lockedProfile() {
    let url = `http://localhost:3030/jsonstore/advanced/profiles`;

    let objInfoUsersResponse = await fetch(url);
    let objInfoUsers = await objInfoUsersResponse.json();

    let mainElement = document.querySelector('#main');
    mainElement.innerHTML = '';

    for (const key in objInfoUsers) {
        mainElement.innerHTML +=
            `<div class="profile">
                <img src="./iconProfile2.png" class="userIcon" />
                <label>Lock</label>
                <input type="radio" name="user1Locked" value="lock" checked>
                <label>Unlock</label>
                <input type="radio" name="user1Locked" value="unlock"><br>
                <hr>
                <label>Username</label>
                <input type="text" name="user1Username" value="${objInfoUsers[key].username}" disabled readonly />
                <div class="hiddenInfo">
                    <hr>
                    <label>Email:</label>
                    <input type="email" name="user1Email" value="${objInfoUsers[key].email}" disabled readonly />
                    <label>Age:</label>
                    <input type="email" name="user1Age" value="${objInfoUsers[key].age}" disabled readonly />
                </div>
                <button>Show more</button>
            </div>`;
    }

    let buttons = Array.from(mainElement.querySelectorAll('button'));

    buttons.forEach((element) => {
        element.addEventListener('click', (ev) => {
            let containerElement = ev.currentTarget.previousElementSibling;
            let parentElement = ev.currentTarget.parentNode;
            let unlockElement = parentElement.querySelector('input[value="unlock"]');

            if (unlockElement.checked && ev.currentTarget.textContent == "Show more") {
                containerElement.style.display = "inline-block";
                let children = Array.from(containerElement.children);
                children.forEach((x) => (x.style.display = "block"));

                ev.currentTarget.textContent = "Hide it";
            } else if (unlockElement.checked && ev.currentTarget.textContent == "Hide it") {
                containerElement.style.display = "none";

                ev.currentTarget.textContent = "Show more";
            }
        });
    });
}