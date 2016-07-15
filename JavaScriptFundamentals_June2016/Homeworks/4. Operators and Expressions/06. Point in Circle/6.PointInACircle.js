function solve(input) {
    var x = Number(input[0]),
        y = Number(input[1]),
        circleX = 0,
        circleY = 0,
        radius = 2,
        distance;
    distance = Math.sqrt(x * x + y * y);
    if(distance < radius){
        console.log('yes ' + distance.toFixed(2));
    } else {
        console.log('no ' + distance.toFixed(2));
    }
}

solve([-2, 0]);
solve([-1, 2]);
solve([1.5, -1]);
solve([-1.5, -1.5]);
solve([100, -30]);
solve([0, 0]);
solve([0.2, -0.8]);
solve([0.9, -1.93]);
solve([1, 1.655]);
solve([0, 1]);

