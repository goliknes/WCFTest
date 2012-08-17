using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFTest.Service
{

    [ServiceContract]
    public interface IWCFTestService
    {
        [OperationContract]
        [WebGet(UriTemplate = "getdata/{value}", ResponseFormat = WebMessageFormat.Json)]
        string GetData(string value);

        [OperationContract]
        [WebGet(UriTemplate = "getdata2", ResponseFormat = WebMessageFormat.Json)]
        string GetData2();
    }
}
