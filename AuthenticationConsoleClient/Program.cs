using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WcfWindowsAuthClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
           Console.WriteLine(obj.GetData(1));
            
        }
    }
}
