
const thumbList = document.getElementById("thumb-list");
thumbList.style.border = "2px solid blue";


const textarea = document.querySelector("textarea");
const paragraph = document.querySelector("p");
textarea.value = paragraph.textContent;

const images = document.querySelectorAll("#thumb-list img");
for (let img of images) {
    img.style.boxShadow = "5px 5px 5px rgba(0,0,0,0.5)";
}
