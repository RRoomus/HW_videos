using System;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Quantity
{
    [TestClass]
    public class SystemsOfUnitsRepositoryTests : RepositoryTests<SystemsOfUnitsRepository, SystemOfUnits, SystemsOfUnitsData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new QuantityDbContext(options);
            dbSet = ((QuantityDbContext)db).SystemsOfUnits;
            obj = new SystemsOfUnitsRepository((QuantityDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<SystemOfUnits, SystemsOfUnitsData>);

        protected override string getId(SystemsOfUnitsData d) => d.Id;

        protected override SystemOfUnits getObject(SystemsOfUnitsData data) => new SystemOfUnits(data);

        protected override void setId(SystemsOfUnitsData d, string id) => d.Id = id;
    }
}
