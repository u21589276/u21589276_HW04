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

    const tmMessage = setTimeout(message, 2000);
    function message() {
        divloader.style.display = "none";
        document.getElementById("messageEr").innerHTML = "Donation Submitted, you will recieve a confirmation message shortly!"
    }

    const tmr2 = setTimeout(timetoout1, 1000);
    function timetoout1() {
        document.getElementById("messageEr").innerHTML = " ";
    }
}

function subRegistration(){
    var divloader = document.getElementById("loaderDiv");
    var frm = document.getElementById("orgUserfrm");
    var frm2 = document.getElementById("indiUserfrm");

    frm.style.display = "none";
    frm.reset();
    frm2.style.display = "none";
    frm2.reset();
    divloader.style.display = "block";

    const tmMessage = setTimeout(message, 2000);
    function message() {
        divloader.style.display = "none";
        document.getElementById("messageEr").innerHTML = "You are successfully registered, you will recieve a confirmation message shortly!"
    }

    const tmr = setTimeout(timetoout, 1000);
    function timetoout() {
        document.getElementById("messageEr").innerHTML = " ";
    }
}
