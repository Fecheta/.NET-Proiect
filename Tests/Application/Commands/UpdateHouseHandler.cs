using System;
using Application.Features.Commands;
using Application.Interfaces;
using Domain.Entities;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;


namespace Tests.Application.Commands
{
    public class UpdateHouseHandler
    {
        public class UpdateHouseHandlerTests
        {
            private Mock<IHouseRepository> _repository;
            private UpdateHouseCommandHandler _handler;
            private UpdateHouseCommand _command;

            [SetUp]
            public void Init()
            {
                _repository = new Mock<IHouseRepository>();
                _handler = new UpdateHouseCommandHandler(_repository.Object);
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

                _command.Id = 1000;
                var result = await _handler.Handle(_command, new CancellationToken());

                _repository.Verify(m => m.UpdateAsync(It.IsAny<House>()), Times.Once);
            }
            
            [Test]
            public async Task ShouldThrowException()
            {
                _repository.Setup(m => m.GetByIdAsync(It.IsAny<int>()))
                    .Returns(Task.FromResult<House>(null));

                _command.Id = 1000;
                Assert.Throws<ArgumentNullException>(() => _handler.Handle(_command, new CancellationToken()));
            }

            private void CreateCommand()
            {
                _command = new UpdateHouseCommand
                {
                    Id = 700,
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
}