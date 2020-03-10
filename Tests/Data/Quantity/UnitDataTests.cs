﻿using Abc.Data.Common;
using Abc.Data.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Quantity
{
    [TestClass]
    public class UnitDataTests:SealedClassTest<UnitData,DefinedEntityData>
    {
        [TestMethod]
        public void MeadureIdTest()
        {
            IsNullableProperty(() => obj.MeasureId, x => obj.MeasureId = x);
        }
    }
}
