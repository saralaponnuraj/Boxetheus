using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Boxetheus.Data;
using System;
using System.Linq;
namespace Boxetheus.Models
{
    public static class SeedData
    { 
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BoxetheusContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BoxetheusContext>>()))
        {
            // Look for any movies.
            if (context.BoxView.Any())
            {
                return;   // DB has been seeded
            }
            context.BoxView.AddRange(
                new BoxView
                {
                    Brand = "Boxify",
                    Category = "Cosmetic Box",
                    Design = "Floral Design",
                    Shape = "Oval",
                    Size = "Medium",
                    Quantity = 10,
                    Price = 277.50M
                },
                new BoxView
                {
                    Brand = "CargoCove",
                    Category = "Toy Box",
                    Design = "Cartoon Characters",
                    Shape = "Custom Shape",
                    Size = "Large",
                    Quantity = 15,
                    Price = 80.49M
                },
                new BoxView
                {
                    Brand = "FlexiBox",
                    OrderDate = DateTime.Now,
                    Category = "Shipping Box",
                    Design = "Stripes",
                    Shape = "Standard",
                    Size = "Abstract Art",
                    Quantity = 100,
                    Price = 259.59M
                },
                new BoxView
                {
                    Brand = "PackMaster",
                    OrderDate = DateTime.Now,
                    Category = "Electronic Product Box",
                    Design = "Geometric Patterns",
                    Shape = "Extra Large",
                    Size = "Vintage Patterns",
                    Quantity = 12,
                    Price = 183.29M
                },
                new BoxView
                {
                    Brand = "CrateCraze",
                    OrderDate = DateTime.Now,
                    Category = "Food Packaging Box",
                    Design = "Stripes",
                    Shape = "Rectangular",
                    Size = "Large",
                    Quantity = 50,
                    Price = 53.97M
                },
                new BoxView
                {
                    Brand = "BoxLuxe",
                    OrderDate = DateTime.Now,
                    Category = "Jewelry Box",
                    Design = "Minimalist Design",
                    Shape = "Square",
                    Size = "Medium",
                    Quantity = 8,
                    Price = 250.39M
                },
                new BoxView
                {
                    Brand = "SturdyBox",
                    OrderDate = DateTime.Now,
                    Category = "Gift Box",
                    Design = "Minimalist Design",
                    Shape = "Oval",
                    Size = "Small",
                    Quantity = 2,
                    Price = 105.50M
                },
                new BoxView
                {
                    Brand = "SecurePack",
                    OrderDate = DateTime.Now,
                    Category = "Moving Box",
                    Design = "Stripes",
                    Shape = "Square",
                    Size = "Extra Large",
                    Quantity = 6,
                    Price = 103.15M
                },
                new BoxView
                {
                    Brand = "PrimePack",
                    OrderDate = DateTime.Now,
                    Category = "Storage Box",
                    Design = "Polka Dots",
                    Shape = "Square",
                    Size = "Extra Large",
                    Quantity = 4,
                    Price = 83.09M
                }
            );
            context.SaveChanges();
        }
    }
}
}
