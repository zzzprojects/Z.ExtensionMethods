using System;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that extracts all UInt32 from the string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>All extracted UInt32.</returns>
        public static uint[] ExtractManyUInt32(this string @this)
        {
            return Regex.Matches(@this, @"\d+")
                        .Cast<Match>()
                        .Select(x => Convert.ToUInt32(x.Value))
                        .ToArray();
        }
    }
