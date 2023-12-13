using TodoTask.Api.Middlewares;

namespace TodoTask.Api.Extensions
{
    public static class ApiExtension
    {
        public static void UseErrorHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
