function solve(input) {
    var regex = /<.*?>/g,
        result = '',
        i;

    for (i = 0; i < input.length; i++) {
        var line = input[i];
        if(regex.test(line)) {
            line = line.replace(regex, '').trim();
        }

        result += line.trim();
    }

    console.log(result);
}

solve([
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
]);