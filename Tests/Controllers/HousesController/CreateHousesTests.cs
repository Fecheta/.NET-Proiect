using Application.Features.Commands;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Controllers.v1;

namespace Tests.Controllers.HouseController
{
    [TestFixture]
    public class CreateHousesTests
    {
        private HousesController _controller;
        private Mock<IMediator> _mediator;
        private CreateHouseCommand _request;

        [SetUp]
        public void Init()
        {
            _mediator = new Mock<IMediator>();
            _controller = new HousesController(_mediator.Object);

            CreateRequest();
        }

        [TearDown]
        public void Clean()
        {
            _controller = null;
        }

        [Test]
        public async Task ShouldSendCreateHouseCommand()
        {
            _mediator.Setup(m => m.Send(It.IsAny<CreateHouseCommand>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(new int()));

            var result = await _controller.Create(_request);

            _mediator.Verify(m => m.Send(It.IsAny<CreateHouseCommand>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task ShouldReturnStatusOk_WhenRequestCompletesSuccessfully()
        {
            var result = await _controller.Create(_request);

            result.Should().BeOfType<OkObjectResult>();
        }

        private void CreateRequest()
        {
            _request = new CreateHouseCommand
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
