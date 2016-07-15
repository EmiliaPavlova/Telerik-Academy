function solve(input) {
    var n = parseInt(input),
        array = new Array(0),
        i, j;

    for (i = 0; i < n; i++) {
        array.push(i * 5);
    }

    for (j in array) {
        console.log(array[j]);
    }
}

solve(5);