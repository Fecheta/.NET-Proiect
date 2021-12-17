using Application.Features.Queries;
using Domain.Entities;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Controllers.v1;

namespace Tests.Controllers.HouseController
{
    [TestFixture]
    public class GetHouseByIdTests
    {
        private HousesController _controller;
        private Mock<IMediator> _mediator;

        [SetUp]
        public void Init()
        {
            _mediator = new Mock<IMediator>();
            _controller = new HousesController(_mediator.Object);  
        }

        [TearDown]
        public void Clean()
        {
            _controller = null;
        }

        [Test]
        public async Task ShouldSendGetHouseByIdQuery()
        {
            _mediator.Setup(m => m.Send(It.IsAny<GetHouseByIdQuery>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(new House()));

            var result = await _controller.GetById(5);

            _mediator.Verify(m => m.Send(It.IsAny<GetHouseByIdQuery>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task ShouldReturnStatusOk_WhenRequestCompletesSuccessfully()
        {
            var result = await _controller.GetById(5);

            result.Should().BeOfType<OkObjectResult>();
        }

    }
}
