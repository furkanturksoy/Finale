function initializeRegister(loader, loaderClose, successMessage) {


    var registerloader = document.getElementById("register-loader");
    var loaderContent = document.getElementById("register-loader-content");
    var registerSuccess = document.getElementById("register-success");
    var registerForm = document.getElementById("register-modal-content");

    $("#register-button").click(function (e) {
        e.preventDefault();
        var Data = {
            Username: document.getElementById("username").value,
            Password: document.getElementById("password").value
        }
        $.ajax({
            type: 'POST',
            url: 'api/register',
            data: Data,
            async: true,
            beforeSend: loader(registerloader, loaderContent, registerForm),
            success: function (data) {
                if (data) {
                    setTimeout(function () { loaderClose(registerloader, loaderContent, registerForm) }, 800);
                    setTimeout(function () { successMessage(registerSuccess) }, 1000);


                }


            }
        })
    })
}

