function solve(input) {
    var array = input[0].split('\n'),
        n = +array.shift(),
        index;

    array = array[0].split(' ').map(Number);

    function firstLarger(array) {
        for (var i = 1; i < array.length - 1; i++) {
            if(array[i - 1] < array[i] && array[i + 1] < array[i]) {
                return i;
            }
        }
    }

    index = firstLarger(array);

    if(index) {
        console.log(firstLarger(array));
    } else {
        console.log('-1');
    }
}

solve(['6\n-26 -25 -28 31 2 27']);
solve(['1\n5']);
solve(['4\n1 3 4 2']);