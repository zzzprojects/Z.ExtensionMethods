using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that extracts all Double from the string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>All extracted Double.</returns>
        public static double[] ExtractManyDouble(this string @this)
        {
            return Regex.Matches(@this, @"[-]?\d+(\.\d+)?")
                        .Cast<Match>()
                        .Select(x => Convert.ToDouble(x.Value))
                        .ToArray();
        }
    }


}