using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity
{
    public sealed class SystemOfUnits : Entity<SystemsOfUnitsData>
    {
        public SystemOfUnits() : this(null) { }

        public SystemOfUnits(SystemsOfUnitsData data) : base(data) { }
    }
}
