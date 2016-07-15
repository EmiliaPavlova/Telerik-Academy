function solve(input) {
    var number = Number(input),
        i,
        result = '';

    for (i = 1; i <= number; i++) {
        i === number ? result += i : result += i + ' ';
    }

    console.log(result);
}

solve(5);
solve(1);