function initializeSignIn(loader,loaderClose) {

    var loading = document.getElementById("loader");
    var loadingContent = document.getElementById("loader-content");
    var signform = document.getElementById("sign-in-modal-content");

    

    $("#sign-in-button").click(function (e) {
        e.preventDefault();
        var Data = {
            Username: document.getElementById("username").value,
            Password: document.getElementById("password").value
        }
        $.ajax({
            type: 'POST',
            url: 'api/login',
            data: Data,
            async: true,
            beforeSend: loader(loading, loadingContent, signform),
            success: function (data) {
                if (data) {
                    setTimeout(function () { loaderClose(loading, loadingContent, signform) }, 2000);
                }
                
                
            }
        })
    })
}

