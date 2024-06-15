namespace Auctions.Data
{
    public class ApplicationDbContext : IdentityDbcontext
    {
        public ApplicationDbContext(DbContextOption<ApplicationDbContext> options):base(options) { 
        
        
        }
    }
}
