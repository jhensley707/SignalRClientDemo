"use strict";

//var connection = new signalR.HubConnectionBuilder().withUrl("/progressHub").build();
var connection = new signalR.HubConnectionBuilder()
    .withUrl("http://localhost:44390/hubs/progress", {
        //skipNegotiation: true,
        //transport: signalR.HttpTransportType.WebSockets
    })
    .build();

connection.on("ShowProgress", function (message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    document.getElementById("progressSpan").textContent(msg);
});

connection.start().then(function () {
    //document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err);
});