// Hello world parilla eri tyylillä
const heippa = "Hello World!";
let uusHeippa = "";

console.log(heippa);

for(let i of heippa){
    uusHeippa += `${i} `;
}

console.log(uusHeippa);