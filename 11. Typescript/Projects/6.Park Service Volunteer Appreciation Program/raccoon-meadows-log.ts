export type RaccoonMeadowsVolunteers = {
    id: number;
    name: string;
    activities: RaccoonMeadowsActivity[];
};

export type RaccoonMeadowsActivity = {
    description: string;
    hours: number;
    verified: string;
};

export const raccoonMeadowsVolunteers = [
    {
        id: 100,
        name: "Rose Sutton",
        activities: [
            {
                description: "Removed stump from trail head",
                hours: 3,
                verified: "Yes",
            },
            {
                description: "Cleared moss from storm drain",
                hours: 3,
                verified: "No",
            },
        ],
    },
    {
        id: 101,
        name: "Leigh Gilmour",
        activities: [
            {
                description: "Trail maintenance",
                hours: 4,
                verified: "Yes",
            },
        ],
    },
    {
        id: 102,
        name: "Raj Wardle",
        activities: [
            {
                description: "Cleaned campsite 14, 15, and 18",
                hours: 6,
                verified: "Yes",
            },
        ],
    },
    {
        id: 103,
        name: "Rayan Gutierrez",
        activities: [
            {
                description: "Hung sign at new entrance of park",
                hours: 1,
                verified: "Yes",
            },
            {
                description: "Refilled maps at trail head 3",
                hours: 1,
                verified: "Yes",
            },
            {
                description: "Replaced trail markers for red trail",
                hours: 3,
                verified: "Yes",
            },
        ],
    },
];
