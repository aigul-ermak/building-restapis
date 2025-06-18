using System.Reflection;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DevHabit.Middleware;

public sealed class GlobalExceptionHandler(IProblemDetailsService problemDatailsService) : IExceptionHandler
{

    public ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken
        )
    {
        return problemDatailsService.TryWriteAsync(new ProblemDetailsContext { 
            HttpContext = httpContext,
        Exception = exception,
        ProblemDetails = new ProblemDetails
        {
            Title = "Internal Server Error",
            Detail = "AN error occured while processing your request. Please try again."
        }
        });
    }
}
