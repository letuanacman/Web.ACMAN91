using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web.APP.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["User_DN"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Login", Action = "Index" }));
            }
            base.OnActionExecuting(filterContext);
        }
        // GET: Base
       protected void ThongBao(string TenTB, string Type)
        {
            TempData["AlertMessage"] = TenTB;
            if (Type=="success")
            {
                TempData["AlertType"] = "alert-success";
            }    
            else if(Type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (Type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
    }
}