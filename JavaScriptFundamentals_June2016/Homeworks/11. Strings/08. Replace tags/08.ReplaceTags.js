function solve(input) {
    var text = input[0],
        regex = /<a\s*href\s*="(.*?)">(.*?)<\/a>/g,
        result;

    result = text.replace(regex, function(none, href, content) {
        return '[' + content + '](' + href + ')';
    });

    console.log(result);
}

solve(['<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>']);