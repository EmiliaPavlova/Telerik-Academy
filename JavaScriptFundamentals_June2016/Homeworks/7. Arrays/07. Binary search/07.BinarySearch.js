function solve(input) {
    var array = input[0].split('\n').map(Number),
        number = array.shift(),
        search = array.pop(),
        i;

    console.log(array.indexOf(search));
}

solve(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32']);