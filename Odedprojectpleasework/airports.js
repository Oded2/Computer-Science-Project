document.addEventListener("DOMContentLoaded", function () {
  drawFlightPath();
});

function drawFlightPath() {
  console.log("ima");
  var canvas = document.getElementById("airportsCanvas");
  var ctx = canvas.getContext("2d");

  var img = new Image();
  img.src = "Images/airportsmap.jpg";
  img.onload = function () {
    ctx.drawImage(img, 0, 0);
    var startX = 199;
    var startY = 695;
    var endX = 207;
    var endY = 32;

    // Draw a line between the two points
    ctx.beginPath();
    ctx.moveTo(startX, startY);
    ctx.lineTo(endX, endY);
    ctx.strokeStyle = "blue";
    ctx.lineWidth = 5;
    ctx.stroke();
  };
}
