import {
    RaccoonMeadowsVolunteers,
    RaccoonMeadowsActivity,
    raccoonMeadowsVolunteers,
} from "./raccoon-meadows-log";

import {
    WolfPointVolunteers,
    WolfPointActivity,
    wolfPointVolunteers,
} from "./wolf-point-log";

type CombinedActivity = RaccoonMeadowsActivity | WolfPointActivity;

type Volunteers = {
    id: number;
    name: string;
    activities: CombinedActivity[];
};

function combineVolunteers(
    volunteers: (RaccoonMeadowsVolunteers | WolfPointVolunteers)[]
) {
    return volunteers.map((volunteer) => {
        let volunteerId = volunteer.id;
        if (typeof volunteerId === "string") {
            volunteerId = parseInt(volunteerId, 10);
        }

        return {
            id: volunteerId,
            name: volunteer.name,
            activities: volunteer.activities,
        };
    });
}

function isVerified(verified: string | boolean) {
    if (typeof verified === "string") {
        if (verified === "Yes") return true;
        if (verified === "No") return false;
    }

    return verified;
}

function getHours(activity: CombinedActivity) {
    if ("hours" in activity) {
        return activity.hours;
    } else {
        return activity.time;
    }
}

function calculateHours(volunteers: Volunteers[]) {
    return volunteers.map((volunteer) => {
        let hours = 0;
        volunteer.activities.forEach((activity) => {
            if (isVerified(activity.verified)) {
                hours += getHours(activity);
            }
        });

        return {
            id: volunteer.id,
            name: volunteer.name,
            hours: hours,
        };
    });
}

function byHours(a: { hours: number }, b: { hours: number }) {
    return b.hours - a.hours;
}

const combinedVolunteers = combineVolunteers(
    [].concat(wolfPointVolunteers, raccoonMeadowsVolunteers)
);

let result = calculateHours(combinedVolunteers);
console.log(result.sort(byHours));
