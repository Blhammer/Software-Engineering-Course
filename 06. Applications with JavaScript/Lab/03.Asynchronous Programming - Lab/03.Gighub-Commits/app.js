function loadCommits() {
    let inputUsername = document.querySelector('#username');
    let username = inputUsername.value;
    let inputRepo = document.querySelector('#repo');
    let liRepoElement = inputRepo.value;
    let ulElement = document.querySelector('#commits');
    ulElement.innerHTML = '';

    const url = `https://api.github.com/repos/${username}/${liRepoElement}/commits`;

    fetch(url)
        .then((res) => {
            if (res.ok === true) return res.json();
            throw new Error(res.status);
        })
        .then(data => {
            for (let commitMessage of data) {
                let liElement = document.createElement('li');
                liElement.textContent = `${commitMessage.commit.author.name}: ${commitMessage.commit.message}`;
                ulElement.appendChild(liElement);
            }
        })
        .catch(error => {
            let liElement = document.createElement('li');
            liElement.textContent = `Error: ${error.message} (Not Found)`;
            ulElement.appendChild(liElement);
        });
}