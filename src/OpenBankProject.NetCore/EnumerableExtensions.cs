using System.Collections.Generic;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> GetEnumerableResults<T>(this IEnumerableSource<T> source)
        {
            var results = new List<T>();
            results.AddRange(source.Items);

            return results;
        }
    }
}
