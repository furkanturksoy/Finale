$(document).ready(function () {


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
            success: function (data) {
                /*deal with it later*/
            }
        })
    })
})
