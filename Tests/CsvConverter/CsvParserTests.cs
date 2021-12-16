using System.IO;
using System.Reflection;
using Application.Features.CSVConverter;
using NUnit.Framework;

namespace Tests.CsvConverter
{
    public class CsvParserTests
    {
        [Test]
        public void Parse_Test()
        { 
            //Arrange
            string file = @"..\..\..\CsvConverter\TestData.csv";
            string dir = Directory.GetCurrentDirectory();
            
            var path = Path.Combine(dir, file);
            
            
            var csvParser = new CsvParser(path);

            //Act
            var lineList = csvParser.parse();

            //Assert
            Assert.AreEqual("7129300520", lineList[0].id);
            Assert.AreEqual("20141013T000000", lineList[0].date);
            Assert.AreEqual("221900", lineList[0].price);
            Assert.AreEqual("3", lineList[0].bedrooms);
            Assert.AreEqual("1", lineList[0].bathrooms);
            Assert.AreEqual("1180", lineList[0].sqft_living);
            Assert.AreEqual("5650", lineList[0].sqft_lot);
            Assert.AreEqual("1", lineList[0].floors);
            Assert.AreEqual("0", lineList[0].waterfront);
            Assert.AreEqual("0", lineList[0].view);
            Assert.AreEqual("3", lineList[0].condition);
            Assert.AreEqual("7", lineList[0].grade);
            Assert.AreEqual("1180", lineList[0].sqft_above);
            Assert.AreEqual("0", lineList[0].sqft_basement);
            Assert.AreEqual("1955", lineList[0].yr_built);
            Assert.AreEqual("0", lineList[0].yr_renovated);
            Assert.AreEqual("98178", lineList[0].zipcode);
            Assert.AreEqual("47.5112", lineList[0].lat);
            Assert.AreEqual("-122.257", lineList[0].longt);
            Assert.AreEqual("1340", lineList[0].sqft_living15);
            Assert.AreEqual("5650", lineList[0].sqft_lot15);
            
        }
        
    }
}