using System.Collections.Generic; 
using System.Data.Entity; 
using System.Linq; 
using System.Threading.Tasks;
using AdExpress.Models;

namespace AdExpressService
{
    public class AdExpressDataService: IAdExpressDataService
    {
        private AdDBContext _context;

         public AdExpressDataService(AdDBContext context) 
        { 
            _context = context; 
        }

         public Ad AddAd(string name, string version)
         {
             var ad = _context.Ads.Add(new Ad {Title = name, Version = version });
             _context.SaveChanges();

             return ad;
         }

        public List<Ad> GetAllAdsList()
         {
             var query = from a in _context.Ads
                         orderby a.Title
                         select a;

             return query.ToList();
         } 
        public int GetAdName(int id)
        {
            return id;
        }
    }
}
