using System;
using Abc.Data.Common;
using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Common
{
    [TestClass]
    public class PeriodViewTests : AbstractClassTests<PeriodView, object>
    {
        private class testClass : PeriodView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void ValidToTest()
        {
            IsNullableProperty(() => obj.ValidTo, x => obj.ValidTo = x);
        }

        [TestMethod]
        public void ValidFromTest()
        {
            IsNullableProperty(() => obj.ValidFrom, x => obj.ValidFrom = x);
        }
    }
}
