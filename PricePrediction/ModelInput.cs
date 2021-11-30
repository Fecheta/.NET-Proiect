using Microsoft.ML.Data;

namespace PricePrediction
{
    public class ModelInput
    {
        [ColumnName("date"),LoadColumn(1)]
        public string Date { get; set; }
        [ColumnName("price"),LoadColumn(2)]
        public int Price { get; set; }
        [ColumnName("bedrooms"),LoadColumn(3)]
        public int Bedrooms { get; set; }
        [ColumnName("bathrooms"),LoadColumn(4)]
        public double Bathrooms { get; set; }
        [ColumnName("sqft_living"),LoadColumn(5)]
        public int Sqft_living { get; set; }
        [ColumnName("sqft_lot"),LoadColumn(6)]
        public int Sqft_lot { get; set; }
        [ColumnName("floors"),LoadColumn(7)]
        public string Floors { get; set; }
        [ColumnName("waterfront"),LoadColumn(8)]
        public int Waterfront { get; set; }
        [ColumnName("view"),LoadColumn(9)]
        public int View { get; set; }
        [ColumnName("condition"),LoadColumn(10)]
        public int Condition { get; set; }
        [ColumnName("grade"),LoadColumn(11)]
        public int Grade { get; set; }
        [ColumnName("sqft_above"),LoadColumn(12)]
        public int Sqft_above { get; set; }
        [ColumnName("sqft_basement"),LoadColumn(13)]
        public int Sqft_basement { get; set; }
        [ColumnName("yr_built"),LoadColumn(14)]
        public int Yr_built { get; set; }
        [ColumnName("yr_renovated"),LoadColumn(15)]
        public int Yr_renovated { get; set; }
        [ColumnName("zipcode"),LoadColumn(16)]
        public string Zipcode{ get; set; }
        [ColumnName("lat"),LoadColumn(17)]
        public double Lat { get; set; }
        [ColumnName("long"),LoadColumn(18)]
        public double Long { get; set; }
        [ColumnName("sqft_living15"),LoadColumn(19)]
        public int Sqft_living15 { get; set; }
        [ColumnName("sqft_lot15"),LoadColumn(20)]
        public int Sqft_lot15 { get; set; }
    }
}