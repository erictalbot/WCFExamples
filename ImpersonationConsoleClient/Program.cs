using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ImpersonationConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WindowsIdentity.GetCurrent().Impersonate())
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("WSHttpBinding_IService1");
                string username = client.GetData(1);
            }

        }
    }
}
