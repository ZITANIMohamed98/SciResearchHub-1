

let collapsebutton = document.querySelectorAll(".category")
let t = 0;

﻿let collapsebutton = document.querySelectorAll(".category");
let activeCollapseButton = document.querySelector(".category .active");

for (let i = 0; i < collapsebutton.length; i++) {
    collapsebutton[i].addEventListener('click', function (e) {

        e.target.classList.add("active");
        e.target.style.backgroundColor = "#fbd46d";
        if (e.target.classList.contains("Bio"))
            categoryResult(".Biology", "w");
        else if (e.target.classList.contains("Med"))
            categoryResult(".Medicine", "w");
    });
}
    for (let i = 0; i < activeCollapseButton.length; i++) {
        activeCollapseButton.addEventListener('click', function (e) {

            e.target.classList.remove("active");
            e.target.backgroundColor = "#4f8a8b";
            if (e.target.classList.contains("Bio"))
                categoryResult(".Biology", "d");
            else if (e.target.classList.contains("Med"))
                categoryResult(".Medicine", "d");

        });
    }

function categoryResult(Category,option) {
    if (option === "w") {

        let Cat = document.querySelectorAll(Category);
        for (let i = 0; i < Cat.length; i++)
            Cat[i].style = "";
    }
    else if (option === "d") {
        console.log("Enter");
        let Cat = document.querySelectorAll(Category);
        for (let i = 0; i < Cat.length; i++)
            Cat[i].style.display = "none";
    }

}
