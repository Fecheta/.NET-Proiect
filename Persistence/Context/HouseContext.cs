using Application.Features.CSVConverter;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class HouseContext : DbContext
    {

        public HouseContext(DbContextOptions<HouseContext> options) : base(options)
        {
        }

        public DbSet<House> Houses { get ; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=..\Persistence\MyHouses.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House>().Property(house => house.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<House>().HasData(Seeding().ToArray());
        }

        private List<House> Seeding()
        {
            CSVParser parser = new CSVParser(@"..\Persistence\kc_house_data.csv");

            //dam pathul intreg pentru ca la teste nu gaseste csv ul 
           /* CSVParser parser = new CSVParser(@"C:\Users\Filip Martisca\Desktop\HousePricePredction\.NET-Proiect\Persistence\kc_house_data.csv");
*/

            List<HouseFullSpecifications> parsedHouses = parser.parse();
            List<House> result = new List<House>();
            int id = 0;

            foreach(var houseFullSpecificated in parsedHouses)
            {
                id++;
                if (id > 1000) break;
                try {
                    House h = new House
                    {
                        Id = id,
                        Bedrooms = houseFullSpecificated.bedrooms,
                        Bathrooms = houseFullSpecificated.bathrooms,
                        SquareFeet = houseFullSpecificated.sqft_living,
                        Floors = houseFullSpecificated.floors,
                        ZipCode = houseFullSpecificated.zipcode,
                        YearBuilt = houseFullSpecificated.yr_built,
                        Price = houseFullSpecificated.price
                    };
                    result.Add(h);
                } catch(OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return result;
        }
    }
}
