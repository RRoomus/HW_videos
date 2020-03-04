using System;
using Abc.Domain.Common;

namespace Abc.Infra
{
    public class FilteredRepository<T> : SortedRepository<T>, ISearching
    {
        public string SearchString { get; set; }
    }
}
