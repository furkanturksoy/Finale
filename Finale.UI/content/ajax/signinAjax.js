function initializeSignIn(loader, loaderClose, successMessage) {

    var loading = document.getElementById("loader");
    var loadingContent = document.getElementById("loader-content");
    var signform = document.getElementById("sign-in-modal-content");
    var successMsg = document.getElementById("success");
   
    
    
    $("#sign-in-button").click(function (e) {
        e.preventDefault();
        var Data = {
            Username: $("#username").val(),
            Password: $("#password").val()
        }
        
        if (Data.Username.length > 20 || Data.Username.length < 5 || Data.Password.length > 20 || Data.Password.length < 5) {

            $("#sign-in-modal-content div p").each(function (index, item) {
                $(item).remove();
            })

            $("#username").before('<p>Username must be between 5 to 20 characters</p>')
            $("#password").before('<p>Password must be between 5 to 20 characters</p>')
            
        
        } else {        
        $.ajax({
            type: 'POST',
            url: 'account/login',
            data: Data,
            async: true,
            beforeSend: function ()
            {
                if (signform.classList.item("show")) signform.classList.remove("show");
                loader(loading, loadingContent, signform)
            },
            success: function (data) {
                if (data === true) {
                    loaderClose(loading, loadingContent, signform)
                    successMessage(successMsg)

                } else {
                    loaderClose(loading, loadingContent, signform)
                    $("#password").after('<p style="color:green">' + data + '</p>')
                    signform.classList.add("show");
                    
                }
            }
        })
        }
        })
        
}

