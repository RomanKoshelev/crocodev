// Crocodev (c) 2015 Crocodev
// Crocodev.Common
// StringExtensions.cs
// romak_000, 2015-03-19 15:29

using System;
using System.Collections.Generic;
using System.Linq;

namespace Crocodev.Common.Extensions
{
    public static class StringExtensions
    {
        // ===================================================================================== []
        // FoldToStringBy
        public static string FoldToStringBy<T>(
            this IEnumerable<T> enumerable,
            Func<T, string> selector,
            string delimiter = ", ",
            string emptyResult = "")
        {
            var list = enumerable as IList<T> ?? enumerable.ToList();
            if (!list.Any()) return emptyResult;
            return list.Select(selector).Aggregate((a, s) => string.Format("{0}{1}{2}", a, delimiter, s));
        }
    }
}