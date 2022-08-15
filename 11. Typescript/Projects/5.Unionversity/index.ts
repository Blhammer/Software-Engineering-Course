import studyGroups from "./studyGroups";
import courses from "./courses";

type Course = {
    id: number;
    studyGroupId: number;
    title: string;
    keywords: string[];
    eventType: string;
};

type StudyGroup = {
    id: number;
    courseId: number;
    title: string;
    keywords: string[];
    eventType: string;
};

type SearchEventOption = {
    query: string | number;
    eventType: "courses" | "studyGroups";
};

function searchEvents(options: SearchEventOption) {
    const events: (Course | StudyGroup)[] =
        options.eventType === "courses" ? courses : studyGroups;

    return events.filter((event: Course | StudyGroup) => {
        if (typeof options.query === "number") {
            return options.query === event.id;
        } else if (typeof options.query === "string") {
            return event.keywords.includes(options.query);
        }
    });
}

let enrolledEvents: (Course | StudyGroup)[] = [];
function enroll(event: Course | StudyGroup) {
    enrolledEvents = [...enrolledEvents, event];
}

/*
Allow the enroll() function to take in a list of courses and add them all to enrolledEvents.
Add another function that allows you to drop a course.
Add another function that prints only the titles of your enrolled events.
*/

const searchResult = searchEvents({ query: "art", eventType: "courses" });
enroll(searchResult[1]);
console.log(enrolledEvents);
