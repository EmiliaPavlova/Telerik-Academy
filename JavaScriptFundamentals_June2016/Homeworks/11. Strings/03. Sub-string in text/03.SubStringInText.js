function solve(input) {
    var search = input[0].toLowerCase(),
        text = input[1].toLowerCase(),
        occurences = 0,
        pos = text.indexOf(search);

    while(pos !== -1) {
        occurences++;
        pos = text.indexOf(search, ++pos);
    }

    console.log(occurences);
}

solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);