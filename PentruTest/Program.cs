using Application.Features.CSVConverter;
using System;
using Domain.Entities;
using System.Collections.Generic;

namespace PentruTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            CSVParser parser = new CSVParser(@"C:\Users\Virgil\Desktop\.NET Laborator\.NET-Proiect\PentruTest\kc_house_data.csv");

            List<HouseFullSpecifications> result = parser.parse();

            foreach(var i in result)
                Console.WriteLine(i);

            Console.WriteLine(" Count: " + result.Count + " records");
        }
    }
}
