using DoDinner.Api.Errors;
using DoDinner.Api.Filters;
using DoDinner.Api.Middleware;
using DoDinner.Application;
using DoDinner.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
            .AddApplication()
            .AddInfrastructure(builder.Configuration);
            
    builder.Services.AddControllers();
    builder.Services.AddSingleton<ProblemDetailsFactory, DoDinnerProblemDetailsFactory>();
}

var app = builder.Build();
{
    //app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

