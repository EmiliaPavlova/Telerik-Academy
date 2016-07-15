function solve(input) {
    var line = input[0].split(' ').map(Number),
        n = line[0],
        k = line[1],
        numbers = input[1].split(' ').map(Number),
        i, j,
        sum = 0;

    if(k > 0) {
        for (j = 0; j < k; j++) {
            var result = [];
            for (i = 0; i < n; i++) {
                if (i === 0) {
                    result[i] = transform(numbers[i], numbers[n - 1], numbers[i + 1]);
                } else if (i === n - 1) {
                    result[i] = transform(numbers[i], numbers[i - 1], numbers[0]);
                } else {
                    result[i] = transform(numbers[i], numbers[i - 1], numbers[i + 1]);
                }
            }
            numbers = result;
        }
    } else {
        result = numbers;
    }

    for (var number in result) {
        sum += result[number];
    }

    console.log(sum);

    function transform(number, prev, next) {
        switch (number) {
            case 0:
                return Math.abs(prev - next);
                break;
            case 1:
                return prev + next;
                break;
            default:
                if(number % 2 === 0) {
                    return Math.max(prev, next);
                } else {
                    return Math.min(prev, next);
                }
                break;
        }
    }
}

solve(['5 1',
    '9 0 2 4 1'
]);
solve(['10 3',
    '1 9 1 9 1 9 1 9 1 9']);
solve(['10 10',
    '0 1 2 3 4 5 6 7 8 9']);
solve(['65 0',
    '2 2 6 0 1 3 6 3 7 7 0 6 3 3 1 1 2 0 4 4 1 0 4 1 1 3 2 0 8 1 9 0 9 3 5 7 4 5 6 4 3 9 6 1 1 0 9 6 0 0 7 5 5 8 4 8 0 0 0 1 0 7 0 1 0']);