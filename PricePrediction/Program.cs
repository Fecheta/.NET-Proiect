using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.AutoML;
using Microsoft.ML.Data;

namespace PricePrediction
{
    public class Program
    {
        public static string TRAINING_DATA_FILEPATH = Path.Combine(Environment.CurrentDirectory, "kc_house_data.csv");
        public static string MODEL_FILEPATH = Path.Combine(Environment.CurrentDirectory, "MLModel.zip");
        public static void Main(string[] args)
        {
            MLContext mlContext = new MLContext(1);
            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                path: TRAINING_DATA_FILEPATH,
                hasHeader: true,
                separatorChar:',',
                allowQuoting:true,
                allowSparse: false);

            var dataProcessPipeline = mlContext.Transforms.Categorical.OneHotEncoding(new[]
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
            /* experiment to be removed later  
            var settings = new RegressionExperimentSettings()
            {
                MaxExperimentTimeInSeconds = 10
            };

            var experiment = mlContext.Auto().CreateRegressionExperiment(settings);

            var progress = new Progress<RunDetail<RegressionMetrics>>(p =>
            {
                if (p.ValidationMetrics != null)
                {
                    Console.Write($"Current result: {p.TrainerName}");
                    Console.Write($"      {p.ValidationMetrics.RSquared}");
                    Console.Write($"      {p.ValidationMetrics.MeanAbsoluteError}");
                    Console.WriteLine();
                }
            });

            var result = experiment.Execute(trainingDataView, labelColumnName: "price", progressHandler: progress);
            
            Console.WriteLine("Best run:");
            Console.WriteLine($"Trainer name - {result.BestRun.TrainerName}");
            Console.WriteLine($"RSquared - {result.BestRun.ValidationMetrics.RSquared}");
            Console.WriteLine($"MAE - {result.BestRun.ValidationMetrics.MeanAbsoluteError}");
            */
            
            /* used to build model from training data
            var trainer = mlContext.Regression.Trainers.LightGbm(labelColumnName: "price", featureColumnName: "Features");

            var trainingPipeline = dataProcessPipeline.Append(trainer);

            ITransformer model = trainingPipeline.Fit(trainingDataView);

            var crossValidationResults = mlContext.Regression.CrossValidate(trainingDataView, trainingPipeline,
                numberOfFolds: 5, labelColumnName: "price");
            
            mlContext.Model.Save(model,trainingDataView.Schema,MODEL_FILEPATH);
            */


            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
