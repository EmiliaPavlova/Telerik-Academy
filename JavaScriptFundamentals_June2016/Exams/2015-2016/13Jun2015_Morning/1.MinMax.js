function solve(input) {
    var n = +input[0],
        k = +input[1],
        numbers = input[2].split(' ').map(Number),
        result = [];

    Array.prototype.max = function() {
        return Math.max.apply(null, this);
    };

    Array.prototype.min = function() {
        return Math.min.apply(null, this);
    };

    for (let i = 0; i <= n - k; i++) {
        var nums = numbers.slice(i, i + k),
            min = nums.min(),
            max = nums.max();
        result.push(min + max);
    }

    console.log(result.join(','));
}

solve([
    '4',
    '2',
    '1 3 1 8'
]);
solve([
    '5',
    '3',
    '7 7 8 9 10'
]);
solve([
    '8',
    '4',
    '1 8 8 4 2 9 8 11'
]);