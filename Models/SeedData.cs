using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPlate.Data;
using System;
using System.Linq;

namespace MvcPlate.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPlateContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPlateContext>>()))
            {
                // Look for any movies.
                if (context.Plate.Any())
                {
                    return;   // DB has been seeded
                }

                context.Plate.AddRange(
                    new Plate
                    {
                        Name = "Eleganza Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen="Germany",
                        Color="White",
                        Size= 17.00M,
                        Price = 7.99M,
                        Rating= 1.00M
                    },

                    new Plate
                    {
                        Name = "Confort Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen = "Germany",
                        Color = "White",
                        Size = 17.00M,
                        Price = 7.99M,
                        Rating = 1.00M
                    },

                    new Plate
                    {
                        Name = "Fashion Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen = "Germany",
                        Color = "White",
                        Size = 17.00M,
                        Price = 7.99M,
                        Rating = 1.00M
                    },

                    new Plate
                    {
                        Name = "Traditional Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen = "Germany",
                        Color = "White",
                        Size = 17.00M,
                        Price = 7.99M,
                        Rating = 1.00M
                    },
                    new Plate
                    {
                        Name = "Plastic Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen = "Germany",
                        Color = "White",
                        Size = 17.00M,
                        Price = 7.99M,
                        Rating = 1.00M
                    },
                    new Plate
                    {
                        Name = "Kids Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen = "Germany",
                        Color = "White",
                        Size = 17.00M,
                        Price = 7.99M,
                        Rating = 1.00M
                    },
                    new Plate
                    {
                        Name = "Simple Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen = "Germany",
                        Color = "White",
                        Size = 17.00M,
                        Price = 7.99M,
                        Rating = 1.00M
                    },
                    new Plate
                    {
                        Name = "ABC Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen = "Germany",
                        Color = "White",
                        Size = 17.00M,
                        Price = 7.99M,
                        Rating = 1.00M
                    },
                    new Plate
                    {
                        Name = "Blue Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen = "Germany",
                        Color = "White",
                        Size = 17.00M,
                        Price = 7.99M,
                        Rating = 1.00M
                    },
                    new Plate
                    {
                        Name = "Velvet Plates",
                        StockDate = DateTime.Parse("2019-2-12"),
                        Description = "The plates has an elegant edge with oro 18k",
                        Origen = "Germany",
                        Color = "White",
                        Size = 17.00M,
                        Price = 7.99M,
                        Rating = 1.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}