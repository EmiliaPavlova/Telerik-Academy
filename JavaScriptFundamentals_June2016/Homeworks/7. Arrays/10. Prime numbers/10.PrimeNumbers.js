function solve(input) {
    var n = Number(input),
        isPrime,
        i,
        j;

    for (i = n; i >= 0; i--) {
        isPrime = true;
        for (j = 2; j <= Math.sqrt(i); j++) {
            if(i % j === 0) {
                isPrime = false;
                break;
            }
        }

        if(isPrime === true) {
            console.log(i);
            break;
        }
    }
}

solve(13);
solve(126);
solve(26);