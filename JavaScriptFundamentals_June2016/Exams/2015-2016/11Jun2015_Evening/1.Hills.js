function solve(input) {
    var numbers = input[0].split(' ').map(Number),
        peaks = [0],
        maxRocks = 0;

    for (var i = 1; i < numbers.length; i++) {
        if(numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]) {
            peaks.push(i);
        }
    }

    peaks.push(numbers.length - 1); // the last peak;

    for (var j = 1; j < peaks.length; j++) {
        maxRocks = Math.max(maxRocks, peaks[j] - peaks[j - 1]);
    }

    //console.log(peaks);
    console.log(maxRocks);
}

solve(['5 1 7 4 8']);
solve(['5 1 7 6 3 6 4 2 3 8']);
solve(['10 1 2 3 4 5 4 3 2 1 10']);
//solve(['83725 7468 9499 34215 46501 71571 92125 19662 70303 83853']);
//solve(['75398 72157 64909 1596 51040 62821 63209 64141 64396 68577 74331 54781 678 2711 9274 9387 43122 49117 49815 52546 59650 69508 71429 84592 86366 91169 98094 99138 93223 78595 11998 13809 18959 34688 55957 79708 60447 34420 26667 20051 21531 42852']);