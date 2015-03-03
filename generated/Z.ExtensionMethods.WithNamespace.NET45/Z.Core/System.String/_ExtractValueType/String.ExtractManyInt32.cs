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
        ///     A string extension method that extracts all Int32 from the string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>All extracted Int32.</returns>
        public static int[] ExtractManyInt32(this string @this)
        {
            return Regex.Matches(@this, @"[-]?\d+")
                        .Cast<Match>()
                        .Select(x => Convert.ToInt32(x.Value))
                        .ToArray();
        }
    }


}