type StatusNew = "idle" | "downloading" | "complete";

function downloadStatus(status: StatusNew) {
    if (status === "idle") {
        console.log("Download");
    } else if (status === "downloading") {
        console.log("Downloading...");
    } else if (status === "complete") {
        console.log("Your download ic complete!");
    }
}

downloadStatus("idle");
