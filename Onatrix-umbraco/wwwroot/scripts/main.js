//for scrollfunction on the screen, when scrolling down 200px the icon will be visible
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    var scrollToTopBtn = document.getElementById("scrollToTopBtn")

    if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200)
    {
        scrollToTopBtn.style.display = "block"
    }
    else
    {
        scrollToTopBtn.style.display = "none"

    }
}

function scrollToTop() {
    document.body.scrollTop = 0
    document.documentElement.scrollTop = 0
}


// function when clicking the magnifying-glass in navigation menu
document.addEventListener("DOMContentLoaded", function () {
    var searchIcon = document.getElementById("searchIcon");
    var searchInput = document.getElementById("searchInput");

    // Viewing input field when clicking the icon
    searchIcon.addEventListener("click", function () {
        if (searchInput.style.display === "none" || searchInput.style.display === "") {
            searchInput.style.display = "inline-block"; 
            searchInput.focus(); 
        } else {
            searchInput.style.display = "none"; 
        }
    });

    
    document.addEventListener("click", function (event) {
        if (!searchIcon.contains(event.target) && !searchInput.contains(event.target)) {
            searchInput.style.display = "none"; 
        }
    });
});