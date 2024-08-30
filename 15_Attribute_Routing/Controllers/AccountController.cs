using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15_Attribute_Routing.Controllers
{
    [RoutePrefix("admin")]
    public class AccountController : Controller
    {
        [Route("signin")]
        public ViewResult Login() //request handler: account/login ==> admin/signin (URL pattern)
        {
            return View();
        }

        [Route("signup")]
        public ViewResult Register() 
        {
            return View();
        }

        [Route("reset-password")]
        public ViewResult ChangePassword()
        {
            return View();
        }

        [Route("courses/{name}")]
        public ContentResult Courses(string name)
        {
            return Content(name);
        }

        //Using constraints in parameter
        [Route("display/{sid:range(1,100)}")]
        public ContentResult Show(int sid)
        {
            return Content(sid.ToString());
        }

    }
}