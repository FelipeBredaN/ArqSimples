using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace TesteArq.API.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.ToString());
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        protected Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (exception == null)
                throw new ArgumentNullException(nameof(exception));

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            return context.Response.WriteAsync(JsonConvert.SerializeObject(new
            {
                success = false,
                message = exception.Message,
                statusCode = StatusCodes.Status400BadRequest
            }));
        }
    }
}