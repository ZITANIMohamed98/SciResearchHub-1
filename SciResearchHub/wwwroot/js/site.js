
let collapsebutton = document.querySelectorAll(".category")
let t = 0;
for (let i = 0; i < collapsebutton.length; i++) {
    collapsebutton[i].addEventListener('click', function (e) {
        if (t%2===0) {
            e.target.classList.add("active")
        }
        else {
            for (let i = 0; i < collapsebutton.length; i++) {
                collapsebutton[i].classList.remove("active")
            }
        }
        t++;
    });
    
}

