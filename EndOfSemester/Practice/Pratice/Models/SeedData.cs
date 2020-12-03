using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Pratice.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeeDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<EmployeeDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                     new Employee
                     {
                         FristName = "Pham Thi",
                         LastName = "Lien",
                         gender = "Nu",
                         Salary = 1000
                     },
                     new Employee
                     {
                         FristName = "Nguyen Giang",
                         LastName = "Son",
                         gender = "Nam",
                         Salary = 1050
                     },
                     new Employee
                     {
                         FristName = "Mai Tai",
                         LastName = "Phen",
                         gender = "Nu",
                         Salary = 2000
                     },
                     new Employee
                     {
                         FristName = "Pham Thi",
                         LastName = "My Tam",
                         gender = "Nu",
                         Salary = 2500
                     },
                     new Employee
                     {
                         FristName = "Phan Thanh",
                         LastName = "Phung",
                         gender = "Nam",
                         Salary = 2080
                     }
            );
                context.SaveChanges();
            }
        }
    }
}