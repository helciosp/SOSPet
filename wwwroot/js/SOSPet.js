let show = true;

const menuSection = document.querySelector("#header")
const menuToggle = menuSection.querySelector(".hamburger")

const footer = document.querySelector("footer")

menuToggle.addEventListener("click", () => {

    document.body.style.overflow = show ? "hidden" : "initial"

    menuSection.classList.toggle("on", show)
    show = !show;
})

$(document).ready(function () {
    let alturaViewport = $(window).height();
    let alturaElemento = $("main").height();
    let distanciaTopo = $("main").offset().top;
    let diferenca = alturaElemento - alturaViewport;

    $(window).scroll(function () {

        let posicaoScroll = $(window).scrollTop();

        if (posicaoScroll < (distanciaTopo + diferenca)) {
            footer.style.position = "fixed"
        }
        else {
            footer.style.position = "initial"
        }
    });
});