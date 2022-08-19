// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var Clothingfrmcontrol = document.getElementById("clothingCat");
var Foodfrmcontrol = document.getElementById("FoodCat");

try {
    document.getElementById("CategoryInput").addEventListener('change', function () {
        checkCategoryType();
    });
}
catch {
    //
}

function checkCategoryType() {
    var selectedCategory = document.getElementById("CategoryInput").value;
    if (selectedCategory == "Food") {
        Clothingfrmcontrol.style.display = "none";
        Foodfrmcontrol.style.display = "block";
        document.getElementById("additembtn").style.display = "block";
    }
    else if (selectedCategory == "Clothing") {
        Clothingfrmcontrol.style.display = "block";
        Foodfrmcontrol.style.display = "none";
        document.getElementById("additembtn").style.display = "block";
    }
    else {
        Clothingfrmcontrol.style.display = "none";
        Foodfrmcontrol.style.display = "none";
        document.getElementById("additembtn").style.display = "none";
    }
}