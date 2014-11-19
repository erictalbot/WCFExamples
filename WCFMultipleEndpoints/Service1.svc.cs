using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFMultipleEndpoints
{
    public class Service1 : IService1
    {

        public string Get()
        {

            /*
             * In order to know which endpoint was called we could do one of the following : 
             * 1- Check if ServiceSecurityContext.Current is null -> If anonymous means we used the endpoint  address="/unsecured"
             * 2- Use a different contract by endpoint. 
             * */

            return (ServiceSecurityContext.Current == null ? string.Empty:ServiceSecurityContext.Current.WindowsIdentity.Name);
        }

    }
}
