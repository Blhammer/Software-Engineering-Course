function loadRepos() {
	document.querySelector('#repos').innerHTML = '';
	
	let liRepoElement = document.querySelector('#repos');
	let inputUsername = document.querySelector('#username');
	let username = inputUsername.value;

	const url = `https://api.github.com/users/${username}/repos`;

	fetch(url)
		.then((res) => {
			if (res.ok === true) return res.json();
			throw new Error(res.status);
		})  
		.then(data => {
			for (let repo of data) {
				const fullName = repo.full_name;
				const repoURL = repo.html_url;

				const liElement = document.createElement('li');
				const elementLink = document.createElement('a');

				elementLink.textContent = `${fullName}`;
				elementLink.href = `${repoURL}`;

				liRepoElement.appendChild(liElement);
				liElement.appendChild(elementLink);
			}
		})
		.catch( error => {
			let liElement = document.createElement('li');
			liElement.textContent = `${error.message} "Not Found"`;
			liRepoElement.appendChild(liElement);
		});
}