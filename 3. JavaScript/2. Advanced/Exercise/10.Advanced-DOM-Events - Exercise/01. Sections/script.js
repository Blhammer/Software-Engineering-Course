function create(words) {
    let parentElement = document.getElementById('content');
    let allElements = words;

    for (let i = 0; i < allElements.length; i++) {
        let divElement = document.createElement('div');
        let pElement = document.createElement('p');
        let currentText = document.createTextNode(allElements[i]);
        
        pElement.appendChild(currentText);
        pElement.style.display = 'none';

        divElement.appendChild(pElement);
        divElement.addEventListener('click', eventShowParagraph);

        parentElement.appendChild(divElement);
    }

    function eventShowParagraph(event) {
        console.log(event.target.textContent); //! Look at the console
        event.target.children[0].style.display = 'block';
    }
}

/* Event Delegation over parent
let divs = [];
   let divElement = document.getElementById('content');
   for (const word of words) {
      let div = document.createElement('div');
      let p = document.createElement('p');
      p.textContent = word;
      p.setAttribute('style', 'display:none;');
      div.appendChild(p)
      divElement.appendChild(div);
   }
 
   divElement.addEventListener('click', (e) => {
      if (e.target.tagName === 'DIV' && !e.target.getAttribute('id')) {
         let el = e.target.querySelector('p');
         el.style.display = 'block';
      }
   });
*/