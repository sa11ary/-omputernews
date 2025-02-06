// JavaScript source code
document.addEventListener("DOMContentLoaded", function () {
    let lastScrollTop = 0;
    const header = document.querySelector("header");

    window.addEventListener("scroll", function () {
        let scrollTop = window.pageYOffset || document.documentElement.scrollTop;
        if (scrollTop > lastScrollTop) {
            header.classList.add("hide-header");
        } else {
            header.classList.remove("hide-header");
        }
        lastScrollTop = scrollTop;
    });

    // Анимация раскрытия вопросов
    document.querySelectorAll(".faq-question").forEach((item) => {
        item.addEventListener("click", function () {
            const parent = this.parentElement;
            parent.classList.toggle("open");
        });
    });
});
