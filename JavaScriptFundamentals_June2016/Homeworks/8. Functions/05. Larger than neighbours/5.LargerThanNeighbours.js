function solve(input) {
    var array = input[0].split('\n'),
        n = +array.shift(),
        count = 0;

    array = array[0].split(' ').map(Number);

    for (var i = 1; i < array.length - 1; i++) {
        if(array[i - 1] < array[i] && array[i + 1] < array[i]) {
            count++;
        }
    }

    console.log(count);
}

solve(['6\n-26 -25 -28 31 2 27']);
solve(['1\n5']);
solve(['3\n1 4 3']);