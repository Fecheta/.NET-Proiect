using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Infrastructure.Tests
{
    public class DataBaseTest : IDisposable
    {
        protected readonly HouseContext context;

        public DataBaseTest()
        {
            var options = new DbContextOptionsBuilder<HouseContext>().UseInMemoryDatabase("TestDatabase").Options;
            context = new HouseContext(options);
            context.Database.EnsureCreated();
            DatabaseInitializer.Initialize(context);
        }

        public void Dispose()
        {
            context.Database.EnsureDeleted();
            context.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}