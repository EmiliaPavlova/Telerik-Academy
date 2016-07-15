function solve(input) {
    var text = input[0],
        pattern = '&nbsp;',
        result;

    String.prototype.replaceAll = function(search, replacement) {
        var target = this;
        return target.split(search).join(replacement);
    };

    result = text.replaceAll(' ', pattern);

    console.log(result);
}

solve([ 'hello world' ]);
solve([ 'This text contains 4 spaces!!' ]);
