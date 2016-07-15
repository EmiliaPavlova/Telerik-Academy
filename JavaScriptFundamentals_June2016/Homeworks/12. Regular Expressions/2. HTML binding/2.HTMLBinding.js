function solve(input) {
    var obj = JSON.parse(input[0]),
        text = input[1].replace(/'/, '"'),
        regex = /data-bind-(.*?)="(.*?)"/gmi,
        match;

    while(match = regex.exec(text)){
        var index = text.indexOf('>');
        if (text[index - 1] === '/') { // if tag is self closing
            index--;
        }

        var field = match[1];
        if (field.toLowerCase() === 'content') {
            var arr = text.split('');
            var x = arr.splice(index + 1, 0, obj[match[2]]);
            text = arr.join('');
        }

        else {
            var arr2 = text.split('');
            var x2 = arr2.splice(index, 0, " " + field + '="'+ obj[match[2]] + '"');
            text = arr2.join('');
        }
    }

    console.log(text);
}

solve([
    '{ "name": "Steven" }',
    '<div data-bind-content="name"></div>'
]);
solve([
    '{ "name": "Elena", "link": "http://telerikacademy.com" }',
    '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></а>'
]);