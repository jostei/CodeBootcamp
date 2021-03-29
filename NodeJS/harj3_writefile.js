//import * as fs from 'fs';
const fs = require('fs');

let data = "testi";

fs.writeFileSync("exampleFile.txt", data);