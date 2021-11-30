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
            
            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
