using System.Net;

namespace SchoolManagementApi.Api.Middleware;

public sealed class ExceptionHandlingMiddleware
{
    private const string CorrelationIdHeader = "X-Correlation-Id";
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception");

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var correlationId = context.Items[CorrelationIdHeader]?.ToString() ?? context.TraceIdentifier;
            var response = new
            {
                error = "An unexpected error occurred.",
                correlationId
            };

            await context.Response.WriteAsJsonAsync(response);
        }
    }
}
