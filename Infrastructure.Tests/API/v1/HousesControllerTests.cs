using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Queries;
using FakeItEasy;
using MediatR;
using WebAPI.Controllers.v1;
using Xunit;

namespace Infrastructure.Tests.API.v1
{
    public class HousesControllerTests
    {
        private readonly HousesController controller;
        private readonly IMediator mediator;

        public HousesControllerTests()
        {
            mediator = A.Fake<IMediator>();
            controller = new HousesController(mediator);
        }

        [Fact]
        public async void Given_HousesController_When_GetIsCalled_Then_ShouldReturnA_HouseCollection()
        {
            // Arrange&& act
            await controller.Get();
            A.CallTo(() => mediator.Send(A<GetHousesQuery>._, default)).MustHaveHappenedOnceExactly();
        }

    }
}
