using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DrinkStore.Models;
using OrderStore.Models;

namespace DrinkStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Status = "New",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Kayak1",
                        Description = "A boat for one person",
                        Status = "New",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Kayak2",
                        Description = "A boat for one person",
                        Status = "New",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Kayak3",
                        Description = "A boat for one person",
                        Status = "New",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Kayak4",
                        Description = "A boat for one person",
                        Status = "New",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Kayak5",
                        Description = "A boat for one person",
                        Status = "New",
                        Price = 275
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
