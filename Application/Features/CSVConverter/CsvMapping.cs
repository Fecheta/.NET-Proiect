using Domain.Entities;
using TinyCsvParser.Mapping;

namespace Application.Features.CSVConverter
{
    internal class CsvMapping : CsvMapping<HouseFullSpecifications>
    {
        public CsvMapping() : base()
        {
            MapProperty(0, x => x.id);
            MapProperty(1, x => x.date);
            MapProperty(2, x => x.price);
            MapProperty(3, x => x.bedrooms);
            MapProperty(4, x => x.bathrooms);
            MapProperty(5, x => x.sqft_living);
            MapProperty(6, x => x.sqft_lot);
            MapProperty(7, x => x.floors);
            MapProperty(8, x => x.waterfront);
            MapProperty(9, x => x.view);
            MapProperty(10, x => x.condition);
            MapProperty(11, x => x.grade);
            MapProperty(12, x => x.sqft_above);
            MapProperty(13, x => x.sqft_basement);
            MapProperty(14, x => x.yr_built );
            MapProperty(15, x => x.yr_renovated);
            MapProperty(16, x => x.zipcode);
            MapProperty(17, x => x.lat);
            MapProperty(18, x => x.longt);
            MapProperty(19, x => x.sqft_living15);
            MapProperty(20, x => x.sqft_lot15);
        }
    }
}
