function solve(a, b) {
    let month = a;
    let year = b;
    
    let output = new Date(year, month, 0).getDate();

    console.log(output); 
}
solve(1, 2012);
solve(2, 2021);