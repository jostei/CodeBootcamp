const fs = require('fs');

let data = fs.readFileSync('./numeroDir/numerot.txt', {encoding:'utf8'});

let datalist = data.toString().split("\r\n");

let summa = 0;
for(let numero of datalist){
    summa += parseInt(numero);
}

console.log(summa);