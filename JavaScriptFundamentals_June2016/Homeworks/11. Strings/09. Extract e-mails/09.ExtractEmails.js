function solve(input) {
    var text = input[0],
        regex = /\s([a-zA-Z0-9][\w\.\-]+@[a-zA-Z0-9][a-zA-Z\-\.]+\.[a-zA-Z]+)/g,
        match,
        result = [];

    while (match = regex.exec(text)) {
        result.push(match[1]);
    }

    console.log(result.join(', '));
}

solve(['Please contact us at: support@github.com.']);
solve(['Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.']);
solve(['Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.']);