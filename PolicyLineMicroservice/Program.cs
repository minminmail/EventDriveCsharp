using Microsoft.Graph;

using SequelClaims.EventBus.Interfaces;

var builder = WebApplication.CreateBuilder(args);

IRabbitMQAdapter adapter;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

// use loop to listen the policy queue

var cosumer = new RabbitMQPolicyLineConsumer("policyQueue");

Task task = adapter.Consumer(cosumer);

app.Run();
