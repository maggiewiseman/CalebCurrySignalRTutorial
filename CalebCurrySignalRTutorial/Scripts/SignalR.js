

(function ()
{
    $.connection.hub.start()
        .done(function ()
        {
            console.log("It worked!");
            $.connection.myHub.server.announce("Connected");
        })
        .fail(function ()
        {
            alert("FAIL!!!!")
        });


    $.connection.myHub.client.announce = function (message)
    {
        $("#welcome-messages").html(message)
    }


})();