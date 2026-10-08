using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EnvioEmail.Filters
{
    public class UsuarioLogadoAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context) 
        {
            int? usuarioId = context.HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);
            }

            base.OnActionExecuting(context);
        }
    }
}
