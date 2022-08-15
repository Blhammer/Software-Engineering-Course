import { getObstacleEvents } from "./computer-vision";

interface AutonomousCar {
    isRunning?: boolean;
    respond: (events: Events) => void;
}

interface AutonomousCarProps {
    isRunning?: boolean;
    steeringControl: Steering;
}

interface Events {
    [x: string]: boolean;
}

interface Control {
    execute: (command: string) => void;
}

interface Steering extends Control {
    turn: (direction: string) => void;
}

class Car implements AutonomousCar {
    isRunning;
    steeringControl;

    constructor(props: AutonomousCarProps) {
        this.isRunning = props.isRunning;
        this.steeringControl = props.steeringControl;
    }

    respond(events: Events) {
        if (!this.isRunning) {
            Object.keys(events).forEach((event) => {
                if (!event) {
                    return;
                }

                if (event === "ObstacleLeft") {
                    this.steeringControl.turn("right");
                } else if (event === "ObstacleRight") {
                    this.steeringControl.turn("left");
                }
            });
            return console.log("Off");
        }
    }
}

class SteeringControl implements Steering {
    execute(command: string) {
        console.log(`Executing: turn ${command}`);
    }

    turn(direction: string) {
        this.execute(direction);
    }
}

const steering = new SteeringControl();
const autonomousCar = new Car({ isRunning: false, steeringControl: steering });

autonomousCar.respond(getObstacleEvents());
steering.turn("right");
