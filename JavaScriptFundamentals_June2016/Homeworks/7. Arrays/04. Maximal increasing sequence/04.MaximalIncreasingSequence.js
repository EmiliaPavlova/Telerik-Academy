function solve(input) {
    var array = input[0].split('\n').map(Number),
        number = array.shift(),
        maxSequence = 0,
        currentSequence = 1,
        i;

    for (i = 0; i < array.length - 1; i++) {
        if(array[i] < array[i + 1]) {
            currentSequence++;
        } else {
            currentSequence = 1;
        }

        if(currentSequence > maxSequence) {
            maxSequence = currentSequence;
        }
    }

    console.log(maxSequence);
}

//solve(['8', '7', '3', '2', '3', '4', '2', '2', '4']);
solve(['8\n7\n3\n2\n3\n4\n2\n2\n4']);