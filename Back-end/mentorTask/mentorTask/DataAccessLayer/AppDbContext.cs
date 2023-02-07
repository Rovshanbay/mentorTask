using mentorTask.Models;
using Microsoft.EntityFrameworkCore;

namespace mentorTask.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<PricingOffer> PricingOffers { get; set; }
    }
}
