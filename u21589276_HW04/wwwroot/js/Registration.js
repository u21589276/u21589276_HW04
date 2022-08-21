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

function displayDonorfrm() {
    document.getElementById("frmDonor").style.display = "block";
}


function submitDonation() {
    var divloader = document.getElementById("loaderDiv");
    var frm = document.getElementById("frmDonor");

    frm.style.display = "none";
    frm.reset();
    divloader.style.display = "block";

    const tmMessage = setTimeout(message, 5000);
    function message() {
        divloader.style.display = "none";
        document.getElementById("messageEr").innerHTML = "Donation Submitted, you will recieve a confirmation message shortly!"
    }
}

