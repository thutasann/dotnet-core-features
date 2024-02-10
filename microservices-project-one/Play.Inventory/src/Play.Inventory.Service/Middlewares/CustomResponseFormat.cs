using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Play.Inventory.Service.Middlewares
{
    /// <summary>
    /// Custom Response Format Attribute
    /// </summary>
    public class CustomResponseFormat : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is ObjectResult objectResult)
            {
                var customData = new
                {
                    StatusCode = objectResult.StatusCode,
                    Data = objectResult.Value
                };
                context.Result = new ObjectResult(customData)
                {
                    StatusCode = objectResult.StatusCode
                };
            }
            base.OnResultExecuting(context);
        }
    }
}