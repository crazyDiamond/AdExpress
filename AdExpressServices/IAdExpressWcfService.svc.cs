using System;
using System.ServiceModel;
using AdExpressServices.Models;

namespace AdExpressServices
{
    [ServiceContract]
    interface IAdExpressWcfService
    {
        [OperationContract]
        Ad AddAd(string title, string version);

        [OperationContract]
        Ad[] GetAllAdsList();

        [OperationContract]
        Ad FindAd(int? id);

        [OperationContract]
        Ad SaveAd(Ad ad);

        [OperationContract]
        void RemoveAd(Ad ad);

        [OperationContract]
        Newspaper AddNewspaper(string name, string category);

        [OperationContract]
        Newspaper[] GetAllNewspapers();

        [OperationContract]
        Newspaper FindNewspaper(int? id);

        [OperationContract]
        Newspaper SaveNewspaper(Newspaper newspaper);

        [OperationContract]
        void RemoveNewspaper(Newspaper newspaper);

        [OperationContract]
        Association AddAssociation(DateTime startDateTime, DateTime endDateTime, int adID, int newspaperID);

        [OperationContract]
        Association[] GetAllAssociations();

        [OperationContract]
        Association FindAssociation(int? id);

        [OperationContract]
        Association SaveAssociation(Association association);

        [OperationContract]
        void RemoveAssociation(Association association);
    }
}
