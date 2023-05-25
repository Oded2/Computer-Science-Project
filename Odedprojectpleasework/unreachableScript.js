counter = 10;
function countdown() {
  document.getElementById("timer").innerText = counter;
  if (counter == 0) {
    document.location.replace("login.aspx");
    return;
  }
  counter--;
  window.setTimeout(countdown, 1000);
}
document.addEventListener("DOMContentLoaded", countdown);
