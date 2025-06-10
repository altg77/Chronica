document.addEventListener("DOMContentLoaded", () => {
  const abas = document.querySelectorAll(".aba");
  const conteudos = document.querySelectorAll(".aba-conteudo");

  abas.forEach(aba => {
    aba.addEventListener("click", () => {
      const nomeAba = aba.dataset.aba;

      // Trocar classe visual no menu
      abas.forEach(a => a.classList.remove("ativa"));
      aba.classList.add("ativa");

      // Mostrar conteúdo correspondente
      conteudos.forEach(c => {
        c.classList.remove("ativa");
        if (c.id === "aba-" + nomeAba) {
          c.classList.add("ativa");
        }
      });
    });
  });

  // Iniciar com Habilidades visível, se preferir outra, troque "habilidades"
  document.querySelector('.aba[data-aba="habilidades"]').click();
});

// Expande ou recolhe os detalhes da habilidade
function toggleDetalhes(elem) {
  const seta = elem.querySelector(".seta");
  const detalhes = elem.nextElementSibling;

  if (detalhes.style.display === "none" || detalhes.style.display === "") {
    detalhes.style.display = "block";
    seta.innerHTML = "&#9650;";
  } else {
    detalhes.style.display = "none";
    seta.innerHTML = "&#9660;";
  }
}
