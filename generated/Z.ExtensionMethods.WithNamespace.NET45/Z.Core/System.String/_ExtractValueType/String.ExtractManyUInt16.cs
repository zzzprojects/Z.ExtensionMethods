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
        ///     A string extension method that extracts all UInt16 from the string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>All extracted UInt16.</returns>
        public static ushort[] ExtractManyUInt16(this string @this)
        {
            return Regex.Matches(@this, @"\d+")
                        .Cast<Match>()
                        .Select(x => Convert.ToUInt16(x.Value))
                        .ToArray();
        }
    }


}