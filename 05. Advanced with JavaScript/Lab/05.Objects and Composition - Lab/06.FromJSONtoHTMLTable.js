function fromJSONToHTMLTable(input) {
    let arr = JSON.parse(input);

    let outputArr = ['<table>'];
    outputArr.push(makeKeyRow(arr));
    arr.forEach((obj) => outputArr.push(makeValueRow(obj)));
    outputArr.push("</table>");

    console.log(outputArr.join('\n'));

    function makeKeyRow(arr) {
        let result = '  <tr>';
        Object.keys(arr[0]).forEach(key => {
            result += `<th>${escapeHtml(key)}</th>`;
        });
        result += '</tr>';
        return result;
    }

    function makeValueRow(obj) {
        let result = '  <tr>';
        Object.values(obj).forEach(value => {
            result += `<td>${escapeHtml(value)}</td>`;
        });
        result += '</tr>';
        return result;
    }

    function escapeHtml(value) {
        return value
            .toString()
            .replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }
}
fromJSONToHTMLTable(['[{"Name":"Stamat","Price":5.5}, {"Name":"Rumen","Price":6}]']);
fromJSONToHTMLTable([`[{"Name":"Pesho", "Score":4, " Grade":8},
                       {"Name":"Gosho", "Score":5, " Grade":8},
                       {"Name":"Angel", "Score":5.50, " Grade":10}]`]);