using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AdExpress.AdExpressWcfService;

namespace AdExpress.Helpers
{
    public static class Dropdownhelper
    {
        private static readonly AdExpressWcfServiceClient _service;

        static Dropdownhelper()
        {
            _service = new AdExpressWcfServiceClient();
        }
         
        public static IEnumerable<SelectListItem> GetAllAds()
        {
            var ads = _service.GetAllAdsList();
            return ads.Select(x => new SelectListItem { Text = x.Title + ":" + x.Version, Value = x.ID.ToString()});
        }
        
        public static IEnumerable<SelectListItem> GetAllNewspapers()
        {
            var newspapers = _service.GetAllNewspapers();
            return newspapers.Select(x => new SelectListItem { Text = x.Name + ":" + x.Category, Value = x.ID.ToString() });
        }
    }
}