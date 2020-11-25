using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksStore.Models
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
                        Name = "Milk Coffee",
                        Description = "bitter, have milk and sugar",
                        Status = "A half",
                        Price = 100,
                        Category = "Coffee"
                    },
                    new Product
                    {
                        Name = "Black Coffee",
                        Description = "bitter, brown",
                        Status = "Full",
                        Price = 150,
                        Category = "Coffee"
                    },
                    new Product
                    {
                        Name = "Iced Milk Moffee",
                        Description = "bitter,have milk, sugar and ice",
                        Status = "A quater",
                        Price = 80,
                        Category = "Coffee"
                    },
                    new Product
                    {
                        Name = "Milk",
                        Description = "sweet, 50% sugar",
                        Status = "Full",
                        Price = 80,
                        Category = "Healthy drink"
                    },

                    new Product
                    {
                        Name = "Smoothie",
                        Description = "sweet, healthy",
                        Status = "Full",
                        Price = 150,
                        Category = "Healthy drink"
                    },
                    new Product
                    {
                        Name = "Yogurt",
                        Description = "Sour, sweet",
                        Status = "A half",
                        Price = 155,
                        Category = "Healthy drink"
                    },
                    new Product
                    {
                        Name = "Milk tea",
                        Description = "Sweet, 50% ice, 50% sugar",
                        Status = "Full",
                        Price = 120,
                        Category = "Milk tea and tea"
                    },
                   
                    new Product
                    {
                        Name = "Tea",
                        Description = "bitter, odorous",
                        Status = "A half",
                        Price = 125,
                        Category = "Milk tea and tea"
                    },
                    new Product
                    {
                        Name = "Matcha",
                        Description = "sweet, odorous",
                        Status = "A half",
                        Price = 155,
                        Category = "Milk tea and tea"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
