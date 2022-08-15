function formatValue(value: string | number) {
    if (typeof value === "string") {
        console.log(value.toLowerCase());
    } else if (typeof value === "number") {
        console.log(value.toFixed(2));
    }
}

formatValue("Hello");
formatValue(42);
