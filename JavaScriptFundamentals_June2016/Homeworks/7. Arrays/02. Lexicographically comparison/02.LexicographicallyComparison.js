function solve(input) {
    var array1 = input[0],
        array2 = input[1],
        i;

    if(array1 > array2) {
        console.log('>');
    } else if(array1 < array2) {
        console.log('<');
    } else {
        console.log('=');
    }
}

solve(['hello',
    'halo']);

solve(['food',
    'food']);
