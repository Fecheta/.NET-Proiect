using Application.Interfaces;
using Domain.Entities;
using Moq;
using NUnit.Framework;
using Persistence.Context;
using Persistence.v1;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Moq.EntityFrameworkCore;
using FluentAssertions;

namespace Tests.Repositories
{
    [TestFixture]
    public class HouseRepositoryTests
    {
        private Mock<HouseContext> _context;
        private IRepository<House> _repository;
        private House _entity;

        [SetUp]
        public void Init()
        {
            _context = new Mock<HouseContext>();
            _repository = new HouseRepository(_context.Object);
            SetupEntity();
            SetupContext();
        }

        [Test]
        public async Task ShouldAddCorrectHouse()
        {
            var res = await _repository.AddAsync(_entity);

            _context.Verify(c => c.Houses.AddAsync(It.Is<House>(h =>
                      h.Bedrooms == _entity.Bedrooms
                      && h.Bathrooms == _entity.Bathrooms
                      && h.SquareFeet == _entity.SquareFeet
                      && h.Floors == _entity.Floors
                      && h.ZipCode == _entity.ZipCode
                      && h.YearBuilt == _entity.YearBuilt
                      && h.Price == _entity.Price), new CancellationToken()), Times.Never);
        }

        private void SetupEntity()
        {
            _entity = new House
            {
                Bedrooms = "2",
                Bathrooms = "2",
                SquareFeet = "300",
                Floors = "3",
                ZipCode = "61106",
                YearBuilt = "2000",
                Price = "200000",
            };
        }

        private void SetupContext()
        {
            _context.Setup(c => c.Houses).ReturnsDbSet(
                new List<House>());
        }

        [TearDown]
        public void Clear()
        {
            _context = null;
            _repository = null;
        }
    }
}
