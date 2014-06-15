using System.Collections.Generic;
using System.ServiceModel;
using AdExpress.Models;

namespace AdExpressService
{
    [ServiceContract]
    interface IAdExpressDataService
    {
        [OperationContract]
        Ad AddAd(string name, string version);

        [OperationContract]
        List<Ad> GetAllAdsList();
    }
}
