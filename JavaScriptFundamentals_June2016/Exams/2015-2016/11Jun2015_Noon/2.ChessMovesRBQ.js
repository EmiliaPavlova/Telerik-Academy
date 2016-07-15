function solve(input) {
    var r = Number(input[0]),
        //c = Number(input[1]),
        board = input.slice(2, 2 + r),
        //t = Number(input[r + 2]),
        moves = input.slice(r + 3);

    function parseMove(move) {
        let cells = move.split(' ');
        return {
            from: {
                r: r - Number(cells[0][1]),
                c: cells[0].charCodeAt(0) - 97
            },
            to: {
                r: r - Number(cells[1][1]),
                c: cells[1].charCodeAt(0) - 97
            }
        }
    }

    function canMoveRook(from, to) {
        if((from.c !== to.c) && (from.r !== to.r)){
            return false;
        }

        if((from.c === to.c) && (from.r === to.r)) {
            return false;
        }

        let deltaR = from.r > to.r ? -1 : 1,
            deltaC = from.c > to.c ? -1 : 1;

        if(from.r === to.r) {
            deltaR = 0;
        } else {
            deltaC = 0;
        }

        while((from.r !== to.r) || (from.c !== to.c)) {
            from.r += deltaR;
            from.c += deltaC;

            if(board[from.r][from.c] !== '-') {
                return false;
            }
        }

        return true;
    }

    function canMoveBishop(from, to) {
        if(Math.abs(from.r - to.r) !== Math.abs(from.c - to.c)) {
            return false;
        }

        if((from.c === to.c) && (from.r === to.r)) {
            return false;
        }

        var deltaR = from.r > to.r ? -1 : 1,
            deltaC = from.c > to.c ? -1 : 1;

        while((from.r !== to.r) || (from.c !== to.c)) {
            from.r += deltaR;
            from.c += deltaC;

            if(board[from.r][from.c] !== '-') {
                return false;
            }
        }

        return true;
    }

    function canMoveQueen(from, to) {
        return canMoveRook(from, to) || canMoveBishop(from, to);
    }

    for (let m of moves) {
        let move = parseMove(m);

        let figure = board[move.from.r][move.from.c];
        let canMove;
        switch(figure) {
            case 'R':
                canMove = canMoveRook(move.from, move.to);
                console.log(canMove ? 'yes' : 'no');
                break;
            case 'B':
                canMove = canMoveBishop(move.from, move.to);
                console.log(canMove ? 'yes' : 'no');
                break;
            case 'Q':
                canMove = canMoveQueen(move.from, move.to);
                console.log(canMove ? 'yes' : 'no');
                break;
            default:
                console.log('no');
                break;
        }
    }
}

solve([
    '3',
    '4',
    '--R-',
    'B--B',
    'Q--Q',
    '12',
    'd1 b3',
    'a1 a3',
    'c3 b2',
    'a1 c1',
    'a1 b2',
    'a1 c3',
    'a2 b3',
    'd2 c1',
    'b1 b2',
    'c3 b1',
    'a2 a3',
    'd1 d3'
]);