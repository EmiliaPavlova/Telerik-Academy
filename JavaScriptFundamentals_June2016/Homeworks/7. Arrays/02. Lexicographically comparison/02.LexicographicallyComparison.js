function solve(input) {
    var string = input[0].split("\n"),
        array1 = string[0],
        array2 = string[1],
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