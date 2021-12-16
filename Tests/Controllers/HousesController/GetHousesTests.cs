using Application.Features.Queries;
using Domain.Entities;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Controllers.v1;

namespace Tests.Controllers.HouseController
{
    [TestFixture]
    public class GetHousesTests
    {
        private HousesController _controller;
        private Mock<IMediator> _mediator;
        private GetHousesQuery _request;

        [SetUp]
        public void Init()
        {
            _mediator = new Mock<IMediator>();
            _controller = new HousesController(_mediator.Object);
            _request = new GetHousesQuery();
        }

        [TearDown]
        public void Clean()
        {
            _controller = null;
        }

        [Test]
        public async Task ShouldSendGetHousesQuery()
        {   
            _mediator.Setup(m => m.Send(It.IsAny<GetHousesQuery>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(new List<House>()));

            var result = await _controller.Get();

            _mediator.Verify(m => m.Send(It.IsAny<GetHousesQuery>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task ShouldReturnStatusOk_WhenRequestCompletesSuccessfully()
        {
            var result = await _controller.Get();

            result.Should().BeOfType<OkObjectResult>();
        }

    }
}
