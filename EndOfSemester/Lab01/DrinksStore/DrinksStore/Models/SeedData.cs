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
            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                     new Product
                     {
                         Name = "Blueberry milk tea",
                         Description = "Good Housekeeping:Goat Milk Nutrition - Health Benefits of Goat Milk",
                         Img = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/health-benefits-of-goat-milk-1586900792.jpg?crop=0.668xw:1.00xh;0.259xw,0&resize=480:*",
                         Price = 55,
                         Discount = 1.5,
                         Status = "60 products left",
                         Category = "Milk Tea"
                     },
                     new Product
                     {
                         Name = "Black sugar bubble milk tea",
                         Description = "It has bubble; very sweet, delicious",
                         Img = "https://img1.mashed.com/img/uploads/2017/05/soy-milk.jpg",
                         Price = 55,
                         Discount = 1.5,
                         Status = "50 products left",
                         Category = "Milk Tea"
                     },
                     new Product
                     {
                         Name = "Matcha milk tea",
                         Description = "It has matcha, ice cream, milk, ice..",
                         Img = "https://www.earthfoodandfire.com/wp-content/uploads/2018/04/Homemade-Orange-Juice.jpg",
                         Price = 55,
                         Discount = 1.0,
                         Status = "55 products left",
                         Category = "Milk Tea"
                     },
                     new Product
                     {
                         Name = "Almond milk",
                         Description = "Almond milk is the latest alternative milk",
                         Img = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/apple-cider-vs-apple-juice-difference-1565205829.jpg?crop=1.00xw:0.753xh;0,0.247xh&resize=1200:*",
                         Price = 75,
                         Discount = 0,
                         Status = "50 products left",
                         Category = "Smoothie"
                     },
                     new Product
                     {
                         Name = "Walnut milk",
                         Description = "Walnut milk is the latest alternative milk",
                         Img = "https://stylesatlife.com/wp-content/uploads/2018/12/Uses-of-Barley-Water-During-Pregnancy-1.jpg",
                         Price = 75,
                         Discount = 1.5,
                         Status = "80 products left",
                         Category = "Smoothie"
                     },
                     new Product
                     {
                         Name = "Milk",
                         Description = "Nutrition from cow's milk",
                         Img = "https://www.tasteofhome.com/wp-content/uploads/2019/04/watermelon-juice-shutterstock_285112223.jpg",
                         Price = 45,
                         Discount = 2.0,
                         Status = "100 products left",
                         Category = "Smoothie"
                     },
                     new Product
                     {
                         Name = "Milk coffee",
                         Description = "It has 50% milk; sweet, delicious",
                         Img = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/apple-cider-vs-apple-juice-difference-1565205829.jpg?crop=1.00xw:0.753xh;0,0.247xh&resize=1200:*",
                         Price = 70,
                         Discount = 0,
                         Status = "32 products left",
                         Category = "Coffee"
                     },
                     new Product
                     {
                         Name = "Instant coffee",
                         Description = "%40 sugar; 20% milk",
                         Img = "https://stylesatlife.com/wp-content/uploads/2018/12/Uses-of-Barley-Water-During-Pregnancy-1.jpg",
                         Price = 45,
                         Discount = 1.5,
                         Status = "50 products left",
                         Category = "Coffee"
                     },
                     new Product
                     {
                         Name = "Black coffee",
                         Description = "bitter; the pure coffee",
                         Img = "https://www.tasteofhome.com/wp-content/uploads/2019/04/watermelon-juice-shutterstock_285112223.jpg",
                         Price = 48,
                         Discount = 5.0,
                         Status = "45 products left",
                         Category = "Coffee"
                     }

                );
                context.SaveChanges();
            }
        }
    }
}
