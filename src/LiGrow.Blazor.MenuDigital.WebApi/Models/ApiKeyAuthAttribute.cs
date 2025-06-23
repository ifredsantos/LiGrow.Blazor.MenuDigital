using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LiGrow.Blazor.MenuDigital.WebApi.Models
{
   public class ApiKeyAuthAttribute : Attribute, IAsyncActionFilter
   {
      public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
      {
         var key = Environment.GetEnvironmentVariable("API_SECRET_KEY");
         var recivedKey = context.HttpContext.Request.Headers["X-API-KEY"].FirstOrDefault();

         if (key != recivedKey)
         {
            context.Result = new UnauthorizedResult();
            return;
         }

         await next();
      }
   }
}
