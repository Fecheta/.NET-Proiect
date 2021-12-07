using Application.Interfaces;
using Domain.Entities;
using FluentAssertions;
using Infrastructure.Tests;
using Persistence.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Infrastructure.Tests.Data
{
    public class HouseRepositoryTest : DataBaseTest
    {
        private readonly Repository<House> repository;
        private readonly House newHouse;

        public HouseRepositoryTest()
        {
            repository = new Repository<House>(context);
            newHouse = new House()
            {
                Bathrooms = "2",
                Bedrooms = "2",
                ZipCode = "98251",
                Floors = "2",
                Id = 193838,
                Price = "345201",
                SquareFeet = "733",
                YearBuilt = "1999"
            };
              
        }

        [Fact]
        public async void Given_NewHouse_WhenProductIsNotNull_Then_AddAsynsShouldReturnANewProduct()
        {
            var result = await repository.AddAsync(newHouse);

            result.Should().BeOfType<House>();

        }
    }
}
