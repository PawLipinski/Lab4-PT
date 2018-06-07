using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PT
{
    public static class Extensions
    {
        public static IEnumerable<U> SelectOrNull<T, U>(this IEnumerable<T> seq, Func<T, U> map)
        {
            if (seq == null)
                return Enumerable.Empty<U>(); // Or return null, though this will play nicely with other operations
            return seq.Select(map);
        }
    }
}
