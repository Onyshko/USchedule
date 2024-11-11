using Microsoft.AspNetCore.Http;
using System.Net;
using USchedule.Service.Models;
using USchedule.Shared.Extensions.Exceptions;

namespace USchedule.Service.Utility.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
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
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = "application/json";

            var message = ex switch
            {
                AuthenticateException => ex.Message,
                NullReferenceException => ex.Message,
                IdentityException identityException => string.Join(", ", identityException.Errors),
                EmailException => "Invalid Email Confirmation Request",
                _ => ex.Message
            };

            await httpContext.Response.WriteAsync(new ErrorDetail
            {
                StatusCode = httpContext.Response.StatusCode,
                Message = message
            }.ToString());
        }
    }
}
