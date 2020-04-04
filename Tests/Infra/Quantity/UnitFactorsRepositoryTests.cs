using System;
using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Quantity
{
    [TestClass]
    public class UnitFactorsRepositoryTests : RepositoryTests<UnitFactorsRepository, UnitFactor, UnitFactorData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new QuantityDbContext(options);
            dbSet = ((QuantityDbContext)db).UnitFactors;
            obj = new UnitFactorsRepository((QuantityDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(PaginatedRepository<UnitFactor, UnitFactorData>);

        protected override string getId(UnitFactorData d) => $"{d.SystemOfUnitsId}.{d.UnitId}";

        protected override UnitFactor getObject(UnitFactorData data) => new UnitFactor(data);

        protected override void setId(UnitFactorData d, string id)
        {
            var systemofunitsId = GetString.Head(id);
            var unitId = GetString.Tail(id);
            d.SystemOfUnitsId = systemofunitsId;
            d.UnitId = unitId;
        }
    }
}
