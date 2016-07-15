function solve(input){
    var a = Number(input[0]),
        b = Number(input[1]),
        h = Number(input[2]),
        area;
    area = (a + b) / 2 * h;
    console.log(area.toFixed(7));
}

solve([5, 7, 12]);
solve([2, 1, 33]);
solve([8.5, 4.3, 2.7]);
solve([100, 200, 300]);
solve([0.222, 0.333, 0.555]);