let imagenumber = 1;
const maxImages = 5;

function moveimage(d) {
  imagenumber += d;
  if (imagenumber > maxImages) {
    imagenumber = 1;
  }
  if (imagenumber < 1) {
    imagenumber = maxImages;
  }
  loadImage();
}

function loadImage() {
  const img = document.getElementById("mainImage");
  const source = "Images/image" + imagenumber + ".jpeg";
  img.src = source;
}

function onLoad() {
  loadImage();
}

function validateSignupForm() {
  let b = true;

  b = b && validateText("First name", document.getElementById("fname"));
  b = b && validateText("Last name", document.getElementById("lname"));
  b = b && validateText("Address", document.getElementById("address"));
  b = b && validateText("Password", document.getElementById("password"));
  b = b && validateText("Birthday", document.getElementById("dob"));
  return b;
}

function validateText(name, val) {
  og = val;
  val = val.value;

  if (!val || val.length == 0) {
    og.style.border = "3px solid red";
    setTimeout(function () {
      alert(name + " cannot be empty");
    }, 10);
    og.focus();
    return false;
  }
  if (val.indexOf("@") > 0) {
    og.style.border = "3px solid red";
    setTimeout(function () {
      alert(name + " cannot contain a strudle");
    }, 10);
    og.focus();
    return false;
  }
  if (val.indexOf("#") > 0) {
    og.style.border = "3px solid red";
    setTimeout(function () {
      alert(name + " cannot contain a hashtag");
    }, 10);
    og.focus();
    return false;
  }
  if (val.indexOf("%") > 0) {
    og.style.border = "2px solid red";
    setTimeout(function () {
      alert(name + " cannot contain a percentage sign");
    }, 10);
    og.focus();
    return false;
  }
  if (val.indexOf("*") > 0) {
    og.style.border = "3px solid red";
    setTimeout(function () {
      alert(name + " cannot contain an asterisk");
    }, 10);
    og.focus();
    return false;
  }

  return true;
}

function maxDay() {
  var currentDate = new Date();
  var formattedDate = currentDate.toISOString().split("T")[0];
  document.getElementById("logDate").max = formattedDate;
}

function validateFlightLog() {
  let b = true;
  b = b && validateText("Date", document.getElementById("logDate"));
  b = b && validateText("Callsign", document.getElementById("callsign"));
  b =
    b &&
    validateText("Time of Departure", document.getElementById("logTakeoff"));
  b =
    b &&
    validateText(
      "Airport of Departure",
      document.getElementById("logAirportTakeoff")
    );
  b =
    b && validateText("Time of Landing", document.getElementById("logLanding"));
  b =
    b &&
    validateText(
      "Airport of Destination",
      document.getElementById("logAirportLanding")
    );
  b =
    b && validateText("Model of Aircraft", document.getElementById("logModel"));
  return b;
}

function contactUs() {
  document.location.href = "mailto:oded@benamotz.com";
}

function deleteFlight(id) {
  if (!confirm("Are you sure you want to delete this flight?")) {
    return false;
  }

  document.location.href = `flight.aspx?id=${id}&action=del`;
  return false;
}
