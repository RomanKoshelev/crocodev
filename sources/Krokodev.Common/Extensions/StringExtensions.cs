// crocodev (c) 2015 Crocodev
// Crocodev.Common
// StringExtensions.cs
// romak_000, 2015-03-24 12:28

using System;
using System.Collections.Generic;
using System.Linq;

namespace Krokodev.Common.Extensions
{
    public static class StringExtensions
    {
        // ===================================================================================== []
        // SafeFormat
        public static string SafeFormat( this string template, params object[] args )
        {
            try {
                return string.Format( template, args );
            }
            catch {
                // ignored
            }

            return template;
        }

        // ===================================================================================== []
        // TryFormat
        public static string TryFormat( this string template, params object[] args )
        {
            return string.Format( template, args );
        }

        // ===================================================================================== []
        // FoldToStringBy
        public static string FoldToStringBy<T>(
            this IEnumerable< T > enumerable,
            Func< T, string > selector,
            string delimiter = ", ",
            string emptyResult = "" )
        {
            var list = enumerable as IList< T > ?? enumerable.ToList();
            if( !list.Any() ) {
                return emptyResult;
            }
            return list.Select( selector ).Aggregate( ( a, s ) => string.Format( "{0}{1}{2}", a, delimiter, s ) );
        }
    }
}