using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity
{
    public sealed class SystemOfUnitsViewFactory
    {
        public static SystemOfUnits Create(SystemOfUnitsView view)
        {
            var d = new SystemsOfUnitsData();
            Copy.Members(view, d);
            return new SystemOfUnits(d);
        }

        public static SystemOfUnitsView Create(SystemOfUnits obj)
        {
            var v = new SystemOfUnitsView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
