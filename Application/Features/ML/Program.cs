using System;
using System.Threading.Tasks;
using Application.Features.Utils;
using Microsoft.ML;
using PricePrediction;

namespace Application.Features.ML
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
            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                path: TRAINING_DATA_FILEPATH,
                hasHeader: true,
                separatorChar: ',',
                allowQuoting: true,
                allowSparse: false);

            var dataProcessPipeline = mlContext.Transforms.Categorical.OneHotEncoding(new[]
            {
                new InputOutputColumnPair("date", "date"),
                new InputOutputColumnPair("floors", "floors"),
                new InputOutputColumnPair("zipcode", "zipcode")
            }).Append(mlContext.Transforms.Concatenate("Features", new[]
            {
                "bedrooms",
                "bathrooms",
                "sqft_living",
                "floors",
                "yr_built",
                "zipcode"

            }));

            //UNCOMMENT FOR TRAINING

            //var settings = new RegressionExperimentSettings()
            //{
            //    MaxExperimentTimeInSeconds = 10
            //};
            //var experiment = mlContext.Auto().CreateRegressionExperiment(settings);
            //var progress = new Progress<RunDetail<RegressionMetrics>>(p =>
            //{
            //    if (p.ValidationMetrics != null)
            //    {
            //        Console.Write($"Current result: {p.TrainerName}");
            //        Console.Write($"      {p.ValidationMetrics.RSquared}");
            //        Console.Write($"      {p.ValidationMetrics.MeanAbsoluteError}");
            //        Console.WriteLine();
            //    }
            //});

            //var result = experiment.Execute(trainingDataView, labelColumnName: "price", progressHandler: progress);

            //Console.WriteLine("Best run:");
            //Console.WriteLine($"Trainer name - {result.BestRun.TrainerName}");
            //Console.WriteLine($"RSquared - {result.BestRun.ValidationMetrics.RSquared}");
            //Console.WriteLine($"MAE - {result.BestRun.ValidationMetrics.MeanAbsoluteError}");


            //var trainer = mlContext.Regression.Trainers.LightGbm(labelColumnName: "price", featureColumnName: "Features");
            //var trainingPipeline = dataProcessPipeline.Append(trainer);
            //ITransformer model = trainingPipeline.Fit(trainingDataView);

            //mlContext.Model.Save(model,trainingDataView.Schema,MODEL_FILEPATH);


            //id,date,price,bedrooms,bathrooms,sqft_living,sqft_lot,floors,waterfront,view,condition,grade,sqft_above,sqft_basement,yr_built,yr_renovated,zipcode,lat,long,sqft_living15,sqft_lot15
            //"7129300520","20141013T000000",221900,3,1,1180,5650,"1",0,0,3,7,1180,0,1955,0,"98178",47.5112,-122.257,1340,5650


            ModelInput sampleData = new ModelInput()
            {
                Bedrooms = data.Bedrooms,
                Bathrooms = data.Bedrooms,
                Sqft_living = data.SquareFeet,
                Floors = data.Floors,
                Yr_built = data.YearBuit,
                Zipcode = data.Zipcode,
            };

            ITransformer mlModel = mlContext.Model.Load(MODEL_FILEPATH, out var modelInputSchema);

            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            ModelOutput pResult = new ModelOutput();

            await Task.Run(() =>
            {
                 pResult = predEngine.Predict(sampleData);
            });

            Console.WriteLine($"Predicted price: {pResult.Score}");

            return pResult.Score;
        }
    }
}
