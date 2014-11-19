using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFImpersonated
{

    public class Service1 : IService1
    {
        public string GetData(int value)
        {

            if (ServiceSecurityContext.Current == null)
            {
                return string.Empty;
            }
            else
            {
                return ServiceSecurityContext.Current.WindowsIdentity.Name;
            }

        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
