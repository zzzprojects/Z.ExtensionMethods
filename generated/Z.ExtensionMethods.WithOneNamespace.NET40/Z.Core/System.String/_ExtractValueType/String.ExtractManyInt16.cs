namespace Z.ExtensionMethods
{

using System;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that extracts all Int16 from the string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>All extracted Int16.</returns>
        public static short[] ExtractManyInt16(this string @this)
        {
            return Regex.Matches(@this, @"[-]?\d+")
                        .Cast<Match>()
                        .Select(x => Convert.ToInt16(x.Value))
                        .ToArray();
        }
    }


}