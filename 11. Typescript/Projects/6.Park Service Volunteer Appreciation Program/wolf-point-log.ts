export type WolfPointVolunteers = {
    id: string;
    name: string;
    activities: WolfPointActivity[];
};

export type WolfPointActivity = {
    notes: string;
    time: number;
    verified: boolean;
};

export const wolfPointVolunteers = [
    {
        id: "400sg",
        name: "Sarah Galloway",
        activities: [
            {
                notes: "Cleaned up rock slide on south bend",
                time: 7,
                verified: true,
            },
        ],
    },
    {
        id: "401cm",
        name: "Cormac Mcfarlane",
        activities: [
            {
                notes: "Mowed Wolf Pup Landing",
                time: 3,
                verified: true,
            },
            {
                notes: "Trimmed branches at Sit Point Lookout",
                time: 2,
                verified: true,
            },
        ],
    },
    {
        id: "402mm",
        name: "Maisha Mcconnell",
        activities: [
            {
                notes: "Picked up litter, hung signs about littering",
                time: 2,
                verified: false,
            },
        ],
    },
    {
        id: "403jr",
        name: "Joanna Reilly",
        activities: [
            {
                notes: "Mapped trail for Trail Lupine proposal",
                time: 5,
                verified: true,
            },
            {
                notes: "Closed Howler Café for winter",
                time: 3,
                verified: true,
            },
        ],
    },
];
