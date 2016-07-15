function solve(input) {

    function hasProperty(obj, property) {
        var proto = obj.__proto__|| obj.constructor.prototype;
        return (property in obj) && (!(property in proto) || proto[property] !== obj[property]);
    }

    var prop = 'firstname',
        result = hasProperty(input, prop);

    console.log(result);
}

solve({ firstname: 'Gosho', lastname: 'Petrov', age: 32 });