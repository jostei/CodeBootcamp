// Funktio summaa annetut argumentit yhteen 
function summa() {
    var s = 0;
    for (var i = 0; i < arguments.length ; i++){
        s += arguments [i];
    }
    return s;
}

console.log(summa(1, 2)); // palauttaa 3

console.log(summa(1, 2, 3)); // palauttaa 6