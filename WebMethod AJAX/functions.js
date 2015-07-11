jQuery(function () {
    $('#btn1').click(function () {
        var args = {};
        args["ID"] = "320498232309482";
        args["Name"] = "John Doe";
        data = JSON.stringify(args);
        $.ajax({
            type: 'POST',
            url: 'Home.aspx/testMethod',
            data: data,
            cache: false,
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                $('#idLBL').text(data.d.ID);
                $('#nameLBL').text(data.d.Name);
            }
        });
        return false;
    });
});