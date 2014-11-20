using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleContractsConsoleClient
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

            /*
             * Trying to run the following code using the secured endpoint will return the following exception
             * 
             * Could not find endpoint element with name 'secured' and contract 'ServiceReference1.IFirstServiceContract' 
             * in the ServiceModel client configuration section. This might be because no configuration file was found for your
             * application, or because no endpoint element matching this name could be found in the client element.
             * 
             * */

            //ServiceReference1.FirstServiceContractClient client = new ServiceReference1.FirstServiceContractClient("unsecured");
            //string username = client.GetWhileAnonymous();
            //Console.WriteLine("User: " + username);
            //Console.ReadLine();


            /*
             * Trying to run the following code using the unsecured endpoint will return the following exception
             * 
             * Could not find endpoint element with name 'unsecured' and contract 'ServiceReference1.ISecondServiceContract' in 
             * the ServiceModel client configuration section. This might be because no configuration file was found for your 
             * application, or because no endpoint element matching this name could be found in the client element.
             * 
             * */

            //ServiceReference1.SecondServiceContractClient client = new ServiceReference1.SecondServiceContractClient("secured");
            //string username = client.GetWhileAuthenticated();
            //Console.WriteLine("User: " + username);
            //Console.ReadLine();



        }
    }
}
