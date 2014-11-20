using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFMultipleContracts
{
    public class Service : ISecondServiceContract, IFirstServiceContract
    {

        public string GetWhileAuthenticated()
        {

            return "Authenticated as " + ServiceSecurityContext.Current.WindowsIdentity.Name;
        }

        public string GetWhileAnonymous()
        {

            return "Anonymous" + (ServiceSecurityContext.Current==null?"ok everything is fine" : "somehow you've been authenticated !?");
        }
    }
}
