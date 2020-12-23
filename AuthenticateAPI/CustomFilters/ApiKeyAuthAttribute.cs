using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace AuthenticateAPI.CustomFilters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAuthAttribute : Attribute, IAsyncActionFilter
    {
        public const string ApiKeyName = "Token";

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            
            if(!context.HttpContext.Request.Headers.TryGetValue(ApiKeyName, out var potentialKeyName))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var configuration = context.HttpContext.RequestServices.GetService<IConfiguration>();
            var apiKey = configuration.GetValue<string>(ApiKeyName);

            if(!apiKey.Equals(potentialKeyName))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            await next();
        }
    }
}
