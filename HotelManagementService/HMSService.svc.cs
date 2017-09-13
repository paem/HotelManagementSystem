using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HotelManagementService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HMSService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HMSService.svc or HMSService.svc.cs at the Solution Explorer and start debugging.
    public class HMSService : IHMSService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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
