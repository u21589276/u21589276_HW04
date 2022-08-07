try {
    document.getElementById("userTypeInput").addEventListener('change', function () {
        checkUserType();
    });
}
catch {
    //catch statement goes here
}


function checkUserType() {
    var selectedUser = document.getElementById("userTypeInput").value;
    var individualUserfrm = document.getElementById("indiUserfrm");
    var OrganisationUserfrm = document.getElementById("orgUserfrm");

    if (selectedUser == "Individual") {
        individualUserfrm.style.display = "block";
        OrganisationUserfrm.style.display = "none";
    }
    else if (selectedUser == "Organisation/Company") {
        individualUserfrm.style.display = "none";
        OrganisationUserfrm.style.display = "block";
    }
    else {
        individualUserfrm.style.display = "none";
        OrganisationUserfrm.style.display = "none";
	}
}