using Application.Features.Commands;
using Application.Interfaces;
using Domain.Entities;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Handlers
{
    [TestFixture]
    public class CreateHouseCommandHandlerTests
    {
        private Mock<IHouseRepository> _repository;
        private CreateHouseCommandHandler _handler;
        private CreateHouseCommand _command;

        [SetUp]
        public void Init()
        {
            _repository = new Mock<IHouseRepository>();
            _handler = new CreateHouseCommandHandler(_repository.Object);
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
            _repository.Setup(m => m.AddAsync(It.IsAny<House>()))
                .Returns(Task.FromResult(new House()));

            var result = await _handler.Handle(_command, new CancellationToken());

            _repository.Verify(m => m.AddAsync(It.IsAny<House>()), Times.Once);
        }

        private void CreateCommand()
        {
            _command = new CreateHouseCommand
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
    }
}
