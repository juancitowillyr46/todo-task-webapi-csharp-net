using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using TodoTask.Application.Wrappers;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace TodoTask.Api.Filters
{
    public class ApiResponseFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Este método se ejecuta antes de la acción del controlador
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Este método se ejecuta después de la acción del controlador
            if (context.Result is ObjectResult objectResult)
            {
                var originalValue = objectResult.Value;

                // Configuración de nombres de propiedad en minúscula
                var jsonSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    // Otras configuraciones según sea necesario
                };

                // Crear la nueva estructura de respuesta
                var apiResponse = new ApiResponse<Object>
                {
                    Success = context.ModelState.IsValid,
                    Message = GetModelStateErrors(context.ModelState),
                    Data = originalValue
                };

                // Modificar la respuesta
                context.Result = new ObjectResult(apiResponse)
                {
                    StatusCode = objectResult.StatusCode
                };

                // Modificar la respuesta
                var jsonResponse = JsonConvert.SerializeObject(apiResponse, jsonSettings);

                context.HttpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Application.Json;
                context.HttpContext.Response.StatusCode = objectResult.StatusCode ?? 200;
                context.HttpContext.Response.WriteAsync(jsonResponse);

                // Establecer el resultado en null para evitar que el marco MVC intente generar una respuesta adicional
                context.Result = null;
            }
        }

        private static string GetModelStateErrors(ModelStateDictionary modelState)
        {
            // Obtener mensajes de error del modelo
            var errors = modelState.Values.SelectMany(v => v.Errors)
                                         .Select(e => e.ErrorMessage)
                                         .ToList();

            return string.Join(" | ", errors);
        }
    }
}
