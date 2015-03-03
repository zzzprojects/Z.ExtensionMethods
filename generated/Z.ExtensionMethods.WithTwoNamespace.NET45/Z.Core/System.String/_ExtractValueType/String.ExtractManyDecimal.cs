using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that extracts all Decimal from the string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>All extracted Decimal.</returns>
        public static decimal[] ExtractManyDecimal(this string @this)
        {
            return Regex.Matches(@this, @"[-]?\d+(\.\d+)?")
                        .Cast<Match>()
                        .Select(x => Convert.ToDecimal(x.Value))
                        .ToArray();
        }
    }


}