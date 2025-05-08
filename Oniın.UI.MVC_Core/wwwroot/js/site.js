// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Write your JavaScript code.

function getModelData() {
    let markaID = document.getElementById("Telefon_MarkaID").value;

    let urlValue = sessionStorage.getItem("url");

    if (urlValue == null) {
        sessionStorage.setItem("url", location.href)
        urlValue = sessionStorage.getItem("url");
    }

    location.replace(urlValue +"/" + markaID);
}

function askForDelete() {
    return confirm("Telefon versisi silinsin mi")
}