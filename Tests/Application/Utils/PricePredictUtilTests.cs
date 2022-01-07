using Application.Features.Utils;
using NUnit.Framework;

namespace Tests.Application.Utils
{
    public class PricePredictUtilTests
    {
        [Test]
        public void TestsPricePredictUtil()
        {
            PricePredictUtil util = new PricePredictUtil
            {
                Zipcode = "sm11hf",
                Bedrooms = 10,
                Bathrooms = 2,
                SquareFeet = 100,
                YearBuit = 2000,
                Floors = "10"
            };

            Assert.AreEqual("sm11hf", util.Zipcode);
            Assert.AreEqual(10, util.Bedrooms);
            Assert.AreEqual(2, util.Bathrooms);
            Assert.AreEqual(100, util.SquareFeet);
            Assert.AreEqual(2000, util.YearBuit);
            Assert.AreEqual("10", util.Floors);
        }
    }
}