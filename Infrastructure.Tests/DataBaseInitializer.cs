using Domain.Entities;
using Persistence.Context;
using System;
using System.Linq;

namespace Infrastructure.Tests
{
    public class DatabaseInitializer
    {
        public static void Initialize(HouseContext context)
        {
            if (context.Houses.Any())
            {
                return;
            }
            Seed(context);
        }

        private static void Seed(HouseContext context)
        {
            var houses = new[]
            {
                new House
                {
                     Bathrooms = "2",
                Bedrooms = "2",
                ZipCode = "98251",
                Floors = "2",
                Id = 19382318,
                Price = "345201",
                SquareFeet = "733",
                YearBuilt = "1999"
                },
                new House
                {
                    Bathrooms = "3",
                Bedrooms = "3",
                ZipCode = "98551",
                Floors = "4",
                Id = 1938238,
                Price = "3452201",
                SquareFeet = "734",
                YearBuilt = "1998"
                }
            };

            context.Houses.AddRange(houses);
            context.SaveChanges();
        }
    }
}
