let collapsebutton = document.querySelectorAll(".category");

collapseChecker();

function collapseChecker() {
    for (let i = 0; i < collapsebutton.length; i++) {

        collapsebutton[i].addEventListener('click', function (event) {
            if (!event.target.classList.contains("active")) {
                for (let i = 0; i < collapsebutton.length; i++) {
                    if (collapsebutton[i].classList.contains("active")) {
                        collapsebutton[i].classList.remove("active");
                        if (collapsebutton[i].classList.contains("NetworkingButton")) {
                            categoryResult(".Networking", "d");
                        }
                        if (collapsebutton[i].classList.contains("Med")) {
                            categoryResult(".Medicine", "d");
                        }
                    }
                    event.target.classList.add("active");
                    event.target.backgroundColor = "#4f8a8b";
                    if (event.target.classList.contains("NetworkingButton")) {
                        for (let i = 0; i < collapsebutton.length; i++) {
                            if (event.target === collapsebutton[i])
                                break;
                        }
                        categoryResult(".Networking", "w");
                    }
                    else if (event.target.classList.contains("Med")) {
                        for (let i = 0; i < collapsebutton.length; i++) {
                            if (event.target === collapsebutton[i])
                                break;
                        }
                        categoryResult(".Medicine", "w");
                    }
                }
            }
            else {
                if (event.target.classList.contains("NetworkingButton")) {
                    for (let i = 0; i < collapsebutton.length; i++) {
                        if (event.target === collapsebutton[i])
                            break;
                    }
                    categoryResult(".Networking", "w");
                }
                else if (event.target.classList.contains("Med")) {
                    for (let i = 0; i < collapsebutton.length; i++) {
                        if (event.target === collapsebutton[i])
                            break;
                    }
                    categoryResult(".Medicine", "w");
                }
            }


        });
        if (collapsebutton[i].classList.contains("active")) {
            let activebutton = collapsebutton[i];
            if (activebutton.classList.contains("NetworkingButton")) {
                for (let i = 0; i < collapsebutton.length; i++) {
                    if (activebutton === collapsebutton[i])
                        break;
                }
                categoryResult(".Networking", "w");
            }
            else if (activebutton.classList.contains("Med")) {
                for (let i = 0; i < collapsebutton.length; i++) {
                    if (activebutton === collapsebutton[i])
                        break;
                }
                categoryResult(".Medicine", "w");
            }
        }
    }
}
function categoryResult(Category,option) {
    if (option === "w") {

        let Cat = document.querySelectorAll(Category);
        for (let i = 0; i < Cat.length; i++) 
            Cat[i].style.display= "flex";
    }
    else if (option === "d") {
        console.log("Enter");
        let Cat = document.querySelectorAll(Category);
        for (let i = 0; i < Cat.length; i++)
            Cat[i].style.display = "none";
    }

}
