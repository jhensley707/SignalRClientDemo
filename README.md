# SignalRClientDemo

A Visual Studio solution of ASP.NET Core 2.2 for a SignalR Client application hosted in a Web Application. All clients that connect to the server will receive progress notifications.

The NetCoreClientPage will connect to the SignalRServerDemo SignalR hub as /hubs/progress. When the default API method /api/values is invoked on the web service in a separate browser window, it triggers a background task queue that will notify all instances of the NetCoreClientPage page.

The purpose of this application was to establish a) SignalR client technology connecting to separate SignalR server, and b) an event listener for  SignalR push notifications of the progress of the task.

This example is an adaptation of Microsoft tutorials. [SignalR Javascript Client Tutorial](https://docs.microsoft.com/en-us/aspnet/core/signalr/javascript-client?view=aspnetcore-2.2)

ASP.NET Core 2.2 was the first version with SignalR integrated in the SDK.