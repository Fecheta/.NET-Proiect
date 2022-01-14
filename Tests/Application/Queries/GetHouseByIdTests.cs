using Application.Features.Queries;
using NUnit.Framework;

namespace Tests.Application.Queries
{
    public class GetHouseByIdTests
    {
        [Test]
        public void TestGetHouseById()
        {
            GetHouseByIdQuery query = new GetHouseByIdQuery
            {
                Id = 10
            };
            
            Assert.AreEqual(10, query.Id);
        }
    }
}