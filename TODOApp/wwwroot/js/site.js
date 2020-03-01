// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(".editBtn").click(function () {

    var currentId = this.id;
    var todoText = "#TODOText_" + currentId;
    var todoNewText = "#TODONewText_" + currentId;
    var delAndEdt = "#DelAndEd_" + currentId;
    var save = "#Save_" + currentId;

    $(todoText).hide();
    $(delAndEdt).hide();

    $(todoNewText).show();
    $(save).show();
});
