using System;
using System.IO;
using System.Linq;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.ML;
using System.Threading.Tasks;
using Application.Features.Utils;

namespace PricePrediction
{
    public class Program 
    {
        private static readonly string TRAINING_DATA_FILEPATH 
            = "..\\Application\\Features\\ML\\kc_house_data.csv";
        private static readonly string MODEL_FILEPATH 
            = "..\\Application\\Features\\ML\\MLModel.zip";

        public async Task<float> PricePredict(PricePredictUtil data)
        {
            MLContext mlContext = new MLContext(1);
             mlContext.Data.LoadFromTextFile<ModelInput>(
                path: TRAINING_DATA_FILEPATH,
                hasHeader: true,
                separatorChar:',',
                allowQuoting:true,
                allowSparse: false);

             mlContext.Transforms.Categorical.OneHotEncoding(new[]
            {
                new InputOutputColumnPair("date", "date"),
                new InputOutputColumnPair("floors", "floors"),
                new InputOutputColumnPair("zipcode", "zipcode")
            }).Append(mlContext.Transforms.Concatenate("Features", new[]
            {
                "date",
                "bedrooms",
                "bathrooms",
                "sqft_living",
                "sqft_lot",
                "floors",
                "waterfront",
                "view",
                "condition",
                "grade",
                "sqft_above",
                "sqft_basement",
                "yr_built",
                "yr_renovated",
                "zipcode",
                "lat",
                "long",
                "sqft_living15",
                "sqft_lot15"
            }));

            ModelInput sampleData = new ModelInput()
            {
                date = "20141013T000000",
                Bedrooms = data.Bedrooms,
                Bathrooms = data.Bedrooms,
                Sqft_living = data.SquareFeet,
                Sqft_lot = 5650F,
                Floors = data.Floors,
                Waterfront = 0F,
                View = 0F,
                Condition = 3F,
                Grade = 7F,
                Sqft_above = 1180F,
                Sqft_basement = 0F,
                Yr_built = data.YearBuit,
                Yr_renovated = 0F,
                Zipcode = data.Zipcode,
                Lat = 47.5112F,
                Long = -122.257F,
                Sqft_living15 = 1340F,
                Sqft_lot15 = 5650F

            };

            ITransformer mlModel = mlContext.Model.Load(MODEL_FILEPATH, out var modelInputSchema);

            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            ModelOutput pResult = predEngine.Predict(sampleData);
            
            Console.WriteLine($"Predicted price: {pResult.Score}");

            return pResult.Score;
        }
    }
}
