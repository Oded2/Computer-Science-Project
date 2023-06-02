var currentImage = document.getElementById("current-image");
const imageThumbs = document.getElementById("image-thumbs");
var selectedThumb = null;
var selectedImage = 0;
const max = 24;
const timeBetween = 5000;

/* This code adds an event listener to the `document` object, which listens for the "DOMContentLoaded"
event. This event is fired when the initial HTML document has been completely loaded and parsed,
without waiting for stylesheets, images, and subframes to finish loading. When this event is fired,
the function passed as the second argument to `addEventListener` is executed. In this case, the
function calls the `init()` function to initialize the gallery, and then sets a timeout to call the
`autoMove()` function after a specified delay (`timeBetween`). This causes the gallery to
automatically cycle through the images at a regular interval. */
document.addEventListener("DOMContentLoaded", function () {
  init();
  window.setTimeout(autoMove, timeBetween);
});

/**
 * The function autoMove repeatedly calls the function moveImage with a delay specified by the variable
 * timeBetween.
 */
function autoMove() {
  moveImage(1);
  window.setTimeout(autoMove, timeBetween);
}

function init() {
  for (var i = 1; i <= max; i++) {
    const thumb = document.createElement("img");
    thumb.src = "../../Gallery/images/image (" + i + ").jpeg"; 
    thumb.alt = "Image " + i;
    thumb.id = "thumb-" + i;
    thumb.setAttribute("imageId", i);
    thumb.classList.add("thumb");
    thumb.classList.add("thumb-regular");

    imageThumbs.appendChild(thumb);
    thumb.addEventListener("click", function () {
      const newId = this.getAttribute("imageId");
      currentImage.src = "../../Gallery/images/image (" + newId + ").jpeg";
      currentImage.alt = "Image #" + newId;
      selectedImage = newId;
      this.classList.add("thumb-selected");
      if (selectedThumb) {
        selectedThumb.classList.remove("thumb-selected");
      }
      this.scrollIntoView();
      selectedThumb = this;
    });
    if (i == 1) {
      thumb.click();
    }
  }
}

/* This code adds an event listener to the `currentImage` element, which is an `<img>` tag representing
the currently displayed image in the gallery. When the user clicks on this image, the code opens a
new window/tab with the URL of the image (`currentImage.src`) using the `_blank` target, which
specifies that the URL should be opened in a new window/tab. This allows the user to view the image
in a larger size or download it, for example. */
currentImage.addEventListener("click", () => {
  window.open(currentImage.src, "_blank");
});

/**
 * The function moves an image by selecting the next or previous thumbnail and clicking on it.
 * @param d - The parameter "d" is a number representing the direction in which the image should be
 * moved. A positive value of "d" will move the image to the right or forward, while a negative value
 * of "d" will move the image to the left or backward.
 * @returns If the `t` variable is `null`, the function will return nothing (i.e., `undefined`).
 * Otherwise, the function does not have a return statement specified, so it will also return
 * `undefined` by default.
 */
function moveImage(d) {
  var newId = Number(selectedImage) + d;

  if (newId > max) {
    newId = 1;
  }
  const t = document.getElementById("thumb-" + newId);
  if (t == null) {
    return;
  }
  t.click();
}
