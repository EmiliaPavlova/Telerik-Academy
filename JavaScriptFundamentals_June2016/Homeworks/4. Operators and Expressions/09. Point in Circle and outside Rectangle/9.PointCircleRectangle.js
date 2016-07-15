function solve(input) {
    var x = Number(input[0]),
        y = Number(input[1]),
        circleX = 1,
        circleY = 1,
        radius = 1.5,
        top = 1,
        left = -1,
        width = 6,
        height = 2,
        distance,
        isInsideCircle = false,
        isInsideRectangle = true;

    distance = Math.sqrt(Math.pow(x - circleX, 2) + Math.pow(y - circleY, 2));
    if(distance <= radius){
        isInsideCircle = true;
    }

    if((left < x && x < left + width) && (top < y && y < top + height)) {
        isInsideRectangle = false;
    }

    console.log('%s %s',
                isInsideCircle ? 'inside circle' : 'outside circle',
                isInsideRectangle ? 'inside rectangle' : 'outside rectangle');
}

solve([2.5, 2]);
solve([0, 1]);
solve([2.5, 1]);
solve([1, 2]);