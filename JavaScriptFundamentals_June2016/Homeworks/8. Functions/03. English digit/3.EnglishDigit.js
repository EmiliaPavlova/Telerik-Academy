function solve(input) {
    var number = Number(input),
        digit = getLastDigit(number);

    function getLastDigit(number) {
        return Math.floor(number % 10);
    }

    function printDigitAsWord(digit) {
        switch (digit) {
            case 0: return 'zero';
            case 1: return 'one';
            case 2: return 'two';
            case 3: return 'three';
            case 4: return 'four';
            case 5: return 'five';
            case 6: return 'six';
            case 7: return 'seven';
            case 8: return 'eight';
            case 9: return 'nine';
            default: break;
        }
    }

    console.log(printDigitAsWord(digit));
}

solve(42);