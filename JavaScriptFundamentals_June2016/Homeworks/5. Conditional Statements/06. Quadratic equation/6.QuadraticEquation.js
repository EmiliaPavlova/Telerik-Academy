function solve(input) {
    var a = Number(input[0]),
        b = Number(input[1]),
        c = Number(input[2]),
        x1,
        x2;

    if((b * b) - (4 * a * c) >= 0) {
        x1 = (-b - Math.sqrt((b * b) - (4 * a * c))) / (2 * a);
        x2 = (-b + Math.sqrt((b * b) - (4 * a * c))) / (2 * a);

        if(x1 === x2) {
            console.log('x1=x2=' + x1.toFixed(2));
        } else if(x1 < x2) {
            console.log('x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2));
        } else {
            console.log('x1=' + x2.toFixed(2) + '; x2=' + x1.toFixed(2));
        }
    } else {
        console.log('no real roots');
    }
}

solve([2, 5, -3]);
solve([-1, 3, 0]);
solve([-0.5, 4, -8]);
solve([5, 2, 8]);
solve([0.2, 9.572, 0.2]);