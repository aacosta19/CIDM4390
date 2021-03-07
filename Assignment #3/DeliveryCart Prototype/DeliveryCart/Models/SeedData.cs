using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DeliveryCart.Data;
using System;
using System.Linq;

namespace DeliveryCart.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DeliveryCartContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DeliveryCartContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Products
                    {
                        ID = 1,
                        ProductName = "Milk",
                        Description = "Great Value Whole Milk, 1 Gallon",
                        Price = 2.89M,
                        StoreID = 1234
                    },
                    new Products
                    {
                        ID = 2,
                        ProductName = "Bread",
                        Description = "Pepperidge Farm White Bread, 24oz",
                        Price = 2.98M,
                        StoreID = 1234
                    }
                );
                context.SaveChanges();
            }
        }
    }
}