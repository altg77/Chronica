// Expands or collapses the ability details
function toggleDetalhes(elem) {
  const seta = elem.querySelector(".seta");
  const detalhes = elem.nextElementSibling;

  // Toggle the 'active' class for the details to control max-height
  detalhes.classList.toggle("active");

  // Toggle the 'rotated' class for the arrow
  seta.classList.toggle("rotated");

  // Update the arrow icon based on visibility (optional, can be done with CSS rotation)
  if (detalhes.classList.contains("active")) {
    seta.innerHTML = "&#9650;"; // Up arrow
  } else {
    seta.innerHTML = "&#9660;"; // Down arrow
  }
}