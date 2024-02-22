using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher052023.Demo.Domain;

namespace MISA.WebFresher052023.Demo.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        
        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            Console.WriteLine(exception);
            context.Response.ContentType = "application/json";
            if(exception is NotFoundException) 
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                await context.Response.WriteAsync(text: new BaseException()
                {
                    ErrorCode = ((NotFoundException)exception).ErrorCode,
                    UserMessage = "Không tìm thấy tài nguyên",
                    DevMessage = exception.Message,
                    TraceId = context.TraceIdentifier,
                    MoreInfo = exception.HelpLink,
                }.ToString() ?? "");

            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync(text: new BaseException()
                {
                    ErrorCode = context.Response.StatusCode,
                    UserMessage = "Lỗi hệ thống",
                    DevMessage = exception.Message,
                    TraceId = context.TraceIdentifier,
                    MoreInfo = exception.HelpLink,
                }.ToString() ?? "");
            }
        }
    }
}
