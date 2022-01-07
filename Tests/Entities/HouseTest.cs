using Domain.Entities;
using NUnit.Framework;


namespace Tests.Entities
{
    public class HouseTest
    {
        [Test]
        public void HouseTests()
        {
            //Arragne
            House house = new House
            {
                Bedrooms = "10",
                Bathrooms = "2",
                SquareFeet = "2323",
                Floors = "2",
                ZipCode = "23dt",
                YearBuilt = "2000",
                Price = "101300"
            };
            
            // Assert.
            Assert.AreEqual("10", house.Bedrooms);
            Assert.AreEqual(" 10 2 2323 2 23dt 2000 101300 0", house.ToString());
        }

        [Test]
        public void HouseSetTests()
        {
            //Arrange
            House house = new House
            {
                Id = 10,
                Bedrooms = "10",
                Bathrooms = "2",
                SquareFeet = "2323",
                Floors = "2",
                ZipCode = "23dt",
                YearBuilt = "2000",
                Price = "101300"
            };

            Assert.AreEqual(10, house.Id);
        }
    }
}