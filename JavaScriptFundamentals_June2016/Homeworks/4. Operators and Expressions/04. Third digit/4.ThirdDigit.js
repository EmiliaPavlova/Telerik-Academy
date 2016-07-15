function solve(input) {
    var number = Number(input);
    number = Math.floor(number / 100) % 10;
    if(number === 7) {
        console.log('true');
    } else {
        console.log('false %d', number);
    }
}

solve(5);
solve(701);
solve(9703);
solve(877);
solve(777877);
solve(9999799);