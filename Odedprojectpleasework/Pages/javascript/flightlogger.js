const today = new Date();
const hour = String(today.getHours()).padStart(2, "0");
const minutes = String(today.getMinutes()).padStart(2, "0");

var dd = today.getDate();

var mm = today.getMonth() + 1;
var yyyy = today.getFullYear();
if (dd < 10) {
  dd = "0" + dd;
}

if (mm < 10) {
  mm = "0" + mm;
}
todayDate = yyyy + "-" + mm + "-" + dd;
let time = hour + ":" + minutes;

document.addEventListener("DOMContentLoaded", function () {
  document.getElementById("logTakeoff").value = time;
  document.getElementById("logLanding").value = time;
  document.getElementById("logDate").value = todayDate;
});
