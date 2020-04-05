using System;
using Abc.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Quantity
{
    [TestClass]
    public class UnitTermViewTests : SealedClassTests<UnitTermView, CommonTermView>
    {
        [TestMethod]
        public void UnitIdTest() => IsNullableProperty(() => obj.MasterId, x => obj.TermId = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.MasterId}.{obj.TermId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
