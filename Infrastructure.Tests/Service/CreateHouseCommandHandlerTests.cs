using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;
using FakeItEasy;
using System.Threading.Tasks;
using Xunit;

namespace Infrastructure.Tests.Service
{
    public class CreateHouseCommandHandlerTests
    {
        private readonly Application.Features.Commands.CreateHouseCommandHandler handler;
        private readonly Application.Interfaces.IHouseRepository repository;

        public CreateHouseCommandHandlerTests()
        {
            this.repository = A.Fake<Application.Interfaces.IHouseRepository>();
            this.handler = new Application.Features.Commands.CreateHouseCommandHandler(this.repository);
        }

        [Fact]
        public async Task Given_CreateHouseCommandHandler_When_HandleISCalled_Then_AddAsyncHouseIsCalled()
        {
            // Arrange & Act
            await handler.Handle(new Application.Features.Commands.CreateHouseCommand(), default);
            // Assert
            A.CallTo(() => repository.AddAsync(A<House>._)).MustHaveHappenedOnceExactly();
        }
    }
}
