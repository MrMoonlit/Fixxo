const headerBurgerBtn = document.querySelector('[data-option="menuToggle"]')
headerBurgerBtn.addEventListener('click', () => {
    const headerMenu = document.querySelector(headerBurgerBtn.getAttribute('data-target'))
    if (headerMenu.classList.contains('hide')) {
        headerMenu.classList.remove('hide')
    } else {
        headerMenu.classList.add('hide')
    }
})