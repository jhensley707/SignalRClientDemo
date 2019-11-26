using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SignalRClient.Hubs
{
    public class ProgressHub : IProgress, IHostedService
    {
        private readonly ILogger<ProgressHub> _logger;
        private HubConnection _connection;

        public ProgressHub(ILogger<ProgressHub> logger)
        {
            _logger = logger;

            _connection = new HubConnectionBuilder()
                //.WithUrl(Strings.HubUrl)
                .WithUrl("https://localhost:44390/hubs/progress")
                .Build();

            //_connection.On<DateTime>(Strings.Events.TimeSent, 
            //    dateTime => _ = ShowTime(dateTime));
            _connection.On<int>("ShowProgress", progress => _ = ShowProgress(progress));
        }

        public Task ShowProgress(int progress)
        {
            _logger.LogInformation("{progress}", progress);

            return Task.CompletedTask;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // Loop is here to wait until the server is running
            while (true)
            {
                try
                {
                    await _connection.StartAsync(cancellationToken);

                    break;
                }
                catch
                {
                    await Task.Delay(1000);
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return _connection.DisposeAsync();
        }
    }
}
