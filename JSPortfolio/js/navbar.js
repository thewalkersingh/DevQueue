// js/navbar.js
document.addEventListener('DOMContentLoaded', function () {
    const navbarHTML = `
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
        <div class="container-fluid">
            <a class="navbar-brand" href="index.html">Diwakar</a>
            <ul class="navbar-nav ms-auto">
                <li class="nav-item">
                    <label id="" class="switch">
                        <input type="checkbox" id="dark-mode-toggle">
                        <span class="slider round"></span>
                    </label>
                </li>
            </ul>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                    aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav ms-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="../about.html">About</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="../skills.html">Skills</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="../projects.html">Projects</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="../experience.html">Experience</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="../contact.html">Contact</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>`;
    document.body.insertAdjacentHTML('afterbegin', navbarHTML);
});