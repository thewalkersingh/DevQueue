// common.js
// Smooth scrolling
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        document.querySelector(this.getAttribute('href'))
            .scrollIntoView({behavior: 'smooth'});
    });
});

// Check for saved dark mode preference
document.addEventListener('DOMContentLoaded', function () {
    const darkModeToggle = document.getElementById('dark-mode-toggle');
    const darkModePreference = localStorage.getItem('darkMode') === 'enabled';

    if (darkModePreference) {
        document.body.classList.add('dark-mode');
        darkModeToggle.textContent = 'Light Mode';
    }

    darkModeToggle.addEventListener('click', function () {
        document.body.classList.toggle('dark-mode');
        const darkModeEnabled = document.body.classList.contains('dark-mode');

        darkModeToggle.textContent = darkModeEnabled ? 'Light Mode' : 'Dark Mode';
        localStorage.setItem('darkMode', darkModeEnabled ? 'enabled' : 'disabled');
    });
});
// Add this to your JavaScript file (e.g., scripts.js)

document.addEventListener('DOMContentLoaded', function () {
    const toggle = document.getElementById('dark-mode-toggle');
    const body = document.body;

    // Check if the user has a previously selected mode
    if (localStorage.getItem('darkMode') === 'enabled') {
        body.classList.add('dark-mode');
        toggle.checked = true;
    }

    toggle.addEventListener('change', function () {
        if (toggle.checked) {
            body.classList.add('dark-mode');
            localStorage.setItem('darkMode', 'enabled');
        } else {
            body.classList.remove('dark-mode');
            localStorage.setItem('darkMode', 'disabled');
        }
    });
});