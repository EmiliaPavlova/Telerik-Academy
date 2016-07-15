function solve(input) {
    var array = input[0].split('\n'),
        number = array.shift(),
        maxSequence = 0,
        currentSequence = 1,
        i;

    for (i = 0; i < array.length - 1; i++) {
        if(array[i] === array[i + 1]) {
            currentSequence++;
            if(currentSequence > maxSequence) {
                maxSequence = currentSequence;
            }
        } else {
            currentSequence = 1;
        }
    }

    console.log(maxSequence);
}

solve(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']);