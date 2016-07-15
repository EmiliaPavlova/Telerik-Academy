function solve(input) {
    var number = Number(input),
        bit;
    bit = number >> 3 & 1;
    console.log(bit);
}

solve(15);
solve(1024);