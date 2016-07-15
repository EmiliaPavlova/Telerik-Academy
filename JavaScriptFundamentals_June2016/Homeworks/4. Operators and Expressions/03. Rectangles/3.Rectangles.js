function solve(input) {
    var width = Number(input[0]),
        height = Number(input[1]),
        rectangleArea,
        rectanglePerimeter;
    rectangleArea = width * height;
    rectanglePerimeter = 2 * (width + height);

    console.log(rectangleArea.toFixed(2) + ' ' + rectanglePerimeter.toFixed(2));
}

solve([2.5, 3]);
solve([5, 5]);
solve([3, 4]);