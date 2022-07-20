using DoDinner.Api.Filters;
using DoDinner.Api.Middleware;
using DoDinner.Application;
using DoDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
            .AddApplication()
            .AddInfrastructure(builder.Configuration);
            
    builder.Services.AddControllers(o => {
        o.Filters.Add<ErrorHandlingFilterAttribute>();
    });
}

var app = builder.Build();
{
    //app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

