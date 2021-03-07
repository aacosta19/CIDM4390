using Microsoft.EntityFrameworkCore;

namespace DeliveryCart.Data
{
    public class DeliveryCartContext : DbContext
    {
        public DeliveryCartContext (
            DbContextOptions<DeliveryCartContext> options)
            : base(options)
        {
        }

        public DbSet<DeliveryCart.Models.Products> Products { get; set; }
    }
}