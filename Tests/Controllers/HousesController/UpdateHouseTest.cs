using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.Commands;
using WebAPI.Controllers.v1;


namespace Tests.Controllers.HouseController
{
    public class UpdateHouseTest
    {
        private HousesController _controller;
        private Mock<IMediator> _mediator;
        private UpdateHouseCommand _command;
        private int _houseId;

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
        public async Task ShouldSendUpdateHouseCommand()
        {
            _mediator.Setup(m => m.Send(It.IsAny<UpdateHouseCommand>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(_houseId));

            var result = await _controller.Update(_houseId, _command);

            _mediator.Verify(m => m.Send(It.IsAny<UpdateHouseCommand>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task ShouldReturnStatusOk_WhenRequestCompletesSuccessfully()
        {
            var result = await _controller.Update(_houseId, _command);

            result.Should().BeOfType<OkObjectResult>();
        }
        
        [Test]
        public async Task ShouldReturnBadRequest_WhenIdIsDifferent()
        {
            var result = await _controller.Update(1, _command);

            result.Should().BeOfType<BadRequestResult>();
        }
        
        private void CreateRequest()
        {
            _houseId = 0;

            _command = new UpdateHouseCommand
            {
                Id = _houseId,
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