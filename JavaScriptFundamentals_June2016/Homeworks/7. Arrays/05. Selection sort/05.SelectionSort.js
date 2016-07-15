function solve(input) {
    var array = input[0].split('\n').map(Number),
        number = array.shift(),
        min,
        i,
        j;

    for (i = 0; i < array.length; i++) {
        min = array[i];
        for (j = i; j < array.length; j++) {
            if(array[j] < min) {
                min = array[j];
                array[j] = array[i];
                array[i] = min;
            }
        }
    }

    //arrayDistinct.sort(function(a, b) {
    //    return a - b;
    //});

    console.log(array.join('\n'));
}

solve(['6\n3\n4\n1\n5\n2\n6']);
solve(['10\n36\n10\n1\n34\n28\n38\n31\n27\n30\n20']);