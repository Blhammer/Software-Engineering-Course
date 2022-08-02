function solve(pies, firstFlavor, secondFlavor) {
    const start = pies.indexOf(firstFlavor);
    const end = pies.indexOf(secondFlavor) + 1;

    const result = pies.slice(start, end);

    return result;
}
solve(
    [
        "Pumpkin Pie",
        "Key Lime Pie",
        "Cherry Pie",
        "Lemon Meringue Pie",
        "Sugar Cream Pie",
    ],
    "Key Lime Pie",
    "Lemon Meringue Pie"
);
solve(
    [
        "Apple Crisp",
        "Mississippi Mud Pie",
        "Pot Pie",
        "Steak and Cheese Pie",
        "Butter Chicken Pie",
        "Smoked Fish Pie",
    ],
    "Pot Pie",
    "Smoked Fish Pie"
);
