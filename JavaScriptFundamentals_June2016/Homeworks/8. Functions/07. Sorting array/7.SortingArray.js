function solve(input) {
    var n = +input[0],
        array = input[1].split(' ').map(Number);

    if(array.length > 1) {
        array.sort(function(a, b) {
            return a - b;
        })
    }
    console.log(array.join(' '));
}

solve(['6', '3 4 1 5 2 6']);
solve(['10', '36 10 1 34 28 38 31 27 30 20']);