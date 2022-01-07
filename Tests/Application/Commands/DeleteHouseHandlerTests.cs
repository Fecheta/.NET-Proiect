using Application.Features.Commands;
using Application.Interfaces;
using Domain.Entities;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;


namespace Tests.Application.Commands
{
    public class DeleteHouseHandlerTests
    {
        private Mock<IHouseRepository> _repository;
        private DeleteHouseCommandHandler _handler;
        private DeleteHouseCommand _command;

        [SetUp]
        public void Init()
        {
            _repository = new Mock<IHouseRepository>();
            _handler = new DeleteHouseCommandHandler(_repository.Object);
            CreateCommand();
        }

        [TearDown]
        public void Clear()
        {
            _repository = null;
            _handler = null;
        }

        [Test]
        public async Task ShouldSendHouse()
        {
            _repository.Setup(m => m.GetByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(new House()));

            var result = await _handler.Handle(_command, new CancellationToken());

            _repository.Verify(m => m.DeleteAsync(It.IsAny<House>()), Times.Once);
        }

        private void CreateCommand()
        {
            _command = new DeleteHouseCommand
            {
                Id = 0,
                Bedrooms = "2",
                Bathrooms = "2",
                SquareFeet = "300",
                Floors = "3",
                ZipCode = "61106",
                YearBuilt = "2000",
                Price = "200000",
            };
        }
    }
}