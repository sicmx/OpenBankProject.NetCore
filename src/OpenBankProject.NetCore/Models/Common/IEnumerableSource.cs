using System.Collections.Generic;

namespace OpenBankProject.NetCore.Models.Common
{
    public interface IEnumerableSource<out T>
    {
        IEnumerable<T> Items { get; }
    }
}
