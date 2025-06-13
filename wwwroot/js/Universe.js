document.querySelectorAll("details").forEach((detail) => {
    detail.addEventListener("toggle", () => {
        const arrow = detail.querySelector(".seta");
        if (detail.open) {
            arrow.classList.add("rotated");
        } else {
            arrow.classList.remove("rotated");
        }
    });
});