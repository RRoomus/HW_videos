using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Pages.Quantity
{
    public class SystemsOfUnitsPage : CommonPage<ISystemOfUnitsRepository, SystemOfUnits, SystemOfUnitsView, SystemsOfUnitsData>
    {
        protected internal SystemsOfUnitsPage(ISystemOfUnitsRepository r = null) : base(r)
        {
            PageTitle = "System Of Units";
        }

        public override string ItemId => Item.Id;

        protected internal override string getPageUrl() => "/Quantity/SystemOfUnits";

        protected internal override SystemOfUnits toObject(SystemOfUnitsView view)
        {
            return SystemOfUnitsViewFactory.Create(view);
        }

        protected internal override SystemOfUnitsView toView(SystemOfUnits obj)
        {
            return SystemOfUnitsViewFactory.Create(obj);
        }
    }
}
