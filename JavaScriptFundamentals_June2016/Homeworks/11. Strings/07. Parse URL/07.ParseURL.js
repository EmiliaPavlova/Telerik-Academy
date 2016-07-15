function solve(input) {
    var address = input[0],
        tokens = address.split('://'),
        protocol = tokens[0],
        server = tokens[1].split('/')[0],
        resource = tokens[1].replace(server, '');

    console.log('protocol: ' + protocol);
    console.log('server: ' + server);
    console.log('resource: ' + resource);
}

solve([ 'http://telerikacademy.com/Courses/Courses/Details/239' ]);