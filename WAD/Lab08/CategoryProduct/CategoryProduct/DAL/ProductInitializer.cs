using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CategoryProduct.Models;
using CategoryProduct.DAL;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
            new Product{ProductName="Product1"},
            new Product{ProductName="Product2"},
            new Product{ProductName="Product3"},
            new Product{ProductName="Product4"},
            new Product{ProductName="Product5"},
            
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var categories = new List<Category>
            {
            new Category{CategoryID=11, Name="Category1"},
            new Category{CategoryID=12, Name="Category2"},
            new Category{CategoryID=13, Name="Category3"},
            new Category{CategoryID=14, Name="Category4"},
            new Category{CategoryID=15, Name="Category5"},
            
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
            var productions = new List<Production>
            {
            new Production{CategoryID=11, ProductID=1, Grade=Grade.A},
            new Production{CategoryID=12, ProductID=2, Grade=Grade.C},
            new Production{CategoryID=13, ProductID=3, Grade=Grade.B},
            new Production{CategoryID=14, ProductID=4, Grade=Grade.B},
            new Production{CategoryID=15, ProductID=5, Grade=Grade.F},
            };
            productions.ForEach(s => context.Productions.Add(s));
            context.SaveChanges();
        }
    }
}