window.onload = solution;

async function solution() {
    const url = `http://localhost:3030/jsonstore/advanced/articles/`;
    
    const response = await fetch(`${url}list`);
    const data = await response.json();
    
    const mainSection = document.querySelector('#main');

    data.forEach(el => {
        let mainDiv = document.createElement('div');
        mainDiv.classList.add('accordion');

        let headDiv = document.createElement('div');
        headDiv.classList.add('head');

        let span = document.createElement('span');
        span.textContent = el.title;

        let moreButton = document.createElement('button');
        moreButton.classList.add('button');
        moreButton.setAttribute('id', el._id);
        moreButton.textContent = 'More';

        headDiv.appendChild(span);
        headDiv.appendChild(moreButton);

        let extraDiv = document.createElement('div');
        extraDiv.classList.add('extra');
        extraDiv.style.display = 'none';

        let paragraph = document.createElement('p');

        extraDiv.appendChild(paragraph);

        moreButton.addEventListener('click', async () => {
            if (moreButton.textContent === 'More') {
                moreButton.textContent = 'Less';
                extraDiv.style.display = 'block';

                let responseArticle = await fetch(`${url}/details/${el._id}`);
                let currentArticle = await responseArticle.json();

                paragraph.textContent = currentArticle.content;
            } else {
                moreButton.textContent = 'More';
                extraDiv.style.display = 'none';
            }
        })

        mainDiv.appendChild(headDiv);
        mainDiv.appendChild(extraDiv);

        mainSection.appendChild(mainDiv);
    });
}

solution();