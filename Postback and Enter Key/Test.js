jQuery(function () {
    $(".myclass").keypress(function (event) {
        if (event.which == 13) {
            event.preventDefault();
        }
    })
});

jQuery(function () {
    $('.myclass').blur(function () {
        __doPostBack('TextBox1', 'OnBlur');
    });
});