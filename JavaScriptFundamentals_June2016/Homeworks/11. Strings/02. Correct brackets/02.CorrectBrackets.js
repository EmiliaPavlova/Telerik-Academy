function solve(input) {
    var string = input[0],
        brackets = {
            '(': 0,
            ')': 0
        };

    for (var c in string) {
        if(string[c] === '(') {
            brackets['(']++;
        }
        if(string[c] === ')') {
            brackets[')']++;
        }
    }
    console.log(brackets['('] === brackets[')'] ? 'Correct' : 'Incorrect');
}

solve([ '((a+b)/5-d)' ]);
solve([ ')(a+b))' ]);