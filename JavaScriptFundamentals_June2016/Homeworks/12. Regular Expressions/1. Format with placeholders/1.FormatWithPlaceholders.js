function solve(input) {
    String.prototype.format = function(placeholders) {
        var result = this;
        for (var prop in placeholders) {
            result = result.replace(new RegExp('#{' + prop + '}', 'g'), placeholders[prop]);
        }
        return result;
    };

    var str = JSON.parse(input[0]),
        result = input[1].format(str);

    console.log(result);
}

solve([
    '{ "name": "John", "age": 13 }', // options as JSON
    'My name is #{name} and I am #{age}-years-old' // template
]);