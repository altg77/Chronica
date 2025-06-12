function toggleDetalhes(elem) {
  const seta = elem.querySelector(".seta");
  const detalhes = elem.nextElementSibling;

  detalhes.classList.toggle("active");

  seta.classList.toggle("rotated");

  if (detalhes.style.display === "none" || detalhes.style.display === "") {
    detalhes.style.display = "block";
    seta.innerHTML = "&#9650;"; 
  } else {
    detalhes.style.display = "none";
    seta.innerHTML = "&#9660;"; 
  }
}