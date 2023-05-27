var currentImage = document.getElementById("current-image");
const imageThumbs = document.getElementById("image-thumbs");
var selectedThumb = null;
var selectedImage = 0;
const max = 24;


for (var i = 1; i <= max; i++) {
	const thumb = document.createElement("img");
	thumb.src = "Gallery/images/image (" + i + ").jpeg";
	console.log(thumb.src);
	thumb.alt = "Image " + i;
	thumb.id = "thumb-" + i;
	thumb.setAttribute("imageId",i);
	thumb.classList.add("thumb");
	thumb.classList.add("thumb-regular")

	imageThumbs.appendChild(thumb);
	thumb.addEventListener(
		"click", function () {
			const newId = this.getAttribute("imageId");
			currentImage.src = "Gallery/images/image (" + newId + ").jpeg";
			currentImage.alt = "Image #" + newId;
			selectedImage = newId;
			this.classList.add("thumb-selected");
			if (selectedThumb) {
				selectedThumb.classList.remove("thumb-selected")
			}
			this.scrollIntoView();
			selectedThumb = this;
		}
	);
	if (i==1) {
		thumb.click();
	}

}


currentImage.addEventListener("click" , () => {
	window.open(currentImage.src,"_blank");
})

function moveImage(d) {
	const newId = Number(selectedImage) +d;
	const t = document.getElementById("thumb-" + newId)
	if (t==null) {
		return;
	}
	t.click();
}