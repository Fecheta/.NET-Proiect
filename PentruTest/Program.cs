using Application.Features.CSVConverter;
using System;
using Domain.Entities;
using System.Collections.Generic;
using Application.Interfaces;
using Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace PentruTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //CSVParser parser = new CSVParser(@"C:\Users\Virgil\Desktop\.NET Laborator\.NET-Proiect\PentruTest\kc_house_data.csv");

            //List<HouseFullSpecifications> result = parser.parse();

            ////foreach(var i in result)
            ////     Console.WriteLine(i);

            //var outdef = 0m;
            //var contectOptions = new DbContextOptionsBuilder<HouseContext>()
            //    .UseSqlite(@"Data Source=C:\Users\Virgil\Desktop\.NET Laborator\.NET-Proiect\WebAPI\MyHouses.db");

            //HouseContext context = new HouseContext(contectOptions.Options);


            //for (int i = 0; i < 10; i++)
            //{
            //    House h = new House
            //    {
            //        Id = Guid.NewGuid(),
            //        Bedrooms = result[i].bedrooms,
            //        Bathrooms = result[i].bathrooms,
            //        SquareFeet = result[i].sqft_living,
            //        Floors = result[i].floors,
            //        ZipCode = result[i].zipcode,
            //        YearBuilt = result[i].yr_built,
            //        Price = result[i].price
            //    };

            //    Console.WriteLine(h);

            //    context.AddAsync(h);
            //}

            //context.SaveChanges();

            //Console.WriteLine(" Count: " + result.Count + " records");
        }
    }
}
