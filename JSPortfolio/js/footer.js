// js/footer.js
document.addEventListener('DOMContentLoaded', function () {
    const footerHTML = `
    <footer class="py-3 bg-dark text-white text-center fixed-bottom">
        <div class="container">
            <p class="mb-0">&copy; 2024 Diwakar Singh. All rights reserved.</p>
        </div>
    </footer>`;
    document.body.insertAdjacentHTML('beforeend', footerHTML);
});