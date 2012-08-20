using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace WCFTest.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    class WCFTestService : IWCFTestService
    {   
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetData2()
        {
            //WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
            return "You entered: xxx";
        }
    }
}
