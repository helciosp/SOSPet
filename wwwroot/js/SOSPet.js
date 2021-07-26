let show = true; 

const menuSection = document.querySelector("#header")
const menuToggle = menuSection.querySelector(".hamburger")
const link = menuSection.querySelector("a")

menuToggle.addEventListener("click", () => {

    document.body.style.overflow = show ? "hidden" : "initial"

    menuSection.classList.toggle("on", show)
    show = !show;
})

link.addEventListener("click", () => {

    menuSection.classList.toggle("off")
})
