type MailType = {
    postagePrice: number;
    address: string;
};

//interface can only be used to type objects
interface MailInterface {
    postagePrice: number;
    address: string;
}

interface Run {
    miles: number;
}

// Use constants instead of magic numbers!
const raceLength: number = 50;

function updateRunGoal(run: Run) {
    console.log(`
  Miles left:       ${raceLength - run.miles}
  Percent of goal:  ${(run.miles / raceLength) * 100}% complete
    `);
}

updateRunGoal({
    miles: 5,
});
