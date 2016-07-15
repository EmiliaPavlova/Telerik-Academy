function solve(input) {
    var sum = 0,
        avg = 0;

    for (var i = 0; i < input.length; i++) {
        sum += Number(input[i]);
    }
    avg = sum / input.length;

    console.log('min=' + Math.min.apply(null, input).toFixed(2));
    console.log('max=' + Math.max.apply(null, input).toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}

solve([2, 5, 1]);
solve([2, -1, 4]);