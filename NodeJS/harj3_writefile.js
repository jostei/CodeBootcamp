// Kirjoittaa oheiseen tiedostoon tekstiä
const fs = require('fs');

let data = "testi";

fs.writeFileSync("exampleFile.txt", data);