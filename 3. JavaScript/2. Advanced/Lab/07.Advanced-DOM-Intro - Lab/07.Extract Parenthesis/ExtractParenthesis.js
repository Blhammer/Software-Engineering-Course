function extract(content) {
    let extractedText = document.getElementById(content).textContent;

    let pattern = /\(([^)]+)\)/g;
    let result = [];

    let matches = extractedText.matchAll(pattern);
    
    for (const match of matches) {
        result.push(match[1]);
    }

    return result.join('; ');
}