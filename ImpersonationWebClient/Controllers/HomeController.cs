using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;


namespace ImpersonationWebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            // ADFS
            //-----
            // In the following scenario the application is accessed via ADFS, not a windows authentication. Therefore
            // it is not possible to cast user.identity into a WindowsIdentity because our user.identity is a ClaimsIdentity.
            // The following will use the application pool identity to call the WCF not the end user identity.
            //using (WindowsIdentity.GetCurrent().Impersonate())


            // WindowsAuthentication
            //----------------------
            // In the following scenario the application is accessed via Windows Authentication, not ADFS, therefore 
            // it is possible to cast User.Identity into a Windows Identity, we've been authenticated and granted a 
            // Windows identity.
            using (((WindowsIdentity)User.Identity).Impersonate())
            {
                try
                {
                    ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                    string username = client.GetData(1);
                    ViewBag.Message = username;
                }
                catch (Exception e)
                {
                    ViewBag.Message = e.Message;
                }
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
