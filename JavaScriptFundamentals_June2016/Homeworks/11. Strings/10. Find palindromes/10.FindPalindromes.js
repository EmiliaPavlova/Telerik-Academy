function solve(input) {
    var text = input[0],
        regex = /\s*[\s+,\.?!]\s*/g,
        words = text.split(regex),
        palindromes = [];

    words.forEach(function(word) {
        if(isPalindrome(word)) {
            palindromes.push(word);
        }
    });

    console.log(palindromes);

    function isPalindrome(word) {
        var length = word.length,
            i;
        for (i = 0; i < length; i++) {
            if (word[i] !== word[length - 1 - i]) {
                return false;
            }
        }

        return true;
    }
}

solve(['Hi,exe? ABBA! Hog fully a string. Bob']);