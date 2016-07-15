function solve(input) {
    var a = Number(input[0]),
        b = Number(input[1]),
        c = Number(input[2]);

    if(a >= b && a >= c) {
        console.log(a);
    } else if(b >= a && b >= c) {
        console.log(b);
    } else {
        console.log(c);
    }
}

solve([5, 2, 2]);
solve([-2, -2, 1]);
solve([-2, 4, 3]);
solve([0, -2.5, 4]);
solve([-1, -0.5, -5.1]);