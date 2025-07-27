var builder = WebApplication.CreateBuilder(args);

// ADD services to the container.
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});



var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapCarter();
app.Run();
