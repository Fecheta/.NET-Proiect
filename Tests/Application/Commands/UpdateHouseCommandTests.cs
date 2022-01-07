using Application.Features.Commands;
using NUnit.Framework;

namespace Tests.Application.Commands
{
    public class UpdateHouseCommandTests
    {
        [Test]
        public void TestUpdateHouseCommand()
        {
            //Arrange
            UpdateHouseCommand command = new UpdateHouseCommand
            {
                Id = 0,
                Bedrooms = "10",
                Bathrooms = "2",
                SquareFeet = "10987",
                Floors = "2",
                ZipCode = "sm11hf",
                YearBuilt = "2000",
                Price = "313748"
            };

            Assert.AreEqual(0, command.Id);
            Assert.AreEqual("10", command.Bedrooms);
            Assert.AreEqual("2", command.Bathrooms);
            Assert.AreEqual("10987", command.SquareFeet);
            Assert.AreEqual("2", command.Floors);
            Assert.AreEqual("sm11hf", command.ZipCode);
            Assert.AreEqual("2000", command.YearBuilt);
            Assert.AreEqual("313748", command.Price);
        }
    }
}