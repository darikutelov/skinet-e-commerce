var builder = WebApplication.CreateBuilder(args);

// Services

builder.Services.AddControllers();

var app = builder.Build();

// Middleware
app.MapControllers();

// Run application
app.Run();
