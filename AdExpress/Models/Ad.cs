using System.Data.Entity;

namespace AdExpress.Models
{
    public class Ad
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        
    }
    public class AdDBContext : DbContext
    {
        public DbSet<Ad> Ads { get; set; }
    }
}
