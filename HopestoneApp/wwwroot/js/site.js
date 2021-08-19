//Bootstrap Validation
(function () {
    'use strict'

    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    var forms = document.querySelectorAll('.needs-validation')

    // Loop over them and prevent submission
    Array.prototype.slice.call(forms)
        .forEach(function (form) {
            form.addEventListener('submit', function (event) {
                if (!form.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                }

                form.classList.add('was-validated')
            }, false)
        })
})()

//Bootstrap Tooltip
var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
    return new bootstrap.Tooltip(tooltipTriggerEl)
})

//Main

function showOverlay(id) {
    var serviceOverlay = document.getElementById("serviceBoxOverlay_" + id);

    if (serviceOverlay.classList.contains("show-serviceOverlay")) {
        serviceOverlay.classList.remove("show-serviceOverlay");
    }
    else if (serviceOverlay.classList.contains("hide-serviceOverlay")) {
        serviceOverlay.classList.add("show-serviceOverlay");
        serviceOverlay.classList.remove("hide-serviceOverlay");
    }
    else {
        serviceOverlay.classList.add("show-serviceOverlay");
    }
}

function hideOverlay(id) {
    var serviceOverlay = document.getElementById("serviceBoxOverlay_" + id);
    if (serviceOverlay.classList.contains("show-serviceOverlay")) {
        serviceOverlay.classList.remove("show-serviceOverlay");
        serviceOverlay.classList.add("hide-serviceOverlay")
    }
    else {
        serviceOverlay.classList.add("hide-serviceOverlay");
    }
}

function getServiceTitle(id) {
    var title = document.getElementById("service_" + id).innerHTML;
    document.getElementById("serviceForm_Modal").innerHTML = title;
}

function hideServiceTable() {
    var prodContainer = document.getElementById("productFormContainer");
    var tableContainer = document.getElementById("tableContainer");

    prodContainer.style.overflowY = "hidden";
    tableContainer.classList.add("hide-table");

}