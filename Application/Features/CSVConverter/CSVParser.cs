using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using Domain.Entities;
using TinyCsvParser;

namespace Application.Features.CSVConverter
{
    public class CsvParser
    {
        private readonly string path;

        public CsvParser(string path)
        {
            this.path = path;
        }

        public List<HouseFullSpecifications> parse()
        {
            List<HouseFullSpecifications> result = new List<HouseFullSpecifications>();

            CsvParserOptions parserOptions = new CsvParserOptions(true, ',');
            CsvMapping csvMapping = new CsvMapping();
            CsvParser<HouseFullSpecifications> csvParser = new CsvParser<HouseFullSpecifications>(parserOptions, csvMapping);

            var res = csvParser
                .ReadFromFile(path, Encoding.ASCII)
                .ToList();

            foreach (var det in res)
            {
                result.Add(det.Result);
            }



            return result;
        }
    }
}
