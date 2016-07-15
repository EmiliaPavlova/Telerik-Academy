function solve(input) {
    var a = Number(input[0]),
        b = Number(input[1]);

    if(a < b) {
        console.log(a + ' ' + b);
    } else {
        console.log((b + ' ' + a));
    }
}

solve([5, 2]);
solve([3, 4]);
solve([5.5, 4.5]);