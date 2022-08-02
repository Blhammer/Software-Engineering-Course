function editElement(reference, match, replacer) {
    let pattern = new RegExp(match, 'g')
    reference.textContent = reference.textContent.replace(pattern, replacer);
}