using MassTransit;
using webapi.Models.Mapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(MapperProfiles));
builder.Services.AddMassTransit(config => {
    config.UsingRabbitMq((ctx, cfg) => {
        cfg.Host(builder.Configuration.GetConnectionString("RabbitMQ"));
    });
});

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();