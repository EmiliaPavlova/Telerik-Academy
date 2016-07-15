function solve(input) {
    var x1 = +input[0],
        y1 = +input[1],
        x2 = +input[2],
        y2 = +input[3],
        x3 = +input[4],
        y3 = +input[5],
        x4 = +input[6],
        y4 = +input[7],
        x5 = +input[8],
        y5 = +input[9],
        x6 = +input[10],
        y6 = +input[11],
        line1 = calculateLine(x1, y1, x2, y2),
        line2 = calculateLine(x3, y3, x4, y4),
        line3 = calculateLine(x5, y5, x6, y6);

    console.log(line1.toFixed(2));
    console.log(line2.toFixed(2));
    console.log(line3.toFixed(2));
    console.log(canFormTriangle(line1, line2, line3) ? 'Triangle can be built' : 'Triangle can not be built');

    function calculateLine(x1, y1, x2, y2) {
        var distance = Math.sqrt(Math.abs(x1 - x2) * Math.abs(x1 - x2) + Math.abs(y1 - y2) * Math.abs(y1 - y2));
        return distance;
    }

    function canFormTriangle(a, b, c) {
        if(a + b > c && a + c > b && b + c > a) {
            return true;
        }
        return false;
    }
}

solve([
    '5', '6', '7', '8',
    '1', '2', '3', '4',
    '9', '10', '11', '12'
]);
solve([
    '7', '7', '2', '2',
    '5', '6', '2', '2',
    '95', '-14.5', '0', '-0.123'
]);