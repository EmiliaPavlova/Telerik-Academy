function solve(input) {
    var numbers = input[0].split(' ').map(Number),
        a = numbers[0],
        b = numbers[1],
        c = numbers[2];

    function getMax(a, b) {
        if(a > b) {
            return a;
        } else {
            return b;
        }
    }

    console.log(getMax(getMax(a, b), c));
}

solve(['8 3 6']);
solve(['7 19 19']);