function initializeRegister(loader, loaderClose, successMessage) {


    var registerloader = document.getElementById("register-loader");
    var loaderContent = document.getElementById("register-loader-content");
    var registerSuccess = document.getElementById("register-success");
    var registerForm = document.getElementById("register-modal-content");

    $("#register-button").click(function (e) {
        e.preventDefault();

            var Username= $("#register-username")
            var Password= $("#register-password")
            var FirstName= $("#register-firstname")
            var LastName= $("#register-lastname")
            var Address= $("#register-address")

        
        var Data = {
            Username: Username.val(),
            Password: Password.val(),
            Firstname: FirstName.val(),
            Lastname: LastName.val(),
            Address: Address.val()
        }

        if (Data.Username.length > 5) {


            $("#register-modal-content p").each(function (index, item) {
                $(item).remove();
            })

            Username.before("<p color:red >Username Should Be 5 to 20 Characters</p>");
            Password.before("<p color:red>Password Should Be 5 to 20 Characters</p>");
            FirstName.before("<p color: red>Firstname Should Be 5 to 20 Characters</p>");
            LastName.before("<p color: red>Lastname Should Be 5 to 20 Characters</p>");
            Address.before("<p color: red>Address Should Be 5 to 100 Characters</p>");
            
          
        } else {

            $.ajax({
                type: 'POST',
                url: 'account/register',
                data: Data,
                async: true,
                beforeSend: loader(registerloader, loaderContent, registerForm),
                success: function (data) {
                    if (data === true) {
                        loaderClose(registerloader, loaderContent, registerForm)
                        successMessage(registerSuccess)


                    } else {
                        loaderClose(registerloader, loaderContent, registerForm)

                        registerForm.ClassList.add("show");
                        /*error message*/
                    }


                }
            })
        }


    })
}

