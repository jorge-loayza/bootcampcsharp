using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq
{
    public static class MyLinqExtesnsions
    {
        public static IEnumerable<T> ProcessSequence<T>(this IEnumerable<T> secuence)
        {
            // Some procesing
            return secuence;
        }

        public static int? Median(this IEnumerable<int?> sequence)
        {
            var ordered = sequence.OrderBy(item => item);
            int middlePosition = ordered.Count() / 2;
            return ordered.ElementAt(middlePosition);
        }
        public static int? Median<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {
            return sequence.Select(selector).Median();
        }
        public static int? Mode(this IEnumerable<int?> sequence)
        {
            var ordered = sequence.OrderBy(item => item);
            int middlePosition = ordered.Count() / 2;
            return ordered.ElementAt(middlePosition);
        }
        public static int? Mode<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {
          
            return sequence
                .GroupBy(selector)
                .OrderByDescending(v => v.Count())
                .First().Key;
        }
    }
}
