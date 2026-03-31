using Mapster;
using MetaCheck.API;
using MetaCheck.API.Dtos;
using MetaCheck.API.Repositories;
using MetaCheck.API.Endpoints;
using MetaCheck.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddOpenApi();
builder.Services.AddSingleton<IActivityRepository, ActivityRepository>();
builder.Services.AddScoped<IActivityService, ActivityService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () => Results.Ok(new
{
    message = "MetaCheck API is running"
}));

// Activity Endpoints
app.MapActivityEndpoints();
app.Run();