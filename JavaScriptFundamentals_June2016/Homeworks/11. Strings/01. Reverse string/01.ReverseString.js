function solve(input) {
    var token = input[0],
        result = '';

    result = reverse(token);
    console.log(result);

    function reverse(input) {
        var o = '';
        for (var i = input.length - 1; i >= 0; i--)
            o += input[i];
        return o;
    }
}

solve([ 'sample' ]);
solve([ 'qwertytrewq' ]);