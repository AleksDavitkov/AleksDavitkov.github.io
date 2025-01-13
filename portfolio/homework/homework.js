document.addEventListener("DOMContentLoaded", () => {
    const expandButtons = document.querySelectorAll(".expand-btn");
    const closeButtons = document.querySelectorAll(".close-btn");
    const body = document.body;

    expandButtons.forEach((button) => {
        button.addEventListener("click", (e) => {
            const section = e.target.closest(".section");
            const content = section.querySelector(".content");

            // Add the visible class to the content
            content.classList.add("visible");

            // Dim the rest of the page
            body.classList.add("dimmed");
        });
    });

    closeButtons.forEach((button) => {
        button.addEventListener("click", (e) => {
            const section = e.target.closest(".section");
            const content = section.querySelector(".content");

            // Remove the visible class from the content
            content.classList.remove("visible");

            // Remove dimming effect from the rest of the page
            body.classList.remove("dimmed");
        });
    });
});