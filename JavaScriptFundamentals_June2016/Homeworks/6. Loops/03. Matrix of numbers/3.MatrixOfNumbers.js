function solve(input) {
    var number = Number(input),
        i, j,
        line = '';

    for (i = 1; i <= number; i++) {
        line = '';
        for(j = i; j < number + i; j++) {
            line += j + ' ';
        }
        console.log(line);
    }
}

solve(2);
solve(3);
solve(4);