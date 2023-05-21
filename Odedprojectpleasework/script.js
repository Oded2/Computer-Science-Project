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

function validateSignupForm(event) {
  let b = true;
  b = b && validateText("First name", document.getElementById("fname").value);
  b = b && validateText("Last name", document.getElementById("lname").value);
  b = b && validateText("Address", document.getElementById("address").value);
  b = b && validateText("Password", document.getElementById("password").value);
  return b;
}

function validateText(name, val) {
    if (!val || val.length == 0) {
        alert(name + " cannot be empty");
        return false;
    }
    if (val.indexOf("@") > 0) {
        alert(name + " cannot contain a strudel");
        return false;
    }
    if (val.indexOf("#") > 0) {
        alert(name + " cannot contain a hashtag");
        return false;
    }
    if (val.indexOf("%") > 0) {
        alert(name + " cannot contain a percentage");
        return false;
    }
    if (val.indexOf("*") > 0) {
        alert(name + " cannot contain an asterisk");
        return false;
    }

  return true;
}
