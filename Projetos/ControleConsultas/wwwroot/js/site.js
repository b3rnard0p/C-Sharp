document.addEventListener('DOMContentLoaded', () => {
    const themeToggle = document.getElementById('themeToggle');

    const currentTheme = localStorage.getItem('theme') || 'dark';
    if (currentTheme === 'light') {
        document.documentElement.setAttribute('data-theme', 'light');
        if (themeToggle) {
            themeToggle.innerHTML = '<i data-lucide="moon"></i>';
        }
    } else {
        if (themeToggle) {
            themeToggle.innerHTML = '<i data-lucide="sun"></i>';
        }
    }

    if (typeof lucide !== 'undefined') {
        lucide.createIcons();
    }

    if (themeToggle) {
        themeToggle.addEventListener('click', () => {
            let theme = document.documentElement.getAttribute('data-theme');
            if (theme === 'light') {
                document.documentElement.removeAttribute('data-theme');
                localStorage.setItem('theme', 'dark');
                themeToggle.innerHTML = '<i data-lucide="sun"></i>';
            } else {
                document.documentElement.setAttribute('data-theme', 'light');
                localStorage.setItem('theme', 'light');
                themeToggle.innerHTML = '<i data-lucide="moon"></i>';
            }
            if (typeof lucide !== 'undefined') {
                lucide.createIcons();
            }
        });
    }
});
document.addEventListener('DOMContentLoaded', function () {
    const confirmModalEl = document.getElementById('confirmModal');
    if (confirmModalEl) {
        const confirmModal = new bootstrap.Modal(confirmModalEl);
        let confirmAction = null;

        document.getElementById('confirmModalBtn').addEventListener('click', function () {
            if (confirmAction) {
                confirmAction();
                confirmAction = null;
            }
            confirmModal.hide();
        });

        document.querySelectorAll('[data-confirm]').forEach(el => {
            el.addEventListener('click', function (e) {
                e.preventDefault();
                const msg = this.getAttribute('data-confirm');
                document.getElementById('confirmModalText').innerText = msg;
                
                confirmAction = () => {
                    if (this.tagName === 'A') {
                        window.location.href = this.href;
                    } else if (this.tagName === 'BUTTON' || this.tagName === 'INPUT') {
                        if (this.form) {
                            if (this.name) {
                                const input = document.createElement('input');
                                input.type = 'hidden';
                                input.name = this.name;
                                input.value = this.value;
                                this.form.appendChild(input);
                            }
                            this.form.submit();
                        }
                    }
                };
                
                confirmModal.show();
            });
        });
    }
});
