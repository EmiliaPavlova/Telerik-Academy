function solve(number) {
    if(number % 35 == 0) {
        console.log("true %d", number);
    } else {
        console.log("false %d", number);
    }
}

solve(3);
solve(0);
solve(5);
solve(7);
solve(35);
solve(140);