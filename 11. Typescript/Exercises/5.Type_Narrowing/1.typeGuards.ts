// Type guard pattern can check if a variable is a specific type.
function formatDate(date: string | number) {
    if (typeof date === "string") {
        return "12.12.2012";
    }
}

function formatStatistic(stat: string | number) {
    if (typeof stat === "number") {
        return stat.toFixed(2);
    } else if (typeof stat === "string") {
        return stat.toUpperCase();
    }
}

console.log(formatStatistic("Win"));
console.log(formatStatistic(0.364));
