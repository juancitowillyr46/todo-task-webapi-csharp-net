using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using TodoTask.Application.Exceptions;
using TodoTask.Application.Wrappers;
using TodoTask.Infrastructure.Exceptions;

namespace TodoTask.Api.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context == null)
            {
                return;
            }

            try
            {
                context.Request.EnableBuffering();
                await _next(context);
            }
            catch (Exception error)
            {
                switch (error)
                {
                    case ApiException e:
                        await WriteResponseAync(e, context, HttpStatusCode.BadRequest, "Alternative error ApiException");
                        break;

                    case NotFoundException e:
                        await WriteResponseAync(e, context, HttpStatusCode.NotFound, "Alternative error NotFoundException");
                        break;

                    default:
                        await WriteResponseAync(error, context, HttpStatusCode.InternalServerError, "Alternative error ApiException");
                        break;
                }

                
            }   
        }

        private static async Task WriteResponseAync(
            Exception error,
            HttpContext context,
            HttpStatusCode httpStatusCode,
            string? alternateMessage = null
        )
        {
            var responseModel = new ApiResponse<string>()
            {
                Success = false,
                Message = string.IsNullOrWhiteSpace(error?.Message) ? alternateMessage : error.Message
            };

            // Configuración de nombres de propiedad en minúscula
            var jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                // Otras configuraciones según sea necesario
            };

            string responseMessage = JsonConvert.SerializeObject(responseModel, jsonSettings);

            context.Response.Clear();
            context.Response.ContentType = System.Net.Mime.MediaTypeNames.Application.Json;
            context.Response.StatusCode = (int)httpStatusCode;
            await context.Response.WriteAsync(responseMessage, Encoding.UTF8);
        }
    }
}
