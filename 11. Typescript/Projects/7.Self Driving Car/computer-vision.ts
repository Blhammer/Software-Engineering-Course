export function getObstacleEvents() {
    const coinFlip = Boolean(Math.random() > 0.5);

    return {
        ObstacleLeft: coinFlip,
        ObstacleRight: !coinFlip,
    };
}
