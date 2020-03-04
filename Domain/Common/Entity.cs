using Abc.Data.Common;

namespace Abc.Domain.Common
{
    public abstract class Entity<TData> where TData: PeriodData 
    {
        public TData Data { get; internal set; }

        protected Entity(TData data) => Data = data;
    }
}