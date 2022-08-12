function proclaim2(status = "not ready...", repeat = 1) {
    for (let i = 0; i < repeat; i += 1) {
        console.log(`I'm ${status}`);
    }
}

proclaim2();
proclaim2("ready?");
proclaim2("ready!", 3);
