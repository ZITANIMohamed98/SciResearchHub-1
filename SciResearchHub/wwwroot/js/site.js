

collapseChecker(".category");

function collapseChecker(Category) {
    let collapsebutton = document.querySelectorAll(Category);
    for (let i = 0; i < collapsebutton.length; i++) {
        //click event
        collapsebutton[i].addEventListener('click', function (event) {
            if (!event.target.classList.contains("open")) {
                for (let i = 0; i < collapsebutton.length; i++) {                     
                    if (collapsebutton[i].classList.contains("open")) {                     // Checking if the selected tab is open.
                        collapsebutton[i].classList.remove("open");                          
                        collapsebutton[i].style.color = "black";
                        collapsebutton[i].style.borderBottom = "none";
                        if (collapsebutton[i].classList.contains("BiologyButton")) {        //Close tab
                            categoryResult(".Biology", "d");
                            categoryResult(".Biologycat", "d");
                        }
                        if (collapsebutton[i].classList.contains("Med")) {
                            categoryResult(".Medicine", "d");
                            categoryResult(".Medicinecat", "d");
                        }
                    }
                    event.target.classList.add("open");                                             // Open the new tab
                    event.target.style.color= "#1b6ec2";
                    event.target.style.borderBottom= "solid 2px #1861ac";                              // Depending on the category selected
                    if (event.target.classList.contains("BiologyButton")) {
                        for (let i = 0; i < collapsebutton.length; i++) {
                            if (event.target === collapsebutton[i])
                                break;
                        }
                        stylingOpen(".Biology");
                        stylingOpen(".Biologycat");
                        categoryResult(".Biology", "w");
                        categoryResult(".Biologycat", "w");
                    }
                    else if (event.target.classList.contains("Med")) {                  
                        for (let i = 0; i < collapsebutton.length; i++) {
                            if (event.target === collapsebutton[i])
                                break;
                        }
                        stylingOpen(".Medicine");
                        stylingOpen(".Medicinecat");
                        categoryResult(".Medicine", "w");
                        categoryResult(".Medicinecat", "w");
                    }
                }
            }
            else {                                                              
                if (event.target.classList.contains("BiologyButton")) {
                    
                    for (let i = 0; i < collapsebutton.length; i++) {
                        if (event.target === collapsebutton[i])
                            break;
                    }
                    stylingOpen(".Biology");
                    stylingOpen(".Biologycat");
                    categoryResult(".Biology", "w");
                    categoryResult(".Biologycat", "w");
                }
                else if (event.target.classList.contains("Med")) {
                    
                    for (let i = 0; i < collapsebutton.length; i++) {
                        if (event.target === collapsebutton[i])
                            break;
                    }
                    categoryResult(".Medicine", "w");
                    categoryResult(".Medicinecat", "w");
                }
            }


        });
        if (collapsebutton[i].classList.contains("open")) {                         //Default Open tab is Biology's tab
            let activebutton = collapsebutton[i];
            if (activebutton.classList.contains("BiologyButton")) {
                for (let i = 0; i < collapsebutton.length; i++) {
                    if (activebutton === collapsebutton[i])
                        break;
                }
                categoryResult(".Biology", "w");
                categoryResult(".Biologycat", "w");
            }
            else if (activebutton.classList.contains("Med")) {
                for (let i = 0; i < collapsebutton.length; i++) {
                    if (activebutton === collapsebutton[i])
                        break;
                }
                categoryResult(".Medicine", "w");
                categoryResult(".Medicinecat", "w");
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
        let Cat = document.querySelectorAll(Category);
        for (let i = 0; i < Cat.length; i++)
            Cat[i].style.display = "none";
    }

}                           //display or delete function
function stylingOpen(Category) {                                        
    element = document.querySelector(Category);
    element.style.color = "#1b6ec2";
    element.style.borderBottom = "solid 2px #1861ac";
}                                       //open tab styling function