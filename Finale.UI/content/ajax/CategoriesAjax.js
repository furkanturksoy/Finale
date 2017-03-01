(function loadCategories() {
    var categoryDropdown = $("#category-dropdown-content")

    $.ajax({
        type: 'GET',
        url: 'api/categories',
        beforeSend: function () {
            categoryDropdown.append("<li id='loadingCategories'>Loading...</li>")
        },
        success: function (data) {
            $("#loadingCategories").remove();
            $(data).each(function (index, item) {
                categoryDropdown.append("<li>" + item + "</li>")
            })
        }

    })

}).call();