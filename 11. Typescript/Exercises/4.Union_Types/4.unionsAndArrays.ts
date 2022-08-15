const dateNumber = new Date().getTime();
const dateString = new Date().toString();

const timesList: (string | number)[] = [dateNumber, dateString];

function formatListings(listings: (string | number)[]) {
    return listings.map((listing) => {
        if (typeof listing === "string") {
            return listing.toUpperCase();
        }

        if (typeof listing === "number") {
            return `$${listing.toLocaleString()}`;
        }
    });
}

const result = formatListings([
    "123 Main St",
    226800,
    "580 Broadway Apt 4a",
    337900,
]);

console.log(result);
