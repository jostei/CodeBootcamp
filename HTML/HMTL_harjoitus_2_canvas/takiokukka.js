var tc = document.getElementById("takioCanvas");
var tctx = tc.getContext("2d");

tctx.beginPath();
tctx.fillStyle = "lightGreen";
tctx.fillRect(195, 150, 10, 450);
tctx.stroke();

tctx.beginPath();
tctx.fillStyle = "lightGreen";
tctx.ellipse(230, 400, 15, 40, Math.PI / 4, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "white";
tctx.ellipse(250, 100, 15, 40, Math.PI/4, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "white";
tctx.ellipse(150, 100, 15, 40, 3*Math.PI/4, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "white";
tctx.ellipse(150, 200, 15, 40, Math.PI/4, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "white";
tctx.ellipse(250, 200, 15, 40, 3*Math.PI/4, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "white";
tctx.ellipse(260, 150, 15, 40, 2*Math.PI/4, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "white";
tctx.ellipse(140, 150, 15, 40, 2*Math.PI/4, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "white";
tctx.ellipse(200, 210, 15, 40, 0*Math.PI/4, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "white";
tctx.ellipse(200, 85, 15, 40, 0*Math.PI/4, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "yellow";
tctx.arc(200, 150, 40, 0, 2 * Math.PI);
tctx.fill();

tctx.beginPath();
tctx.fillStyle = "green";
tctx.fillRect(0, 500, 400, 600);
tctx.stroke();