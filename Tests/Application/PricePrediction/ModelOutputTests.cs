using NUnit.Framework;
using PricePrediction;

namespace Tests.Application.PricePrediction
{
    public class ModelOutputTests
    {
        [Test]
        public void ModelOutputTestGetAndSet()
        {

            ModelOutput model = new ModelOutput
            {
                Score = 12345
            };

            Assert.AreEqual(12345, model.Score);
        }
    }
}