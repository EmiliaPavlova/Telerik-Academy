function solve(input) {

    function convertToObject(array) {
        var result = [];
        for (var i = 0, index = 0; i < array.length / 3; i++, index += 3) {
            result[i] = {};
            result[i].firstname = array[index];
            result[i].lastname = array[index+1];
            result[i].age = +array[index+2];
        }
        return result;
    }

    var people = convertToObject(input);
    people.sort(function(a, b) {
        return a.age - b.age;
    });

    console.log(people[0].firstname + ' ' + people[0].lastname);
}

solve([
    'Gosho', 'Petrov', '32',
    'Bay', 'Ivan', '81',
    'John', 'Doe', '42'
]);
solve([
    'Penka', 'Hristova', '61',
    'System', 'Failiure', '88',
    'Bat', 'Man', '16',
    'Malko', 'Kote', '72'
]);