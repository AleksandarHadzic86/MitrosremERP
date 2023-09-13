//const listItems = document.querySelectorAll(".sidebar-list li");

//listItems.forEach((item) => {
//    item.addEventListener("click", () => {
//        let isActive = item.classList.contains("active");

//        listItems.forEach((el) => {
//            el.classList.remove("active");
//        });

//        if (isActive) item.classList.remove("active");
//        else item.classList.add("active");
//    });
//});
const listItems = document.querySelectorAll(".sidebar-list li");

listItems.forEach((item) => {
    const submenu = item.querySelector(".submenu");

    // Check if there is a submenu
    if (submenu) {
        const submenuLinks = submenu.querySelectorAll(".link");
        submenuLinks.forEach((submenuLink) => {
            submenuLink.addEventListener("click", (event) => {
                event.stopPropagation(); // Prevent the parent li click event

                // Toggle the "active" class for submenu links
                submenuLinks.forEach((link) => {
                    link.classList.remove("active");
                });

                submenuLink.classList.add("active");
            });
        });
    }

    item.addEventListener("click", () => {
        let isActive = item.classList.contains("active");

        listItems.forEach((el) => {
            el.classList.remove("active");
        });

        if (isActive) item.classList.remove("active");
        else item.classList.add("active");
    });
});
const toggleSidebar = document.querySelector(".toggle-sidebar");
const logo = document.querySelector(".logocorn");
const sidebar = document.querySelector(".sidebar");

toggleSidebar.addEventListener("click", () => {
    sidebar.classList.toggle("close");
});

logo.addEventListener("click", () => {
    sidebar.classList.toggle("close");
});