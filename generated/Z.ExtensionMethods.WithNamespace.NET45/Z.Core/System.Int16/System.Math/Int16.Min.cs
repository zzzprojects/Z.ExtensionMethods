using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the smaller of two 16-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 16-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 16-bit signed integers to compare.</param>
        /// <returns>Parameter  or , whichever is smaller.</returns>
        public static Int16 Min(this Int16 val1, Int16 val2)
        {
            return Math.Min(val1, val2);
        }
    }


}