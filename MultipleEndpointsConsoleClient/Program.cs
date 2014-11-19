using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleEndpointsConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * If you want to run this code on any computer using the SECURED endpoint, you'll
             * have to remove <servicePrincipalName value="host/dc-dev11.canamdc.ws" /> from
             * the secured endpoint in your app.config. If specified, this application must
             * run on the computer specified in this tag.
             * */

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("secured");
            string username = client.Get();
            Console.WriteLine("User: " + username);
            Console.ReadLine();
        }
    }
}
