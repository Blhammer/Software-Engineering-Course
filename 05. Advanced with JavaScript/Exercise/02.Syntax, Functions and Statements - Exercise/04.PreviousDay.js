function solve(a, b, c) {
    let year = a;
    let month = b;
    let day = c;

    let date = new Date(year, month - 1, day - 1);

    date.setDate(date.getDate());
    let newYear = date.getFullYear();
    let newMonth = date.getMonth() + 1;
    let newDate = date.getDate();

    console.log(`${newYear}-${newMonth}-${newDate}`);
}
solve(2016, 9, 30); //2016-9-29
solve(2016, 10, 1); //2016-9-30
solve(2018, 11, 30); //2018-11-29
solve(2018, 12, 1); //2018-11-30
solve(2019, 1, 2); //2019-1-1
solve(2019, 1, 1); //2018-12-31
solve(2022, 1, 19); //2022-1-18
solve(2022, 1, 1); //2021-12-31