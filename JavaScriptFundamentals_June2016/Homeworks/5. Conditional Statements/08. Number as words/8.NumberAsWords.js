function solve(input) {
    var number = Number(input),
        result = '',
        ones = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'],
        tens = ['twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'],
        result,
        digitOnes,
        digitTens,
        digitHundreds;
    
    digitOnes = number % 10 | 0;
    digitTens = number % 100 / 10 | 0;
    digitHundreds = number / 100 | 0;

    if(number === 0) {
        result = ones[0];
    }

    if (digitHundreds !== 0) {
        result = ones[digitHundreds] + ' hundred';
        if(digitTens !== 0 || digitOnes !== 0) {
            result += ' and ';
        }
    }

    if((number % 100 | 0) > 9 && (number % 100 | 0) < 20) {
        result += ones[number % 100 | 0];
    } else {
        if (digitTens > 1) {
            result += tens[digitTens - 2];
        }

        if (digitTens !== 0 && digitOnes !== 0) {
            result += ' ';
        }

        if (digitOnes !== 0) {
            result += ones[digitOnes];
        }
    }

    String.prototype.uppercaseFirst = function()
    {
        return this.charAt(0).toUpperCase() + this.substr(1);
    };

    console.log(result.uppercaseFirst());
}

solve(112);
solve(1);
solve(9);
solve(10);
solve(12);
solve(19);
solve(25);
solve(98);
solve(273);
solve(400);
solve(501);
solve(617);
solve(711);
solve(999);