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
                        Name = "Cafe",
                        Description = "bitter, have milk and sugar",
                        Status = "A half",
                        Price = 100
                    },
                    new Product
                    {
                        Name = "Milk",
                        Description = "sweet, 50% sugar",
                        Status = "Full",
                        Price = 80
                    },
                    new Product
                    {
                        Name = "Smoothie",
                        Description = "sweet, healthy",
                        Status = "Full",
                        Price = 150
                    },
                    new Product
                    {
                        Name = "Milk tea",
                        Description = "Sweet, 50% ice, 50% sugar",
                        Status = "Full",
                        Price = 120
                    },
                    new Product
                    {
                        Name = "Yogurt",
                        Description = "Sour, sweet",
                        Status = "A half",
                        Price = 155
                    },
                    new Product
                    {
                        Name = "Tea",
                        Description = "bitter",
                        Status = "A half",
                        Price = 125
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
