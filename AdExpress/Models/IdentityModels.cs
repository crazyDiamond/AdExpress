using Microsoft.AspNet.Identity.EntityFramework;

namespace AdExpress.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<AdExpress.Models.NewspaperViewModel> NewspaperViewModels { get; set; }

        public System.Data.Entity.DbSet<AdExpress.Models.AssociationViewModel> AssociationViewModels { get; set; }

        public System.Data.Entity.DbSet<AdExpress.AdExpressWcfService.Association> Associations { get; set; }
    }
}