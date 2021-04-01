$("#sumButton").click(
    function()
    {
    const luku1 = $("#input1").val();
    const luku2 = $("#input2").val();

    $("#output")[0].innerHTML = parseInt(luku1)+parseInt(luku2);
    }
);