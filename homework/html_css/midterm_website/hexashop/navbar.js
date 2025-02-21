const navbar = document.querySelector('nav');
const box2 = document.getElementById('box2');
const box3 = document.getElementById('box3');

// Add/remove sticky Navbar based on scroll position
window.addEventListener('scroll', () => {
  if (window.scrollY > box2.offsetTop + box2.offsetHeight && window.scrollY > box3.offsetTop + box3.offsetHeight) {
    navbar.classList.add('sticky');
  } else {
    navbar.classList.remove('sticky');
  }
});