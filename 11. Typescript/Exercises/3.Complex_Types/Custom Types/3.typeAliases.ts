let aCompany: {
    companyName: string;
    boss: { name: string; age: number };
    employees: { name: string; age: number }[];
    employeeOfTheMonth: { name: string; age: number };
    moneyEarned: number;
};

type Person = { name: string; age: number };
let aCompanyTypeAliases: {
    companyName: string;
    boss: Person;
    employees: Person[];
    employeeOfTheMonth: Person;
    moneyEarned: number;
};

type Coordinate = [number, number, string, number, number, string];

let codeAcademyCoordinates: Coordinate = [40, 43.2, "N", 73, 59.8, "W"];
let bermudaTCoordinates: Coordinate = [25, 0, "N", 71, 0, "W"];
