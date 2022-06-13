using calcservice.EventBusConsumer;
using eventbus.Common;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IConfiguration appsettings = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(x => {
        x.AddMassTransit(config => {
            config.AddConsumer<OperationEventsConsumer>();
            config.UsingRabbitMq((ctx, cfg) => {
                cfg.Host(appsettings.GetConnectionString("RabbitMQ"));
                cfg.ReceiveEndpoint(EventBusConstants.OperationsQueue, c => {
                    c.ConfigureConsumer<OperationEventsConsumer>(ctx);
                });
            });
        });
        x.AddScoped<OperationEventsConsumer>();
    })
    .Build();

Console.WriteLine("Calculator service started");
await host.RunAsync();