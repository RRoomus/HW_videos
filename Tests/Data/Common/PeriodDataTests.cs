﻿using System;
using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Common
{
    [TestClass]
    public class PeriodDataTests : AbstractClassTests<PeriodData, object>
    {
        private class testClass : PeriodData { }

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
