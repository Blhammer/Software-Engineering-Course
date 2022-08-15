// This is an example and it doesn't work!
// a sample of index signatures

//import { getBudgetAsync } from "./6.api";
/*
{
  shopping: 150,
  food: 210,
  utilities: 100,
}
*/

interface Budget {
    [category: string]: number;
}

async function getBudget() {
    //const result: Budget = await getBudgetAsync();
    //console.log(result);
}

getBudget();
