function solve(input) {
    Array.prototype.max = function() {
        return Math.max.apply(null, this);
    };

    var numbers = input[0].split(' ').map(Number),
        peaks = [0],
        maxRocks = 0,
        valley = [],
        sums = [];;

    for (var i = 1; i < numbers.length; i++) {
        if(numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]) {
            peaks.push(i);
        }
    }

    peaks.push(numbers.length - 1); // the last peak;

    for (var j = 0; j < peaks.length - 1; j++) {
        //valley.push(numbers[peaks[j]]);
        var sum = 0;
        for (var k = peaks[j]; k <= peaks[j + 1]; k++) {
            valley.push(numbers[k]);

        }

        for (var s = 0; s < valley.length; s++) {
            sum += valley[s];

        }
        //console.log(sum);
        sums.push(sum);
        valley = [];
    }

    console.log(sums.max());
}

solve(["5 1 7 4 8"]);
solve(["5 1 7 6 5 6 4 2 3 8"]);