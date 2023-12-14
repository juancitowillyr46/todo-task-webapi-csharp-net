using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace TodoTask.Api.Middlewares
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                AttachUserInformationToContext(context, token);
            }

            await _next(context);
        }

        private static void AttachUserInformationToContext(HttpContext context, string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            if (jsonToken != null)
            {
                var userIdClaim = jsonToken.Claims.FirstOrDefault(claim => claim.Type == "Id");

                var payLoad = jsonToken.Payload;

                var valueJwt = payLoad.FirstOrDefault(claim => claim.Key == "email").Value;

                if (userIdClaim != null)
                {
                    // Agrega la información del usuario al contexto para que esté disponible en los controladores
                    context.Items["UserId"] = userIdClaim;
                }
            }
        }
    }
}
