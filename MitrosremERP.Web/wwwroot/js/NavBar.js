const listItems = document.querySelectorAll(".sidebar-list li");

listItems.forEach((item) => {
    item.addEventListener("click", () => {
        let isActive = item.classList.contains("active");

        listItems.forEach((el) => {
            el.classList.remove("active");
        });

        if (isActive) item.classList.remove("active");
        else item.classList.add("active");
    });
});
//const listItems = document.querySelectorAll(".sidebar-list li");

//listItems.forEach((item) => {
//    const submenu = item.querySelector(".submenu");

//    // Check if there is a submenu
//    if (submenu) {
//        const submenuLinks = submenu.querySelectorAll(".link");
//        submenuLinks.forEach((submenuLink) => {
//            submenuLink.addEventListener("click", (event) => {
//                event.stopPropagation(); // Prevent the parent li click event

//                // Toggle the "active" class for submenu links
//                submenuLinks.forEach((link) => {
//                    link.classList.remove("active");
//                });

//                submenuLink.classList.add("active");
//            });
//        });
//    }

//    item.addEventListener("click", () => {
//        let isActive = item.classList.contains("active");

//        listItems.forEach((el) => {
//            el.classList.remove("active");
//        });

//        if (isActive) item.classList.remove("active");
//        else item.classList.add("active");
//    });
//});



const toggleSidebar = document.querySelector(".toggle-sidebar");
const logo = document.querySelector(".logobox");
const sidebar = document.querySelector(".sidebar");

toggleSidebar.addEventListener("click", () => {
    sidebar.classList.toggle("close");
});

logo.addEventListener("click", () => {
    sidebar.classList.toggle("close");
});


const toggleSidebardiv = document.querySelector(".sidebar");
const mediaQuery = window.matchMedia('(max-width: 560px)');
function toggleSidebarFunc() {
    if (mediaQuery.matches) {
        // Activate .sidebar.close when the media query matches
        toggleSidebardiv.classList.add('close'); // Add a CSS class to activate it
    } else {
        // Deactivate .sidebar.close when the media query doesn't match
        toggleSidebardiv.classList.remove('close'); // Remove the CSS class to deactivate it
    }
       
}

// Call the function on page load and when the window is resized
window.addEventListener('load', toggleSidebarFunc());
window.addEventListener('resize', toggleSidebarFunc());