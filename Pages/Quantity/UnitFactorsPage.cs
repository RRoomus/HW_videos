using System;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Pages.Quantity
{
    public class UnitFactorsPage : CommonPage<IUnitFactorRepository, UnitFactor, UnitFactorView, UnitFactorData>
    {
        protected internal UnitFactorsPage(IUnitFactorRepository r = null) : base(r)
        {
            PageTitle = "Unit Factors";
        }

        public override string ItemId
        {
            get
            {
                if (Item is null) return String.Empty;
                return $"{Item.SystemOfUnitsId}.{Item.UnitId}";
            }
        }

        protected internal override string getPageUrl() => "/Quantity/UnitFactor";

        protected internal override UnitFactor toObject(UnitFactorView view)
        {
            return UnitFactorViewFactory.Create(view);
        }

        protected internal override UnitFactorView toView(UnitFactor obj)
        {
            return UnitFactorViewFactory.Create(obj);
        }
    }
}
