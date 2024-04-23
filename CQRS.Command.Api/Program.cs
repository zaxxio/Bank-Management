var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setupAction =>
{
    setupAction.SwaggerDoc("BankManagement", new()
    {
        Title = "Command Query Responsibility Segregation",
        Version = "1"
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        setupAction =>
        {
            setupAction.SwaggerEndpoint("swagger/BankManagement/swagger.json", "Bank Management API");
            setupAction.RoutePrefix = string.Empty;
        });
}

app.MapGet("/", () => "Hello World!");

app.Run();