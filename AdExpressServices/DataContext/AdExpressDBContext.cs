using AdExpressServices.Models;
using System.Data.Entity;

namespace AdExpressServices.DataContext
{
    public class AdExpressDBContext:DbContext
    {
        public virtual DbSet<Ad> Ads { get; set; }
        public virtual DbSet<Newspaper> Newspapers { get; set; }
        public virtual DbSet<Association> Associations { get; set; }

        
    }
   

}