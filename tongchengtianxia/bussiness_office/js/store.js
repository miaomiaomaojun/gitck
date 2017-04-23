$(function () {

    $(".icon-bnt").click(function () {
        var kms = $(this);
        kms.parent().find("input").attr("disabled", false);
        kms.parent().find("input").addClass("ind-act");
        $(".ind-act").focus();
    })
    $(document).on("blur",".ind-act",function () {
        var kmsa = $(this);
        kmsa.attr("disabled", true);
        kmsa.removeClass("ind-act");
    })

})