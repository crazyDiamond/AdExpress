using System.Data.Entity;

namespace AdExpressServices.Models
{
    public class Newspaper
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

    }

   /* public class NewspaperDBContext : DbContext
    {
        public virtual DbSet<Newspaper> Newspapers { get; set; }
    }*/
}