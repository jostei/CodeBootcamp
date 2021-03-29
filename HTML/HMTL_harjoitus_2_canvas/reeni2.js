console.log("Logitesti");

document.getElementById("demo").innerHTML = "JavaScriptillä lisätty teksti.";

var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");

var cw = c.width;
var ch = c.height;

ctx.beginPath();
ctx.lineWidth = "4";
ctx.strokeStyle = "black";
ctx.arc(100, 50, 40, 0, 2 * Math.PI);
ctx.stroke();

ctx.beginPath();
ctx.lineWidth = "6";
ctx.strokeStyle = "blue";
ctx.rect(0, 0, 200, 100);
ctx.stroke();