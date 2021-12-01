using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bedrooms = table.Column<string>(type: "TEXT", nullable: true),
                    Bathrooms = table.Column<string>(type: "TEXT", nullable: true),
                    SquareFeet = table.Column<string>(type: "TEXT", nullable: true),
                    Floors = table.Column<string>(type: "TEXT", nullable: true),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    YearBuilt = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 1, "1", "3", "1", "221900", "1180", "1955", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 659, "3.5", "4", "2", "748000", "2770", "2001", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 660, "1.5", "3", "1", "888000", "1250", "1953", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 661, "1.75", "3", "1", "269900", "1140", "1986", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 662, "2.5", "4", "1", "496500", "2250", "1967", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 663, "2.5", "3", "2", "475000", "1640", "1969", "98155" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 664, "1.5", "3", "3", "312000", "1255", "2004", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 665, "1", "3", "1", "323000", "1290", "1976", "98072" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 666, "1.75", "3", "1", "331000", "1300", "1986", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 667, "1.5", "3", "3", "306000", "1220", "2007", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 668, "2.5", "4", "3", "655000", "2630", "2002", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 669, "1.5", "3", "1", "290000", "1950", "1959", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 670, "3.25", "4", "2", "1.25e+006", "3160", "1965", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 671, "1.75", "3", "1", "460000", "1550", "1949", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 672, "2.5", "4", "1", "435000", "1700", "1940", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 673, "2.75", "4", "1", "664000", "2510", "1978", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 674, "1.75", "4", "2", "865000", "1800", "1921", "98102" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 675, "1.75", "3", "1", "385000", "1800", "1968", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 676, "2.25", "3", "1", "497000", "1870", "1975", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 677, "1", "2", "1", "280000", "1010", "1925", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 678, "1.5", "2", "1", "188000", "1120", "1924", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 679, "1", "3", "1", "478500", "2090", "1969", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 680, "3.5", "4", "2", "1.145e+006", "4370", "2001", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 681, "2", "3", "1", "222000", "1440", "1981", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 682, "3", "4", "2", "799000", "2580", "1984", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 683, "2.5", "4", "2", "609900", "3190", "2006", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 684, "3.5", "4", "2", "413000", "2380", "1995", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 685, "1", "4", "1.5", "400000", "1420", "1930", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 658, "1", "3", "1", "495000", "990", "1943", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 686, "2.75", "5", "2", "802541", "2990", "2014", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 657, "2.5", "3", "1", "3.07e+006", "3930", "1957", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 655, "2.5", "3", "2", "337000", "1470", "1999", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 628, "1.75", "3", "1", "1.0425e+006", "1900", "1941", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 629, "2.25", "3", "1", "543500", "1270", "1970", "98199" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 630, "2.25", "4", "2", "480000", "3250", "1983", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 631, "1", "3", "1", "218000", "960", "1982", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 632, "1.75", "2", "1", "565000", "1330", "1914", "98199" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 633, "1.75", "3", "1", "426700", "2080", "1968", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 634, "2.5", "3", "1", "650000", "2690", "1957", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 635, "1", "2", "1", "542000", "890", "1910", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 636, "1.75", "3", "1", "415000", "1070", "1977", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 637, "1", "3", "1", "214000", "1200", "1953", "98002" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 638, "1.5", "3", "2", "245000", "1360", "1949", "98188" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 639, "2", "3", "1", "314500", "2050", "1993", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 640, "1.5", "3", "2", "1.12e+006", "3000", "1924", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 641, "2", "2", "1", "378000", "1300", "1963", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 642, "2.5", "4", "1", "305000", "2250", "1982", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 643, "2.75", "5", "1", "595000", "3740", "1978", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 644, "2.5", "3", "3", "729500", "1660", "2015", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 645, "2.5", "3", "2", "430000", "2360", "2003", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 646, "1.75", "3", "1", "240000", "1760", "1987", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 647, "1.75", "3", "1.5", "545000", "1680", "1916", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 648, "1.75", "3", "1", "530000", "1320", "1918", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 649, "1", "1", "1", "157000", "870", "1939", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 650, "1", "4", "1.5", "425000", "1260", "1925", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 651, "1", "3", "1", "220000", "1000", "1944", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 652, "1.75", "4", "1", "521000", "2020", "1976", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 653, "1", "3", "1", "325000", "1920", "1952", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 654, "2", "3", "1.5", "597500", "2150", "1911", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 656, "2.5", "3", "2", "1e+006", "3180", "1991", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 687, "2.5", "3", "2", "320000", "2680", "1990", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 688, "2.5", "4", "2", "507000", "2730", "2006", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 689, "1", "3", "1", "387500", "1220", "1946", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 722, "1", "2", "1", "565000", "960", "1911", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 723, "3.25", "4", "2", "1.578e+006", "4670", "1988", "98005" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 724, "2.5", "3", "2", "636000", "2140", "2007", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 725, "3", "5", "1", "350000", "2520", "2004", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 726, "1.5", "3", "1", "320000", "1650", "1978", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 727, "1.75", "2", "1", "210000", "1440", "1978", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 728, "1", "2", "1", "245000", "1050", "1950", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 729, "1.75", "3", "1", "328000", "1470", "1983", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 730, "2.25", "4", "2", "985000", "4230", "1989", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 731, "1.75", "3", "1", "501000", "1970", "1976", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 732, "2.25", "3", "2", "315000", "1540", "1992", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 733, "2.75", "3", "2", "403000", "2090", "2012", "98019" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 734, "2", "3", "2", "550000", "2380", "1934", "98155" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 735, "2.5", "4", "2", "347500", "2156", "2012", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 736, "2.25", "4", "2", "365000", "2070", "1986", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 737, "1", "3", "1", "588000", "1910", "1951", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 738, "1.75", "3", "1", "605000", "1920", "1977", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 739, "3.25", "3", "2", "1.3e+006", "3400", "1937", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 740, "2", "3", "1", "233000", "1400", "1974", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 741, "2.5", "4", "2", "360000", "2210", "1997", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 742, "1.75", "2", "1", "459000", "1170", "1929", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 743, "2", "3", "1", "740000", "2100", "1995", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 744, "1", "3", "1", "305000", "1160", "1967", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 745, "1", "3", "1", "395000", "1500", "1925", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 746, "2.5", "4", "2", "560000", "2940", "2000", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 747, "1.75", "4", "1", "650000", "2010", "1963", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 748, "2.5", "3", "2", "449950", "2170", "2003", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 721, "2.5", "3", "2", "289950", "1670", "2002", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 720, "2", "3", "1", "267000", "1300", "1994", "98010" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 719, "2.25", "6", "2", "730000", "2660", "1937", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 718, "2.25", "6", "2", "452000", "2660", "1937", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 690, "1", "3", "1", "396000", "1500", "1967", "98072" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 691, "1.75", "3", "1", "373000", "1830", "1958", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 692, "2.5", "5", "2", "1.4849e+006", "4570", "1965", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 693, "2.25", "4", "2", "359900", "2470", "1983", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 694, "1", "2", "1", "410000", "800", "1927", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 695, "2.5", "4", "2", "690000", "2900", "1992", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 696, "2", "3", "1", "245000", "1410", "1985", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 697, "2.5", "5", "1", "700000", "2830", "1979", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 698, "1.75", "4", "1", "268000", "1680", "1977", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 699, "1.75", "3", "1", "225000", "1760", "1979", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 700, "2.25", "4", "2", "980000", "2240", "1976", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 701, "1", "2", "1.5", "795000", "1380", "1905", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 702, "1", "2", "1", "195000", "820", "1953", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 627, "2.5", "3", "3", "559950", "1660", "2014", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 703, "2", "4", "1", "480000", "2180", "1950", "98005" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 705, "1", "2", "1", "130000", "880", "1928", "98188" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 706, "1", "2", "1", "325000", "1060", "1946", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 707, "1.75", "3", "1", "440000", "1530", "1984", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 708, "1.75", "4", "1", "550000", "2480", "1958", "98155" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 709, "1.75", "3", "1", "310000", "1490", "1967", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 710, "2.5", "3", "2", "530000", "3660", "1989", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 711, "2.5", "4", "2", "390000", "2340", "1993", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 712, "1.75", "3", "1", "243000", "1450", "1981", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 713, "2.5", "4", "2", "639000", "2210", "1990", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 714, "1", "4", "1", "215000", "1130", "1969", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 715, "1.75", "5", "1", "405000", "1550", "1961", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 716, "1.75", "4", "1", "250000", "1710", "1968", "98032" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 717, "1.5", "3", "1", "405500", "1010", "1954", "98155" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 704, "2", "4", "1", "485000", "1400", "1900", "98119" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 749, "1.5", "3", "1", "517500", "1430", "1940", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 626, "1", "3", "1", "289500", "960", "1944", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 624, "1.75", "2", "1", "605000", "1760", "1927", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 534, "1.5", "3", "1", "160000", "1010", "1962", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 535, "1", "3", "1", "204000", "1040", "1971", "98010" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 536, "2.25", "3", "2", "358000", "1610", "1985", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 537, "1.75", "4", "1", "452000", "1570", "1979", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 538, "2", "2", "1", "595000", "1510", "1900", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 539, "2", "3", "1", "249000", "1360", "1994", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 540, "2.5", "4", "2", "346900", "1970", "1999", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 541, "2.5", "3", "2", "2.125e+006", "5403", "1976", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 542, "2.5", "4", "2", "280000", "1560", "2003", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 543, "1.75", "4", "1", "318888", "2320", "1973", "98032" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 544, "2.25", "3", "1", "530000", "2120", "1967", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 545, "2.25", "3", "2", "375000", "2120", "1983", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 546, "2.5", "4", "2", "910000", "3350", "1988", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 547, "2.5", "4", "2", "782000", "2380", "1991", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 548, "2", "2", "2", "259950", "1070", "2008", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 549, "2.75", "4", "1", "315000", "2300", "1979", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 550, "1", "2", "1", "215000", "1320", "1943", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 551, "1.75", "3", "1", "705000", "2180", "1946", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 552, "3", "3", "2", "1.45e+006", "4380", "1952", "98199" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 553, "1.75", "3", "2", "451000", "1790", "1949", "98155" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 554, "1", "2", "1", "261000", "750", "1943", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 555, "1.5", "3", "1", "396000", "1300", "1956", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 556, "2.5", "4", "2", "725000", "2990", "1999", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 557, "3.5", "7", "2", "1.95e+006", "4640", "1965", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 558, "1", "4", "1.5", "238000", "1400", "1959", "98188" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 559, "1.75", "6", "2", "750000", "2750", "1973", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 560, "2.5", "4", "2", "331500", "2050", "1998", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 533, "3.25", "4", "2", "970000", "4740", "1987", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 561, "3", "4", "1", "460000", "2230", "1978", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 532, "1.5", "2", "2", "200000", "1360", "1978", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 530, "1.75", "3", "1", "662000", "2500", "1984", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 503, "2", "3", "1", "342000", "1930", "1966", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 504, "2.5", "4", "2", "1.19735e+006", "2770", "1999", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 505, "1.5", "3", "1", "280000", "1670", "1963", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 506, "1.75", "2", "1", "240000", "1330", "1993", "98188" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 507, "1", "3", "1.5", "529000", "1210", "1924", "98107" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 508, "1", "3", "1", "442000", "1190", "1941", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 509, "1", "2", "1", "615000", "1540", "1946", "98119" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 510, "3.75", "4", "2", "1.485e+006", "4030", "2006", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 511, "1.75", "4", "1", "585000", "2430", "1981", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 512, "2.5", "4", "2", "480000", "2600", "2005", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 513, "3.5", "5", "2", "1.095e+006", "4410", "1990", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 514, "1", "4", "1.5", "290000", "1330", "1949", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 515, "1.75", "3", "1", "615000", "1900", "1951", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 516, "1", "2", "1", "300000", "1100", "1950", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 517, "1", "3", "1.5", "308000", "1980", "1932", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 518, "2.5", "3", "2", "750000", "2400", "2001", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 519, "2.25", "4", "2.5", "2.25e+006", "4760", "1916", "98112" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 520, "3.25", "4", "2", "890000", "3180", "2005", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 521, "1", "3", "1", "288000", "1190", "1958", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 522, "1", "2", "1", "190000", "630", "1943", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 523, "3", "5", "1", "515000", "2530", "2005", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 524, "1.5", "4", "1", "235000", "1690", "1930", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 525, "1", "2", "1", "275000", "940", "1951", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 526, "2", "2", "1", "727500", "1240", "1952", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 527, "2.5", "4", "2", "650000", "3040", "2003", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 528, "5", "6", "2", "1.6e+006", "6050", "2001", "98024" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 529, "1", "4", "1.5", "365000", "1590", "1944", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 531, "2.5", "3", "1", "270500", "1780", "1978", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 562, "2.25", "4", "1", "404950", "2340", "1982", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 563, "2.5", "3", "2", "880000", "2870", "2014", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 564, "2.5", "4", "2", "863000", "4120", "1997", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 597, "2.5", "2", "2", "372500", "1400", "2007", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 598, "2.5", "3", "2", "595000", "3370", "2004", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 599, "3", "4", "2", "515000", "3590", "1997", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 600, "2.25", "4", "2", "1.22e+006", "3200", "1962", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 601, "1.75", "2", "1", "507000", "1670", "2004", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 602, "2", "4", "1", "399950", "2420", "1984", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 603, "1.75", "3", "2", "185000", "1430", "1994", "98010" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 604, "1.75", "3", "1", "460000", "1440", "1980", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 605, "2.25", "3", "2", "435500", "1450", "1985", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 606, "2.75", "4", "1", "469000", "3550", "1966", "98188" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 607, "3", "2", "2", "531000", "1270", "2000", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 608, "1", "2", "1", "443500", "940", "1949", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 609, "2", "3", "1", "223000", "1670", "1990", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 610, "3.5", "4", "2", "590000", "3100", "1996", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 611, "2.5", "2", "3", "340000", "1100", "1997", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 612, "2", "3", "1", "650000", "1870", "1925", "98199" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 613, "2.5", "3", "2", "533600", "1930", "1990", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 614, "2.75", "3", "2", "695000", "2540", "2005", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 615, "1.75", "3", "1.5", "242000", "1280", "1988", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 616, "2.25", "3", "1", "425000", "1820", "1967", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 617, "2.25", "3", "2", "525000", "1490", "1981", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 618, "2.5", "3", "2", "485000", "1880", "1988", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 619, "1", "3", "1", "175000", "1250", "1971", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 620, "2", "3", "1", "210000", "1440", "1983", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 621, "2.5", "3", "2", "260000", "1920", "1989", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 622, "2.5", "3", "1", "577000", "2060", "1976", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 623, "1.5", "3", "1", "200000", "1210", "1958", "98002" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 596, "1.75", "3", "1", "240500", "1460", "1997", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 595, "2.5", "4", "2", "360000", "1840", "1996", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 594, "2.5", "4", "2", "296000", "1780", "2006", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 593, "2.5", "3", "2", "290000", "1610", "2006", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 565, "1.75", "3", "1", "638700", "2080", "1960", "98005" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 566, "2.5", "3", "2", "435000", "1840", "2008", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 567, "1", "3", "1.5", "260000", "1180", "1959", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 568, "2.75", "5", "1.5", "671500", "2160", "1927", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 569, "1", "3", "1.5", "610000", "1180", "1907", "98109" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 570, "0.75", "2", "1", "405000", "1160", "1937", "98014" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 571, "2.5", "4", "2", "338900", "1830", "2003", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 572, "4", "4", "2", "720000", "3200", "2004", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 573, "3", "5", "1.5", "442000", "2560", "1927", "98108" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 574, "2.75", "5", "1.5", "650000", "2550", "1902", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 575, "1.75", "3", "1", "263500", "1330", "1981", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 576, "1", "2", "1", "300000", "1220", "1963", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 577, "2.5", "3", "2", "266000", "1805", "2009", "98002" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 625, "1", "3", "1", "325000", "990", "1947", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 578, "4", "4", "2.5", "930000", "6050", "2009", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 580, "1", "3", "1", "180000", "1384", "1965", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 581, "2.5", "3", "2", "619000", "2720", "2005", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 582, "1.5", "3", "1", "264000", "1820", "1962", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 583, "2.25", "2", "1.5", "730000", "2130", "1941", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 584, "2.25", "4", "2", "439000", "2060", "1975", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 585, "1.75", "4", "1", "268500", "1420", "1981", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 586, "1.75", "3", "1", "330000", "1510", "1985", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 587, "2.5", "3", "1.5", "640000", "2160", "1903", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 588, "2.5", "3", "2", "900000", "3180", "1978", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 589, "2.25", "3", "2", "370000", "2110", "1985", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 590, "2", "3", "1.5", "685000", "2060", "1931", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 591, "1.5", "3", "1", "505000", "1830", "1981", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 592, "1.75", "3", "1", "265000", "1820", "1966", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 579, "2.5", "4", "2", "530000", "2320", "2004", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 502, "1", "2", "1", "475000", "1490", "1929", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 750, "1.5", "4", "1", "435000", "1510", "1970", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 752, "1.75", "3", "1", "950000", "2150", "1960", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 909, "2.75", "5", "1", "550000", "2160", "1950", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 910, "1", "3", "1", "435000", "1400", "1917", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 911, "1.75", "3", "1", "234000", "1420", "1966", "98002" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 912, "2.25", "4", "1", "615000", "2500", "1975", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 913, "2", "3", "1", "205000", "1410", "1985", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 914, "1.75", "4", "1", "384000", "2100", "1955", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 915, "2.5", "3", "2", "324000", "1750", "1994", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 916, "1.75", "3", "1", "645000", "2070", "1946", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 917, "3.25", "3", "2", "570000", "1570", "2007", "98107" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 918, "2.5", "3", "2", "324000", "1920", "1999", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 919, "1", "2", "1", "270000", "1000", "1943", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 920, "1.5", "5", "1.5", "290000", "2120", "1962", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 921, "2", "3", "1", "250000", "1440", "1965", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 922, "1.75", "3", "2", "342000", "1660", "1990", "98014" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 923, "1.5", "3", "1", "255000", "1340", "1958", "98188" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 924, "2.25", "3", "1", "800000", "2380", "1972", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 925, "1.75", "3", "1.5", "451000", "1560", "1926", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 926, "2.5", "4", "1", "990000", "2780", "1967", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 927, "2.5", "4", "1", "288400", "1860", "1983", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 928, "1.5", "3", "2", "420000", "2390", "1920", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 929, "2.75", "2", "2", "359000", "1370", "2009", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 930, "3", "4", "1", "390000", "2570", "1988", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 931, "2.5", "3", "2", "300000", "1320", "2005", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 932, "2.5", "5", "1", "545000", "2520", "1981", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 933, "1", "3", "1", "288349", "1250", "1972", "98010" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 934, "2.25", "3", "1", "299900", "1560", "1985", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 935, "2", "4", "1.5", "891000", "2330", "1925", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 908, "1.75", "3", "1", "255000", "1410", "1960", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 936, "2", "3", "1", "1.2e+006", "3660", "1947", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 907, "2.25", "3", "2", "314950", "1654", "1995", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 905, "2", "3", "1", "300000", "1480", "1979", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 878, "2", "3", "1", "390000", "1910", "1978", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 879, "1", "3", "1", "229000", "1020", "1954", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 880, "1", "3", "1", "185000", "1150", "1932", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 881, "1.5", "3", "1", "414900", "1260", "1941", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 882, "2", "4", "1", "200000", "1920", "1914", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 883, "2.25", "4", "1", "225000", "1800", "1969", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 884, "1.75", "3", "2", "720000", "2040", "1924", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 885, "2.5", "4", "2", "930000", "2200", "1908", "98119" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 886, "2.5", "5", "1", "1.27e+006", "3200", "1952", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 887, "3.25", "5", "2", "700000", "2400", "1928", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 888, "1.5", "2", "3", "466000", "1140", "2005", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 889, "1.5", "3", "1", "374000", "1330", "1976", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 890, "2.5", "3", "2", "480000", "1940", "1994", "98072" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 891, "2.5", "3", "2", "740000", "3000", "1995", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 892, "1", "4", "1.5", "1.01e+006", "1820", "1923", "98102" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 893, "2.5", "4", "2", "395000", "2910", "2002", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 894, "1", "2", "1", "340000", "1090", "1954", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 895, "2", "3", "2", "209000", "1230", "2003", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 896, "2.5", "5", "1.5", "431650", "1710", "1962", "98007" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 897, "2.5", "5", "1", "980000", "3160", "1971", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 898, "2.5", "3", "2", "660000", "2680", "1993", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 899, "2.25", "4", "2", "730000", "2190", "1977", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 900, "1.75", "3", "1", "291500", "1260", "1988", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 901, "3.5", "4", "2", "905000", "2970", "1997", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 902, "2.5", "4", "1.5", "800000", "2570", "1993", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 903, "3.5", "4", "1", "839900", "3810", "2013", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 904, "1.5", "1", "2", "200000", "1010", "2007", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 906, "1.75", "3", "1.5", "530000", "1250", "1942", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 937, "2.5", "4", "2", "378000", "2790", "2004", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 938, "1", "2", "1", "299995", "1060", "1951", "98155" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 939, "2.5", "3", "1", "253000", "2020", "1994", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 972, "1", "3", "1", "265000", "1070", "1950", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 973, "1.25", "3", "1", "397500", "1510", "1961", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 974, "2.5", "3", "2", "524250", "1710", "1999", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 975, "2.75", "4", "2", "765000", "2790", "1996", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 976, "2.5", "4", "2", "648000", "2620", "2001", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 977, "2.5", "5", "1", "469500", "2970", "1969", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 978, "1.75", "3", "1", "237500", "1050", "1975", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 979, "1", "3", "1", "216000", "1280", "1956", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 980, "1", "3", "1", "427200", "1030", "1963", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 981, "2.25", "3", "1", "280000", "1900", "1977", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 982, "3", "5", "1", "718000", "3070", "1968", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 983, "2.75", "2", "2", "420000", "1760", "2010", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 984, "1", "2", "1", "379000", "930", "1952", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 985, "1", "2", "1", "326100", "880", "1942", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 986, "2.5", "3", "3", "535000", "1360", "2003", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 987, "2.75", "4", "1", "283000", "2130", "1992", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 988, "1", "3", "1.5", "260000", "1480", "1940", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 989, "1", "4", "1.5", "399000", "1500", "1951", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 990, "2.25", "3", "2", "484950", "1670", "1987", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 991, "1.75", "4", "1", "640000", "2060", "1960", "98005" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 992, "2.5", "4", "1", "585000", "2160", "1952", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 993, "2", "4", "1", "645000", "2780", "1955", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 994, "2", "3", "1", "253000", "1490", "1988", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 995, "1", "2", "1", "178500", "740", "1953", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 996, "2.5", "4", "2", "291000", "1860", "1991", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 997, "2.75", "2", "1.5", "199950", "1590", "1920", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 998, "1", "2", "1", "553500", "850", "1922", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 971, "1.75", "3", "2", "532500", "1330", "1909", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 970, "2.25", "4", "2", "752500", "2360", "1974", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 969, "1.75", "3", "1", "440000", "1560", "1983", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 968, "2.75", "4", "1", "582800", "2550", "1986", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 940, "2.25", "3", "1", "350000", "1580", "1979", "98024" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 941, "3", "4", "1.5", "565000", "2020", "1900", "98107" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 942, "1", "2", "1", "315000", "970", "1908", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 943, "3", "4", "1.5", "570000", "1490", "1915", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 944, "3.5", "5", "2", "971000", "4390", "2005", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 945, "2.5", "5", "1.5", "915000", "2750", "1910", "98112" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 946, "1.5", "4", "1", "419000", "2150", "1950", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 947, "1.75", "4", "1", "260000", "1810", "1977", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 948, "3", "3", "2", "1.3215e+006", "2230", "1990", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 949, "1", "3", "1", "369950", "2430", "1977", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 950, "2.5", "3", "2", "1.0299e+006", "3680", "1994", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 951, "1", "5", "1.5", "435000", "1410", "1929", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 952, "1.75", "3", "1", "601000", "1330", "1958", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 877, "1", "3", "1", "147500", "1530", "1959", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 953, "1", "3", "1", "460500", "1490", "1963", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 955, "2.5", "4", "2", "851000", "3130", "1996", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 956, "3", "4", "2", "550000", "2670", "1916", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 957, "1", "4", "1.5", "700000", "1980", "1920", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 958, "1.75", "3", "1", "323000", "2100", "1963", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 959, "1", "3", "1", "345500", "1350", "1944", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 960, "1.5", "4", "1", "378000", "2140", "1959", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 961, "2", "4", "3", "650000", "2208", "1917", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 962, "2", "3", "1", "385000", "1010", "1982", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 963, "1", "2", "1", "425000", "970", "1910", "98102" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 964, "2", "4", "1.5", "210000", "1520", "1920", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 965, "2.5", "4", "2", "630000", "2740", "1993", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 966, "1.75", "3", "1", "335000", "1570", "1953", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 967, "1", "3", "1", "196500", "1320", "1966", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 954, "2.5", "3", "3", "720000", "2020", "2000", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 751, "1", "3", "1", "329999", "1150", "1952", "98155" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 876, "0", "0", "3.5", "1.095e+006", "3064", "1990", "98102" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 874, "2.5", "4", "2", "785000", "3300", "1984", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 784, "1", "4", "2", "715000", "2000", "1911", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 785, "2.75", "6", "1.5", "650000", "3610", "1966", "98008" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 786, "1.75", "5", "1", "218000", "1930", "1966", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 787, "1", "2", "1", "500000", "1280", "1964", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 788, "2", "4", "1", "460000", "2090", "1984", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 789, "1.5", "3", "1", "232500", "1940", "1969", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 790, "2.5", "3", "2", "408200", "1800", "1990", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 791, "1.75", "3", "1", "522000", "1730", "1980", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 792, "2.5", "4", "2", "675000", "2810", "1982", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 793, "3.5", "4", "1", "1.355e+006", "3550", "1999", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 794, "1", "4", "1.5", "249950", "1330", "1952", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 795, "1", "2", "1", "210000", "750", "1950", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 796, "1", "4", "1", "429950", "1760", "1947", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 797, "2.5", "4", "2", "737500", "3200", "1993", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 798, "2", "4", "1", "710000", "1740", "1958", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 799, "2.5", "3", "2", "470000", "2100", "1999", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 800, "3.5", "4", "1", "1.1e+006", "4270", "1993", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 801, "2", "3", "1.5", "650000", "1340", "1913", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 802, "2.5", "4", "1", "1.216e+006", "3190", "1967", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 803, "2.5", "3", "2", "422120", "1630", "1987", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 804, "2.5", "5", "2", "625000", "2990", "2007", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 805, "1", "4", "1.5", "385200", "1550", "1954", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 806, "2.25", "3", "2", "500000", "1690", "1989", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 807, "2.25", "4", "2", "308000", "1960", "1989", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 808, "2.75", "3", "1", "565000", "2390", "1977", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 809, "2.5", "3", "2", "581000", "2600", "2004", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 810, "2", "3", "1", "361000", "1950", "1999", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 783, "1.5", "3", "2", "320000", "1240", "2009", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 811, "1", "3", "1", "345000", "1250", "1964", "98008" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 782, "1.75", "3", "1.5", "400000", "1590", "1938", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 780, "4.25", "5", "1.5", "2.25e+006", "4860", "1905", "98112" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 753, "1", "3", "1", "447000", "1370", "1944", "98108" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 754, "2.5", "2", "1", "699800", "2380", "2010", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 755, "1.75", "3", "1", "850000", "1370", "1911", "98112" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 756, "1.75", "3", "1", "316500", "1600", "1979", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 757, "3.5", "5", "1", "942500", "3750", "1981", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 758, "2.25", "2", "2", "1.31e+006", "3950", "1991", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 759, "2.25", "4", "1", "856600", "2400", "1964", "98005" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 760, "1.5", "5", "2.5", "405600", "2830", "1918", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 761, "2.5", "4", "2", "565000", "2440", "1996", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 762, "2.25", "3", "2", "400000", "1190", "2008", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 763, "2", "3", "1", "330000", "1400", "1997", "98019" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 764, "2.75", "4", "2", "374950", "2730", "2005", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 765, "2.75", "3", "1", "405300", "2390", "1983", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 766, "2.25", "3", "2", "560000", "2060", "1984", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 767, "2.25", "4", "1", "824000", "2490", "1961", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 768, "1.75", "3", "1", "260000", "1100", "1984", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 769, "2.5", "4", "1", "760000", "2430", "1965", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 770, "2.5", "3", "2", "405000", "3170", "1995", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 771, "2.5", "4", "2", "429900", "2640", "1987", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 772, "1.5", "3", "1", "341500", "1130", "1961", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 773, "2", "5", "1.5", "465250", "1940", "1957", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 774, "2", "2", "1.5", "450000", "1100", "1912", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 775, "1", "3", "1", "390000", "1200", "1955", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 776, "2.25", "3", "1", "420000", "2000", "1963", "98008" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 777, "2.5", "3", "2", "269950", "1890", "2002", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 778, "2", "4", "1", "493000", "1910", "1910", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 779, "2.5", "4", "2", "370000", "2710", "1998", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 781, "1", "3", "1", "305000", "1250", "1967", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 812, "2.25", "2", "2", "419000", "1180", "2008", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 813, "2.5", "3", "2", "347000", "1680", "2004", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 814, "2.25", "4", "2", "625000", "2220", "1989", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 847, "2", "4", "1.5", "664000", "1530", "1912", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 848, "1.75", "3", "1", "628000", "4000", "1987", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 849, "1.75", "3", "1", "512000", "1610", "1977", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 850, "2", "3", "1", "254000", "2070", "1969", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 851, "2.5", "4", "2", "535800", "1900", "1994", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 852, "1", "3", "1", "287653", "1050", "1960", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 853, "2.5", "3", "2", "438000", "1520", "2006", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 854, "1.75", "4", "1", "450000", "2390", "1949", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 855, "2.75", "5", "2", "327000", "2400", "1998", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 856, "2.5", "4", "2", "370500", "1790", "2005", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 857, "2.5", "3", "2", "265000", "1720", "1993", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 858, "2.75", "4", "1", "450000", "2980", "1979", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 859, "1", "3", "1.5", "425000", "1520", "1988", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 860, "1.75", "3", "1", "166600", "1150", "1977", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 861, "0.75", "1", "1", "245000", "380", "1963", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 862, "1", "3", "1", "565000", "910", "1951", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 863, "1.75", "3", "1", "539900", "1650", "1976", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 864, "3.5", "3", "2", "910000", "2480", "2010", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 865, "2.5", "4", "2", "280000", "2050", "1990", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 866, "2.25", "3", "2", "275000", "1420", "1989", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 867, "2.5", "3", "2", "467000", "3460", "2001", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 868, "2.5", "3", "2", "457500", "1500", "1996", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 869, "1", "2", "1", "381156", "1320", "1908", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 870, "2.5", "5", "1", "289999", "2180", "1977", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 871, "1.75", "3", "1", "642450", "1830", "1919", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 872, "2.25", "3", "1", "469950", "1620", "1962", "98007" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 873, "2", "3", "1", "795000", "2920", "1975", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 846, "2.25", "3", "1", "352000", "1640", "1972", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 845, "3.5", "4", "3", "456500", "2000", "2008", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 844, "2.25", "3", "2", "330000", "2300", "1977", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 843, "1", "3", "1.5", "428750", "1620", "1911", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 815, "4.25", "4", "2", "2.4e+006", "4890", "1999", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 816, "3.25", "3", "2.5", "379000", "2660", "2014", "98010" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 817, "1.5", "3", "2", "310000", "1150", "1988", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 818, "2", "2", "1", "250000", "1130", "1941", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 819, "2.75", "5", "2", "682000", "2760", "2005", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 820, "2", "3", "1", "246500", "1430", "1992", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 821, "1", "3", "1.5", "325000", "1490", "1932", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 822, "2.5", "4", "2", "310950", "2030", "2004", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 823, "2", "3", "2", "1.1e+006", "3010", "1931", "98199" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 824, "1", "3", "1", "287500", "1810", "1954", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 825, "1", "3", "1", "431000", "1810", "1954", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 826, "1", "3", "1", "226000", "970", "1968", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 827, "1.75", "3", "1.5", "825000", "2010", "1926", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 875, "2.25", "3", "2", "860000", "3060", "1983", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 828, "1", "4", "1.5", "175000", "1300", "1947", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 830, "2.25", "4", "2", "659000", "2610", "1983", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 831, "1.75", "3", "1", "595000", "1910", "1941", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 832, "2.25", "3", "2", "350000", "1780", "1987", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 833, "2.25", "4", "1", "270000", "1900", "1975", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 834, "2.25", "6", "1", "662500", "2450", "1957", "98008" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 835, "1.75", "3", "1", "249900", "1380", "1939", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 836, "1.75", "3", "1", "324500", "1920", "1977", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 837, "1.75", "2", "1", "430000", "1350", "2004", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 838, "1.75", "2", "1", "419950", "1350", "2004", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 839, "1.75", "4", "1", "285000", "2510", "1962", "98032" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 840, "2.5", "4", "2", "332000", "2470", "2002", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 841, "1.75", "4", "1", "282000", "1660", "1956", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 842, "1", "3", "1", "320000", "1340", "1987", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 829, "1.5", "3", "1", "465750", "1260", "1959", "98008" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 501, "2.5", "4", "2", "650000", "3180", "2003", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 500, "2.5", "3", "2", "437500", "2120", "2000", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 499, "1.5", "2", "1.5", "625000", "1490", "1900", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 158, "2.75", "4", "1", "320000", "2640", "1967", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 159, "2", "3", "1.5", "247000", "1270", "1916", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 160, "1.75", "4", "1", "320000", "1760", "1968", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 161, "2.25", "5", "1", "255000", "2060", "1962", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 162, "1.75", "3", "1", "438000", "1780", "1962", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 163, "2.5", "3", "2", "900000", "3400", "2000", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 164, "2.75", "3", "1", "441000", "1910", "1979", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 165, "2", "3", "1", "420000", "2020", "1975", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 166, "1.75", "3", "1", "370000", "1580", "1976", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 167, "1.75", "2", "1", "269950", "1340", "1949", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 168, "2.5", "4", "2", "807100", "2680", "1999", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 169, "2.5", "3", "1", "653000", "2680", "1979", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 170, "2", "3", "1", "371500", "1370", "1964", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 171, "1.75", "3", "1", "284000", "1560", "1954", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 172, "1.75", "3", "1", "272000", "2160", "1978", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 173, "1.5", "3", "1.5", "313000", "1340", "1955", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 174, "2.5", "4", "2", "917500", "3880", "1984", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 175, "2.25", "4", "2", "673000", "2590", "1980", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 176, "2.5", "3", "2", "425000", "1120", "2008", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 177, "2.75", "5", "1", "399950", "1970", "1986", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 178, "1", "3", "1", "385000", "1220", "1901", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 179, "1.5", "3", "1", "269950", "1950", "1975", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 180, "1", "2", "1", "330000", "1350", "1949", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 181, "2.5", "3", "2", "260000", "1670", "1988", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 182, "3", "4", "1.5", "470000", "2380", "1925", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 183, "3", "4", "2", "589000", "2440", "1961", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 184, "1.5", "2", "2", "163500", "1050", "1996", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 157, "3.5", "5", "2", "650000", "3960", "1996", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 185, "2.75", "4", "2", "835000", "3130", "1993", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 156, "1", "3", "1", "215000", "1180", "1967", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 154, "3.25", "4", "2", "2.25e+006", "5180", "2006", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 127, "2.25", "3", "1", "445000", "2100", "1967", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 128, "2.25", "4", "1", "260000", "2160", "1978", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 129, "3.5", "5", "2", "822500", "2320", "1926", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 130, "2.5", "4", "2", "430000", "2070", "2004", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 131, "1.75", "3", "1", "212000", "1060", "1986", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 132, "2.25", "4", "1", "660500", "2010", "1986", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 133, "3.5", "3", "1.5", "784000", "3950", "1989", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 134, "2.5", "3", "2", "453246", "2010", "2014", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 135, "3.5", "4", "3", "675000", "2140", "2005", "98107" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 136, "1.75", "3", "1", "199000", "1320", "1956", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 137, "1.75", "4", "1", "220000", "2020", "1968", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 138, "2.25", "4", "1", "452000", "2590", "1968", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 139, "1", "2", "1", "382500", "1190", "1981", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 140, "2.25", "3", "3", "519950", "1170", "2014", "98107" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 141, "1", "2", "1", "665000", "1110", "1925", "98119" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 142, "2.5", "5", "1", "527700", "2820", "1968", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 143, "1", "3", "1", "205000", "1610", "1962", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 144, "1", "3", "1", "420000", "1060", "1923", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 145, "2.25", "4", "1", "500000", "2030", "1961", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 146, "2.5", "4", "2", "921500", "3670", "1994", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 147, "1", "4", "2", "890000", "2550", "1905", "98109" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 148, "2.5", "2", "2", "430000", "2420", "2007", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 149, "2", "5", "1", "258000", "2260", "1960", "98032" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 150, "1", "3", "1", "511000", "1430", "1947", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 151, "2", "3", "2", "532170", "1360", "1990", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 152, "1", "3", "1.5", "560000", "1110", "1947", "98107" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 153, "1", "3", "1", "282950", "1250", "1954", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 155, "1", "1", "1", "350000", "700", "1942", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 186, "3", "5", "1", "1.095e+006", "4090", "1986", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 187, "1.75", "4", "1", "269000", "1490", "1969", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 188, "2.5", "3", "2", "560000", "1900", "1987", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 221, "2.5", "4", "2", "686000", "2760", "1999", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 222, "2", "3", "1", "279950", "1750", "1961", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 223, "2.25", "4", "2", "527000", "2330", "1987", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 224, "2.25", "3", "1", "325000", "2220", "1966", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 225, "2.25", "3", "2", "328000", "2020", "1994", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 226, "2.25", "3", "1", "390000", "1250", "1942", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 227, "2", "2", "1", "479950", "1510", "2005", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 228, "2.25", "4", "1", "264950", "1720", "1978", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 229, "1", "3", "1", "235000", "1430", "1961", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 230, "2.5", "3", "2", "516500", "1480", "2004", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 231, "1.75", "2", "2", "655000", "1450", "1915", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 232, "2.75", "4", "1", "500000", "2280", "1960", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 233, "2.75", "6", "1", "315000", "2940", "1978", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 234, "1", "2", "1", "213000", "1000", "1961", "98024" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 235, "1.5", "3", "1.5", "475000", "2480", "1947", "98108" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 236, "4", "5", "2", "1.025e+006", "3760", "1983", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 237, "2", "3", "1", "416000", "2220", "1976", "98010" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 238, "1", "4", "1.5", "410000", "1970", "1904", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 239, "3.5", "3", "2", "800000", "3830", "1993", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 240, "2.5", "6", "1", "472000", "4410", "1965", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 241, "1.75", "3", "1", "225000", "1430", "1968", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 242, "1", "2", "1", "210000", "830", "1940", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 243, "1", "2", "1.5", "455000", "1430", "1925", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 244, "1", "3", "1", "225000", "1300", "1954", "98002" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 245, "1", "2", "1", "480000", "1030", "1918", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 246, "2.5", "3", "2", "363000", "2740", "1990", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 247, "2.5", "4", "1", "2.4e+006", "3650", "2000", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 220, "1.5", "2", "1", "467000", "1320", "1947", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 219, "2.25", "2", "1", "1.072e+006", "3900", "1947", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 218, "2.5", "3", "2", "445838", "2250", "2000", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 217, "3", "5", "1", "1.505e+006", "3300", "1957", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 189, "1", "4", "1.5", "615000", "1330", "1901", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 190, "2.25", "3", "1", "585188", "2230", "1975", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 191, "1.75", "3", "1", "305000", "1650", "1977", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 192, "1", "3", "1", "166950", "1190", "1959", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 193, "2.5", "3", "1", "799000", "2140", "1959", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 194, "2.5", "3", "1", "400000", "2180", "1962", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 195, "1", "3", "1", "230000", "1060", "1948", "98155" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 196, "2.5", "3", "2", "256883", "1690", "2003", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 197, "2", "4", "1.5", "423000", "1970", "1920", "98108" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 198, "2.5", "3", "2", "465000", "2150", "2007", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 199, "2.5", "3", "2", "440000", "1910", "1997", "98024" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 200, "1.75", "3", "1", "385000", "1350", "1969", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 201, "1", "3", "1", "210000", "860", "1943", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 126, "2.75", "4", "1.5", "1.45e+006", "2750", "1914", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 202, "2.5", "3", "2", "297000", "1940", "1994", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 204, "1.5", "3", "1", "226500", "1300", "1976", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 205, "1", "3", "1", "274250", "910", "1962", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 206, "1.75", "4", "1", "840000", "2480", "1966", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 207, "2.5", "3", "2", "677900", "2440", "2010", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 208, "1", "3", "1", "425000", "1010", "1915", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 209, "0.75", "2", "1", "180250", "900", "1941", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 210, "3", "6", "2", "464000", "2300", "1920", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 211, "2.25", "4", "2", "320000", "1550", "1993", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 212, "2.25", "3", "2", "625504", "1270", "2014", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 213, "2.5", "4", "1", "592500", "2240", "1983", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 214, "2.5", "3", "2", "465000", "2714", "2005", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 215, "2.75", "4", "2", "477000", "1720", "1978", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 216, "1", "2", "1", "280000", "850", "1923", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 203, "1", "3", "1", "470000", "1010", "1952", "98107" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 248, "1.5", "2", "1", "181000", "720", "1954", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 125, "2.25", "3", "2", "770000", "2910", "1990", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 123, "1", "2", "1", "395000", "770", "1953", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 33, "1.75", "4", "1.5", "687500", "2330", "1929", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 34, "1", "3", "1.5", "535000", "1090", "1929", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 35, "2.75", "4", "1", "322500", "2060", "1981", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 36, "2.5", "3", "1.5", "696000", "2300", "1930", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 37, "1", "4", "1", "550000", "1660", "1933", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 38, "2", "4", "2", "640000", "2360", "1904", "98107" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 39, "1", "4", "1", "240000", "1220", "1969", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 40, "2.5", "4", "2", "605000", "2620", "1996", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 41, "2.5", "4", "2", "625000", "2570", "2000", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 42, "2.25", "4", "1", "775000", "4220", "1984", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 43, "2.75", "5", "2", "861990", "3595", "2014", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 44, "1", "3", "2", "685000", "1570", "1922", "98119" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 45, "1", "3", "1", "309000", "1280", "1959", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 46, "2.5", "3", "2", "488000", "3160", "2003", "98019" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 47, "1", "3", "1", "210490", "990", "1966", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 48, "2.5", "4", "2", "785000", "2290", "1981", "98007" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 49, "1.75", "3", "1", "450000", "1250", "1953", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 50, "2.5", "3", "1", "1.35e+006", "2753", "1953", "98070" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 51, "1", "3", "1", "228000", "1190", "1955", "98148" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 52, "2.5", "5", "1", "345000", "3150", "1966", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 53, "1.75", "3", "1", "600000", "1410", "1950", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 54, "1.75", "2", "1", "585000", "1980", "1981", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 55, "2.25", "5", "1.5", "920000", "2730", "1927", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 56, "2.5", "4", "2", "885000", "2830", "1995", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 57, "2.5", "4", "2", "292500", "2250", "2008", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 58, "2.5", "3", "2", "301000", "2420", "2003", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 59, "3.25", "5", "2", "951000", "3250", "1968", "98008" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 32, "1.5", "2", "3", "280000", "1190", "2005", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 60, "3", "4", "2", "430000", "1850", "1991", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 31, "2.5", "3", "2", "580500", "2320", "2003", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 29, "1.75", "3", "1", "438000", "1520", "1948", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 2, "2.25", "3", "2", "538000", "2570", "1951", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 3, "1", "2", "1", "180000", "770", "1933", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 4, "3", "4", "1", "604000", "1960", "1965", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 5, "2", "3", "1", "510000", "1680", "1987", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 6, "4.5", "4", "1", "1.225e+006", "5420", "2001", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 7, "2.25", "3", "2", "257500", "1715", "1995", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 8, "1.5", "3", "1", "291850", "1060", "1963", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 9, "1", "3", "1", "229500", "1780", "1960", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 10, "2.5", "3", "2", "323000", "1890", "2003", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 11, "2.5", "3", "1", "662500", "3560", "1965", "98007" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 12, "1", "2", "1", "468000", "1160", "1942", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 13, "1", "3", "1.5", "310000", "1430", "1927", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 14, "1.75", "3", "1", "400000", "1370", "1977", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 15, "2", "5", "1.5", "530000", "1810", "1900", "98107" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 16, "3", "4", "2", "650000", "2950", "1979", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 17, "2", "3", "2", "395000", "1890", "1994", "98019" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 18, "1", "4", "1.5", "485000", "1600", "1916", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 19, "1", "2", "1", "189000", "1200", "1921", "98002" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 20, "1", "3", "1", "230000", "1250", "1969", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 21, "1.75", "4", "1", "385000", "1620", "1947", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 22, "2.75", "3", "1", "2e+006", "3050", "1968", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 23, "2.5", "5", "2", "285000", "2270", "1995", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 24, "1.5", "2", "1", "252700", "1070", "1985", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 25, "2.25", "3", "2", "329000", "2450", "1985", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 26, "2", "3", "1.5", "233000", "1710", "1941", "98002" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 27, "1.75", "3", "2", "937000", "2450", "1915", "98119" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 28, "1", "3", "1.5", "667000", "1400", "1909", "98112" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 30, "2.5", "4", "2", "719000", "2570", "2005", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 61, "2.25", "3", "1", "650000", "2150", "1959", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 62, "1.75", "3", "1", "289000", "1260", "1954", "98148" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 63, "1.75", "3", "2", "505000", "2519", "1973", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 96, "2.5", "4", "1", "905000", "3300", "1946", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 97, "1.75", "3", "1", "247500", "1960", "1967", "98032" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 98, "1.5", "4", "1", "199000", "1160", "1975", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 99, "1.75", "3", "1", "314000", "1810", "1980", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 100, "2.5", "3", "2", "437500", "2320", "1992", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 101, "2.5", "3", "1.5", "850830", "2070", "1910", "98102" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 102, "2", "3", "1.5", "555000", "1980", "1929", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 103, "2.25", "3", "2", "699950", "2190", "1983", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 104, "2.5", "3", "2", "1.088e+006", "2920", "1950", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 105, "1", "3", "1", "290000", "1210", "1954", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 106, "2.5", "3", "1", "375000", "2340", "1978", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 107, "1", "3", "1.5", "460000", "1670", "1939", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 108, "1.75", "2", "1", "188500", "1240", "1985", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 109, "2.5", "4", "2", "680000", "3140", "1991", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 110, "1.75", "5", "2", "470000", "2030", "1942", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 111, "2.5", "4", "2", "597750", "2310", "1984", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 112, "1.75", "3", "1", "570000", "1260", "1905", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 113, "1.75", "3", "1", "272500", "1540", "1980", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 114, "1.75", "3", "1", "329950", "2080", "1971", "98108" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 115, "2.5", "4", "2", "480000", "3230", "2001", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 116, "3.5", "3", "2", "740500", "4380", "1900", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 117, "3.5", "3", "3", "518500", "1590", "2010", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 118, "1", "2", "1", "205425", "880", "1945", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 119, "2", "4", "1", "171800", "1570", "1950", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 120, "1", "4", "1.5", "535000", "1610", "1925", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 121, "2.5", "3", "1", "660000", "2400", "1964", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 122, "2", "3", "1", "391500", "1450", "1987", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 95, "1.5", "3", "1", "700000", "1580", "1939", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 94, "1.5", "3", "1", "430000", "1580", "1939", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 93, "1", "3", "1", "153000", "1200", "1962", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 92, "2.75", "5", "2", "1.09988e+006", "3520", "2001", "98199" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 64, "1.75", "3", "3", "549000", "1540", "2014", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 65, "2.25", "3", "1", "425000", "1660", "1979", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 66, "2.75", "3", "1.5", "317625", "2770", "1925", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 67, "2.5", "4", "2", "975000", "2720", "1989", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 68, "2.5", "4", "2", "287000", "2240", "2005", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 69, "1", "3", "1", "204000", "1000", "1968", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 70, "2.25", "5", "1", "1.325e+006", "3200", "1965", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 71, "3.25", "5", "1", "1.04e+006", "4770", "1973", "98005" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 72, "2", "3", "1", "325000", "1260", "1972", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 73, "2", "4", "1.5", "571000", "2750", "1916", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 74, "2.5", "4", "2", "360000", "2380", "2005", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 75, "1.75", "3", "1", "349000", "1790", "1965", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 76, "4", "4", "2", "832500", "3430", "1986", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 124, "1.75", "4", "1.5", "445000", "2100", "1924", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 77, "1.75", "4", "1", "380000", "1760", "1956", "98008" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 79, "1", "3", "1", "410000", "1410", "1956", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 80, "2.5", "4", "2", "720000", "3450", "2002", "98010" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 81, "2.5", "3", "2", "390000", "2350", "2003", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 82, "2.5", "4", "2", "360000", "1900", "1992", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 83, "1", "2", "1", "355000", "2020", "1948", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 84, "1.5", "3", "1", "356000", "1680", "1964", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 85, "1", "3", "1", "315000", "960", "1952", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 86, "1.5", "3", "2", "940000", "2140", "1925", "98119" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 87, "2.25", "5", "1.5", "305000", "2660", "1961", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 88, "3.25", "3", "2", "461000", "2770", "2006", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 89, "2.25", "2", "2", "215000", "1610", "1979", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 90, "1.75", "2", "2", "335000", "1030", "2006", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 91, "2.5", "4", "2", "243500", "1980", "1988", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 78, "1", "3", "1", "480000", "1040", "1941", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 249, "2", "4", "1", "250000", "2010", "1976", "98002" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 250, "1.75", "3", "1", "481000", "1560", "1918", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 251, "2", "3", "1", "260000", "1810", "1978", "98032" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 409, "2.5", "4", "2", "364950", "1930", "1995", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 410, "3.5", "4", "1", "840000", "2840", "1986", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 411, "2.5", "3", "2", "268000", "1550", "1991", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 412, "1", "2", "1", "517534", "833", "2006", "98070" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 413, "2.5", "3", "2", "632925", "2990", "1978", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 414, "2.5", "3", "2", "577500", "2000", "1995", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 415, "1.5", "4", "1.5", "339000", "2390", "1920", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 416, "1.75", "3", "1", "570000", "2910", "1967", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 417, "1.75", "4", "1", "563500", "2085", "1964", "98024" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 418, "2.25", "4", "1", "423000", "2200", "1962", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 419, "2.25", "3", "2", "355000", "1860", "2012", "98019" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 420, "4.25", "5", "2", "1.55e+006", "6070", "1999", "98024" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 421, "1", "2", "1", "482000", "950", "1941", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 422, "1.75", "3", "1", "625000", "1600", "1955", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 423, "2.5", "3", "2", "538000", "2250", "1988", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 424, "2.5", "3", "2", "380000", "2280", "1985", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 425, "1", "2", "1", "375000", "940", "1909", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 426, "2.5", "3", "1", "245000", "1530", "1996", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 427, "1.75", "5", "1", "310000", "2190", "1947", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 428, "2", "3", "1", "1.3e+006", "2350", "1976", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 429, "2", "4", "1", "397000", "1440", "1971", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 430, "2.5", "3", "2", "365000", "2200", "2005", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 431, "3", "4", "2", "328500", "2290", "1990", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 432, "3", "4", "2", "988000", "4040", "1987", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 433, "2.5", "4", "1.5", "1e+006", "2610", "1922", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 434, "2.5", "3", "2", "237000", "1490", "2005", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 435, "2.5", "4", "2", "525000", "2450", "2003", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 408, "2", "3", "1", "278500", "1570", "1998", "98092" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 436, "2.5", "4", "1", "749000", "1710", "1976", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 407, "2", "3", "3", "450000", "1290", "2001", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 405, "2.5", "4", "2", "322500", "1820", "1994", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 378, "3", "3", "1", "275000", "1590", "1997", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 379, "2", "4", "2", "595000", "2020", "1960", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 380, "1.5", "3", "1.5", "435000", "1300", "1904", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 381, "1.5", "2", "1", "270000", "1380", "1954", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 382, "3", "3", "2", "950000", "4040", "1986", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 383, "2.25", "4", "2", "389000", "2130", "2001", "98019" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 384, "2.25", "4", "1", "560000", "2550", "1968", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 385, "3.5", "5", "2", "1.35e+006", "4800", "1998", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 386, "2.25", "4", "2", "799000", "2510", "1969", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 387, "2", "3", "1", "365500", "1410", "1983", "98072" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 388, "2", "3", "1", "252350", "1650", "1979", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 389, "2.5", "4", "2", "403950", "2120", "1993", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 390, "1.5", "4", "1", "385000", "2040", "1954", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 391, "1", "4", "1.5", "345000", "1550", "1957", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 392, "2.75", "3", "2", "490000", "1980", "1979", "98008" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 393, "2.5", "3", "2", "330000", "1600", "2005", "98019" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 394, "2.75", "4", "2", "927000", "3300", "1953", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 395, "2.5", "4", "2", "1.118e+006", "3840", "1983", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 396, "1", "2", "1", "330000", "1220", "1950", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 397, "2.25", "5", "1", "530000", "2720", "1958", "98008" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 398, "2", "4", "1", "365000", "1940", "1962", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 399, "2.5", "3", "1.5", "378750", "2160", "1909", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 400, "1.75", "4", "1.5", "269900", "1530", "1968", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 401, "3.5", "3", "2", "557000", "1710", "2008", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 402, "1.75", "4", "1", "360000", "3730", "1974", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 403, "1", "2", "1", "352000", "940", "1937", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 404, "2.5", "3", "2", "437000", "1750", "1994", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 406, "3.25", "3", "2", "650000", "1510", "2001", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 437, "2.5", "5", "2", "722500", "4870", "1983", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 438, "2.5", "3", "2", "843000", "3130", "1991", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 439, "2", "2", "3", "438000", "1270", "2000", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 472, "4.25", "3", "2", "868700", "3840", "2000", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 473, "2.75", "4", "2", "1.199e+006", "4110", "1928", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 474, "3.25", "4", "2", "1.15e+006", "4190", "2000", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 475, "2.75", "4", "2", "859900", "3390", "2011", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 476, "2.25", "4", "2", "520000", "1890", "2003", "98029" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 477, "2.5", "3", "2", "460000", "1610", "2005", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 478, "1.5", "3", "1", "438924", "1050", "1949", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 479, "1", "2", "1", "315000", "630", "1918", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 480, "2.75", "4", "1", "590000", "2910", "1975", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 481, "1.75", "4", "1", "378500", "1700", "1955", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 482, "2.5", "3", "2", "328500", "1950", "1990", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 483, "3", "3", "2", "849950", "2990", "1973", "98005" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 484, "1.5", "3", "1", "525000", "1350", "1950", "98136" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 485, "3.25", "4", "2.5", "1.385e+006", "4860", "1993", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 486, "2.5", "4", "1", "295000", "2160", "1978", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 487, "3.5", "6", "2", "1.067e+006", "4860", "1998", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 488, "2", "2", "1", "207950", "890", "1917", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 489, "2.75", "4", "2", "699900", "2810", "2002", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 490, "2.5", "5", "2", "1.28e+006", "3400", "1977", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 491, "1.5", "4", "1", "452000", "1580", "1963", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 492, "2", "3", "1", "370000", "1680", "1987", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 493, "1.75", "3", "1", "232000", "1300", "1968", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 494, "2.5", "5", "2", "669950", "2820", "1960", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 495, "2", "3", "1", "397500", "1510", "1972", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 496, "2.5", "2", "2", "490000", "1230", "2004", "98112" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 497, "2", "4", "2", "725000", "2110", "1925", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 498, "2.75", "3", "1", "299000", "3080", "1958", "98032" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 471, "2", "2", "2", "290900", "1610", "1930", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 470, "2.5", "3", "2", "342500", "1810", "1993", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 469, "2", "3", "1", "340500", "2270", "1947", "98168" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 468, "2.5", "4", "2", "325000", "1850", "1997", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 440, "1.75", "3", "1", "578000", "2120", "1977", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 441, "1.5", "3", "1", "227950", "1670", "1954", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 442, "2.25", "3", "2", "196000", "2070", "1974", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 443, "1", "2", "1", "641000", "1420", "1953", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 444, "1.5", "3", "1", "350000", "1250", "1980", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 445, "1", "3", "1", "205000", "940", "1960", "98032" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 446, "1.75", "3", "1", "400000", "1920", "1968", "98072" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 447, "2.5", "3", "1", "1.03e+006", "3545", "2005", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 448, "2", "3", "1", "505000", "1260", "1972", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 449, "2.5", "5", "1", "475000", "2340", "1975", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 450, "2.25", "3", "1", "520000", "2590", "1977", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 451, "4.5", "3", "2", "1.45e+006", "3970", "1977", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 452, "1.75", "3", "1", "333500", "1220", "1965", "98011" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 377, "1.75", "3", "1", "450000", "1640", "1940", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 453, "1", "3", "1", "232000", "1400", "1976", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 455, "1.75", "3", "1", "811000", "1870", "1960", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 456, "2.5", "3", "2", "551000", "2830", "2001", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 457, "2.5", "3", "2", "496500", "2260", "1994", "98072" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 458, "3", "3", "2", "705000", "1970", "1980", "98070" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 459, "2.5", "4", "1", "578000", "3140", "1966", "98055" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 460, "1.75", "3", "1", "255000", "1240", "1986", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 461, "3.5", "4", "2", "1.05e+006", "3450", "2007", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 462, "2.25", "3", "2", "348000", "2570", "1989", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 463, "2", "3", "2", "230000", "1510", "1985", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 464, "2.25", "4", "2", "359500", "2390", "1988", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 465, "1", "3", "1", "330000", "980", "1953", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 466, "0.75", "1", "1", "80000", "430", "1912", "98014" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 467, "1.75", "3", "1", "465000", "1480", "1954", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 454, "2.75", "3", "1", "691100", "2360", "1983", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 376, "2.5", "4", "2", "730000", "3230", "2004", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 375, "2.25", "3", "2", "297000", "1450", "1994", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 374, "3", "5", "2", "380000", "3450", "2004", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 284, "2.5", "4", "2", "780000", "3500", "2005", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 285, "3", "3", "1", "330000", "2420", "1988", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 286, "2.5", "4", "2", "370000", "2720", "1992", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 287, "2.25", "5", "1", "467000", "2500", "1979", "98072" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 288, "1.75", "3", "1", "405000", "1670", "1980", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 289, "2.25", "5", "1", "675000", "2900", "1985", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 290, "1", "2", "1", "500000", "1640", "1954", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 291, "2.5", "4", "2", "389999", "1890", "1968", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 292, "1.75", "4", "1", "630000", "2950", "1975", "98034" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 293, "2.5", "4", "2", "360000", "2160", "1992", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 294, "3", "4", "2", "580000", "3280", "1986", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 295, "2", "3", "2", "550000", "1970", "1929", "98126" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 296, "2.5", "4", "2", "879000", "3360", "1994", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 297, "2", "3", "1", "265000", "1320", "1993", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 298, "2.5", "3", "2", "446500", "2650", "1990", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 299, "1.5", "3", "1", "404000", "2030", "1963", "98108" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 300, "1.75", "3", "1", "267500", "1590", "1957", "98188" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 301, "5", "4", "1", "3.075e+006", "4550", "2002", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 302, "2.5", "3", "2", "335000", "2440", "1998", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 303, "2.5", "3", "1", "576000", "1940", "1948", "98117" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 304, "2.5", "3", "2", "208633", "2040", "2006", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 305, "2.25", "3", "1", "315000", "2200", "1964", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 306, "1.75", "3", "1", "725000", "1920", "1913", "98112" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 307, "2.75", "4", "1", "550000", "1800", "1965", "98177" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 308, "2.25", "4", "2", "610750", "2180", "1984", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 309, "1", "2", "1.5", "550700", "1010", "1908", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 310, "2.75", "4", "2", "665000", "3320", "1960", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 283, "3", "5", "2", "2.05e+006", "3830", "1905", "98122" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 282, "1", "2", "1", "170000", "860", "1931", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 281, "1.75", "4", "1", "304900", "2600", "1969", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 280, "1.75", "3", "1", "405000", "2390", "1908", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 252, "2.5", "4", "2", "455000", "3360", "2001", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 253, "2.25", "3", "2", "415000", "1510", "1991", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 254, "1", "3", "1", "349500", "1400", "1953", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 255, "2.5", "3", "2", "245000", "1730", "1987", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 256, "2", "2", "1.5", "592500", "1420", "1928", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 257, "1.75", "4", "1", "385000", "2360", "1955", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 258, "1.75", "3", "1", "315000", "1580", "1974", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 259, "1", "3", "1", "255000", "1230", "1979", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 260, "2.5", "4", "2", "693000", "2460", "2006", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 261, "1", "3", "1.5", "780000", "1660", "1911", "98112" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 262, "1.75", "3", "1", "237000", "1270", "1960", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 263, "2.25", "3", "2", "525000", "2100", "1979", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 264, "1", "2", "1", "425000", "770", "1930", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 311, "2.5", "4", "1.5", "834000", "2370", "1928", "98144" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 265, "0.75", "1", "1", "369900", "760", "1936", "98070" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 267, "1", "3", "1", "285000", "1120", "1954", "98106" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 268, "1", "2", "1", "415000", "1070", "1937", "98115" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 269, "2.5", "3", "1", "272500", "2070", "1979", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 270, "3.25", "4", "1.5", "2.9e+006", "5050", "1982", "98004" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 271, "4.75", "4", "2", "1.365e+006", "5310", "1989", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 272, "1", "2", "1", "436000", "1040", "1939", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 273, "1", "3", "1", "210000", "1700", "1967", "98003" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 274, "1", "3", "1", "236000", "1300", "1961", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 275, "1.75", "3", "1", "331000", "1080", "1954", "98199" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 276, "2.5", "3", "2", "365000", "2653", "2006", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 277, "2", "3", "1", "450000", "2290", "1960", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 278, "2.75", "4", "2", "770000", "3820", "2014", "98028" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 279, "2.5", "4", "1", "455000", "2210", "1997", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 266, "2.5", "4", "2", "290000", "1700", "1988", "98031" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 999, "1", "2", "1", "189950", "1030", "1981", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 312, "1.75", "5", "1.5", "201000", "1660", "1915", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 314, "3.25", "4", "1", "1.384e+006", "4290", "1997", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 347, "1", "4", "1", "239900", "1000", "1943", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 348, "1", "2", "1", "320000", "1070", "1930", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 349, "2", "3", "1", "206600", "1390", "1987", "98030" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 350, "1.75", "4", "1", "387000", "2500", "1973", "98155" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 351, "0.75", "1", "1", "299000", "560", "1967", "98014" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 352, "2.75", "4", "2", "855000", "2270", "1965", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 353, "1", "3", "1", "315000", "1900", "1954", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 354, "1", "2", "1", "437500", "990", "1907", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 355, "1.5", "4", "1", "252000", "1550", "1969", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 356, "1.75", "4", "1", "375000", "2200", "1955", "98118" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 357, "2.5", "4", "2", "300000", "1910", "2005", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 358, "1", "4", "1.5", "420000", "1750", "1954", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 359, "1", "3", "1", "900000", "1330", "1928", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 360, "2.5", "3", "2", "679900", "2440", "2000", "98116" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 361, "2.5", "3", "2", "463000", "1640", "1992", "98053" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 362, "2.5", "5", "2", "380000", "2760", "1978", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 363, "2.5", "4", "2", "329500", "1820", "1994", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 364, "2.5", "3", "1", "604950", "2110", "2013", "98033" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 365, "2.5", "5", "1", "795000", "3040", "1966", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 366, "2", "3", "2", "465000", "1840", "1994", "98045" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 367, "2.5", "4", "2", "673000", "2990", "2002", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 368, "2.5", "4", "2", "810000", "3520", "1991", "98074" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 369, "2.75", "4", "1", "785000", "2440", "1989", "98075" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 370, "3", "4", "1", "338000", "2090", "1986", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 371, "2.25", "3", "2", "280000", "1430", "1993", "98056" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 372, "2.25", "4", "1", "315000", "2180", "1954", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 373, "2.25", "4", "1", "530000", "2180", "1954", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 346, "1", "4", "1", "165000", "1000", "1943", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 345, "2.5", "4", "2", "552250", "2580", "2002", "98065" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 344, "1.75", "4", "1", "309600", "1275", "1991", "98070" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 343, "1.75", "3", "1", "425000", "2500", "1957", "98125" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 315, "3.25", "4", "1", "1.4e+006", "4290", "1997", "98006" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 316, "2.25", "4", "1", "305000", "1950", "1979", "98058" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 317, "2", "3", "1", "487000", "2590", "1948", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 318, "2.5", "3", "1", "390000", "1930", "1988", "98042" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 319, "1", "2", "1", "548000", "1470", "1916", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 320, "1", "4", "1", "268750", "800", "1943", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 321, "2.75", "5", "2", "819900", "3150", "2013", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 322, "2.25", "3", "2", "520000", "2030", "1984", "98027" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 323, "2", "3", "1", "230000", "1450", "2003", "98001" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 324, "1.75", "3", "1", "240000", "1510", "1969", "98023" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 325, "1", "2", "1", "232000", "1240", "1922", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 326, "1", "2", "1", "240500", "1240", "1922", "98146" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 327, "2.5", "3", "2", "274975", "3030", "1987", "98077" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 313, "2.5", "5", "2", "2.384e+006", "3650", "1921", "98119" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 328, "2", "4", "1.5", "740000", "2050", "1922", "98102" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 330, "2.25", "3", "1", "790000", "2370", "1977", "98005" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 331, "3.5", "4", "2", "880000", "2800", "1951", "98105" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 332, "1.75", "6", "2", "279000", "2240", "1955", "98198" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 333, "2", "3", "1", "295000", "1810", "1991", "98022" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 334, "1", "2", "1", "640000", "1070", "1924", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 335, "2", "4", "2", "940000", "2490", "1968", "98040" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 336, "2.5", "4", "2", "260000", "1960", "2003", "98038" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 337, "2.75", "3", "1", "559900", "2930", "2004", "98072" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 338, "2", "4", "1.5", "791500", "1510", "1911", "98103" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 339, "1.75", "3", "1", "265000", "1420", "1954", "98133" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 340, "1.75", "3", "1", "245000", "1740", "1954", "98178" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 341, "1.75", "4", "2", "485000", "2560", "1962", "98052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 342, "3.5", "4", "2", "684000", "3040", "2010", "98059" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 329, "1", "3", "1", "186375", "1000", "1952", "98166" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Floors", "Price", "SquareFeet", "YearBuilt", "ZipCode" },
                values: new object[] { 1000, "2", "3", "1", "289000", "1850", "1988", "98001" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
