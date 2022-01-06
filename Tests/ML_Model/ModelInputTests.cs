using Application.Features.ML;
using NUnit.Framework;

namespace Tests.ML_Model
{
    public class ModelInputTests
    {
        [Test]
        public void ShouldGetAllData()
        {
            
            ModelInput modelInput = new ModelInput()
            {
                date="20141013T000000",
                Price = 221900,
                Bedrooms = 3,
                Bathrooms = 1,
                Sqft_living = 1180,
                Sqft_lot = 5650,
                Floors="1",
                Waterfront = 0,
                View = 0,
                Condition = 3,
                Grade = 7,
                Sqft_above = 1180,
                Sqft_basement = 0,
                Yr_built = 1955,
                Yr_renovated = 0,
                Zipcode="98178",
                Lat = (float) 47.5112,
                Long = (float) -122.257,
                Sqft_living15 = 1340,
                Sqft_lot15 = 5650
                
            };
            //id,date,price,bedrooms,bathrooms,sqft_living,sqft_lot,floors,waterfront,view,condition,grade,sqft_above,sqft_basement,yr_built,yr_renovated,zipcode,lat,long,sqft_living15,sqft_lot15
            //"7129300520","20141013T000000",221900,3,1,1180,5650,"1",0,0,3,7,1180,0,1955,0,"98178",47.5112,-122.257,1340,5650
            Assert.AreEqual("20141013T000000",modelInput.date);
            Assert.AreEqual(221900,modelInput.Price);
            Assert.AreEqual(3,modelInput.Bedrooms);
            Assert.AreEqual(1,modelInput.Bathrooms);
            Assert.AreEqual(1180,modelInput.Sqft_living);
            Assert.AreEqual(5650,modelInput.Sqft_lot);
            Assert.AreEqual("1",modelInput.Floors);
            Assert.AreEqual(0,modelInput.Waterfront);
            Assert.AreEqual(0,modelInput.View);
            Assert.AreEqual(3,modelInput.Condition);
            Assert.AreEqual(7,modelInput.Grade);
            Assert.AreEqual(1180,modelInput.Sqft_above);
            Assert.AreEqual(0,modelInput.Sqft_basement);
            Assert.AreEqual(1955,modelInput.Yr_built);
            Assert.AreEqual(0,modelInput.Yr_renovated);
            Assert.AreEqual("98178",modelInput.Zipcode);
            Assert.AreEqual((float)47.5112,modelInput.Lat);
            Assert.AreEqual((float)-122.257,modelInput.Long);
            Assert.AreEqual(1340,modelInput.Sqft_living15);
            Assert.AreEqual(5650,modelInput.Sqft_lot15);
            
        }
    }
}