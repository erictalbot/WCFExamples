using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace MultipleEndpointsWebClient.Controllers
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
            /*
             * REMINDER : You have to disable Anonymous authentication and enable Windows Authentication at IIS level for this web application
             * 
             * */



            /*The following call will be made anonymously.
             * 
             * ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("unsecured");
             * string userName = client.Get();
             * ViewBag.Message = userName;
             * 
             * */



            /* The following call will be made using the applicationPool identity.
             * This call should be used to use the secured endpoint when using ADFS on the WEB client application.
             * 
             * If you try to run it locally on your workstation, you'll get the following exception : The target principal name is incorrect
             * That would be because of :
             * <identity>
             *           <servicePrincipalName value="host/dc-dev11.canamdc.ws" />
             * </identity>
             * Which specifies calling host name. By default the same value as where the WCF service is installed is provided.
             * You have to deploy it, to see it working.
             * 
             * You also have to configure delegation in active directory.
             * 
             * 1.Start the Microsoft Management Console (MMC) Active Directory Users and Computers snap-in.
             * 2.In the left pane of the MMC snap-in, click the Computers node.
             * 3.In the right pane, double-click your Web server computer to display the Properties dialog box. 
             * 4.On the Delegation tab of the Properties window for the Web server computer, Do not trust the computer for delegation is selected by default. To use constrained delegation, select Trust this computer for delegation to specified services only.
             * You specify precisely which service or services can be accessed in the bottom pane.
             * 
             * 5.Beneath Trust this computer for delegation to specified services only, select Use Kerberos only. 
             * 6.Click Add. 
             * The Add Services dialog box appears.
             * 
             * 7.Click Users or computers.
             * 8.In the Select Users or Computers dialog box, type the name of your WCF service computer if you are running using Network Service. Alternatively, if you are running WCF by using a custom domain account, enter that account name instead. Click OK.
             * You will see all the SPNs configured for the selected user or computer account. 
             * 
             * 9.To restrict access to the WCF service, select the HOST service, and then click OK. 
             * 
             * 
             * 
             *             ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("secured");
             *             string userName = client.Get();
             *             ViewBag.Message = userName;
             *             
             *             
             * */




            /* The following call will be made using the end user identity.
             * 
             * If you try to run it locally on your workstation, you'll get the following exception : The remote server returned an error: (401) Unauthorized.
             * 
             * You also have to configure delegation in active directory. See previous call for detailed information.
             * 
             * using (((WindowsIdentity)User.Identity).Impersonate())
             * {
             *      ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("secured");
             *      string username = client.Get();
             *      ViewBag.Message = username;
             * }
             * 
             * 
             * */
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
