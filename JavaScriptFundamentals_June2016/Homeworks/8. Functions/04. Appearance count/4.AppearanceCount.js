function solve(args) {
    var input = args[0].split('\n'),
        n = input.shift(),
        x = input.pop(),
        numbers = input[0].split(' ').map(Number);

    function countOccurrences(array, number) {
        var count = 0;
        for (var i = 0; i < array.length; i++) {
            if(array[i] === +number) {
                count++;
            }
        }

        return count;
    }

    console.log(countOccurrences(numbers, x));
}

solve(['8\n28 6 21 6 -7856 73 73 -56\n73']);