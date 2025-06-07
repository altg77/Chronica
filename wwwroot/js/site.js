window.addEventListener('scroll', function () {
  const navbar = document.querySelector('.navbar');

  if (window.scrollY > 600) {
    navbar.classList.add('shrink');
  } else {
    navbar.classList.remove('shrink');
  }
});

window.addEventListener('load', function () {
  const navbar = document.querySelector('.navbar');
  const logo = document.getElementById('logo');


  if (typeof ViewData === 'undefined' || ViewData !== 'Home' && !window.location.pathname.includes('/home')) {
    navbar.classList.remove('shrink'); 
  } else {
    if (window.scrollY > 600) {
        navbar.classList.add('shrink');
    } else {
        navbar.classList.remove('shrink');
    }
  }
});