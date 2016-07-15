function solve(input) {
    var array = input[0].split('\n').map(Number),
        n = array.shift(),
        currentFrequency = 1,
        maxFrequency = 0,
        frequentNumber,
        i;

    array.sort();

    for (i = 0; i < n - 1; i++) {
        if(array[i] == array[i + 1]) {
            currentFrequency++;
        } else {
            currentFrequency = 1;
        }

        if(currentFrequency > maxFrequency) {
            maxFrequency = currentFrequency;
            frequentNumber = array[i];
        }
    }

    console.log('%d (%d times)', frequentNumber, maxFrequency)
}

solve(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);