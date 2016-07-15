function solve(people) {

    function groupedByAge(array, property) {
        var result = {};
        for (var i in array) {
            var searchProperty = array[i][property];
            if (!result[searchProperty]) {
                result[searchProperty] = [];
            }
            result[searchProperty].push(array[i]);
        }

        return result;
    }

    console.log(groupedByAge(people, 'age'));
}

solve([
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'John', lastname: 'Doe', age: 42 },
    { firstname: 'Pesho', lastname: 'Pesho', age: 22 },
    { firstname: 'Asdf', lastname: 'Xyz', age: 81 },
    { firstname: 'Gosho', lastname: 'Gosho', age: 22 }
]);