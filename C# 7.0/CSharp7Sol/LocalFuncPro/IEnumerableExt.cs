using System;
using System.Collections.Generic;
using System.Text;

namespace LocalFuncPro
{
    public static class IEnumerableExt
    {
        //Local functions considerably simplify code for LINQ operators, where you usually have to separate argument checks from
        //actual logic to make argument checks instant, not delayed until after iteration started.
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null) 
                throw new ArgumentNullException(nameof(source));
            if (predicate == null) 
                throw new ArgumentNullException(nameof(predicate));

            return iterator();

            IEnumerable<TSource> iterator()
            {
                foreach (TSource element in source)
                    if (predicate(element))
                        yield return element;
            }
        }
    }
}
