using System;
using Application.Interfaces;
using Domain.Entities;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.Queries;


namespace Tests.Application.Queries
{
    public class GetHouseByIdHandlerTests
    {
        private Mock<IHouseRepository> _repository;
        private GetHouseByIdQueryHandler _handler;
        private GetHouseByIdQuery _query;

        [SetUp]
        public void Init()
        {
            _repository = new Mock<IHouseRepository>();
            _handler = new GetHouseByIdQueryHandler(_repository.Object);
            CreateCommand();
        }

        [TearDown]
        public void Clear()
        {
            _repository = null;
            _handler = null;
        }

        [Test]
        public async Task ShouldGetHouseById()
        {
            _repository.Setup(m => m.GetByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(new House()));

            var result = await _handler.Handle(_query, new CancellationToken());

            // _repository.Verify(m => m.DeleteAsync(It.IsAny<House>()), Times.Once);
        }
        
        [Test]
        public async Task ShouldThrowArgumentNullException()
        {
            _repository.Setup(m => m.GetByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult<House>(null));
            
            try
            {
                var result = await _handler.Handle(_query, new CancellationToken());
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual("No house with this id was found (Parameter 'request')", e.Message);
            }
        }
        

        private void CreateCommand()
        {
            _query = new GetHouseByIdQuery
            {
                Id = 0
            };
        }
    }
}