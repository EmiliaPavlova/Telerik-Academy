function solve(input){
    var number = Number(input),
        i,
        isPrime = true;

    if (number < 2){
        isPrime = false;
    } else {
        for (i = 2; i <= Math.sqrt(number); i++){
            if(number % i == 0){
                isPrime = false;
            }
        }
    }

    console.log(isPrime);
}

solve(2);
solve(23)
solve(-3);
solve(0);
solve(1);