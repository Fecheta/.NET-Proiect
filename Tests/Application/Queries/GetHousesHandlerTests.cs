using System;
using System.Collections.Generic;
using Application.Interfaces;
using Domain.Entities;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.Queries;
using static System.Threading.Tasks.Task;


namespace Tests.Application.Queries
{
    public class GetHousesHandlerTests
    {
        private Mock<IHouseRepository> _repository;
        private GetHousesQueryHandler _handler;
        private GetHousesQuery _query;

        [SetUp]
        public void Init()
        {
            _repository = new Mock<IHouseRepository>();
            _handler = new GetHousesQueryHandler(_repository.Object);
            CreateCommand();
        }

        [TearDown]
        public void Clear()
        {
            _repository = null;
            _handler = null;
        }

        [Test]
        public async Task ShouldGetHouses()
        {
            _repository.Setup(m => m.GetAllAsync())
                .Returns(Task.FromResult<IEnumerable<House>>(new List<House>()));

            var result = await _handler.Handle(_query, new CancellationToken());

            // _repository.Verify(m => m.DeleteAsync(It.IsAny<House>()), Times.Once);
        }


        private void CreateCommand()
        {
            _query = new GetHousesQuery();
        }
    }
}