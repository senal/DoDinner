using DoDinner.Application;
using DoDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
            .AddApplication()
            .AddInfrastructure();
            
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

