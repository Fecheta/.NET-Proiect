using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.Utils;


namespace Tests.Controllers.PricePredictionController
{
    public class PredictPriceTest
    {
        private WebAPI.Controllers.v1.PricePredictionController _controller;
        private Mock<IMediator> _mediator;
        private PricePredictUtil _command;

        [SetUp]
        public void Init()
        {
            _mediator = new Mock<IMediator>();
            _controller = new WebAPI.Controllers.v1.PricePredictionController(_mediator.Object);

            CreateRequest();
        }

        [TearDown]
        public void Clean()
        {
            _controller = null;
        }
        
        [Test]
        public async Task ShouldSendPredictPriceCommand()
        {
            _mediator.Setup(m => m.Send(It.IsAny<PricePredictUtil>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(new float()));

            var result = await _controller.Predict(_command);

            _mediator.Verify(m => m.Send(It.IsAny<PricePredictUtil>(), It.IsAny<CancellationToken>()), Times.Once);
        }
        
        [Test]
        public async Task ShouldReturnStatusOk_WhenRequestCompletesSuccessfully()
        {
            var result = await _controller.Predict(_command);

            result.Should().BeOfType<OkObjectResult>();
        }

        private void CreateRequest()
        {
            _command = new PricePredictUtil
            {
                Zipcode = "sm11hf",
                Bedrooms = 10,
                Bathrooms = 10,
                SquareFeet = 1000,
                YearBuit = 2000,
                Floors = "10"
            };
        }
    }
}