/**
 * The function counts down from 10 and redirects to a login page when the countdown reaches 0.
 * @returns If the counter reaches 0, the function returns and redirects the user to the login page.
 * Otherwise, the function continues to countdown and update the timer on the webpage. There is no
 * specific value being returned in this code.
 */
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
