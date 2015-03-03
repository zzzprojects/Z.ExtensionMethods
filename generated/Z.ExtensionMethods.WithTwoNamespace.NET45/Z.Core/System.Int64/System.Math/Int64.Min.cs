using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the smaller of two 64-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 64-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 64-bit signed integers to compare.</param>
        /// <returns>Parameter  or , whichever is smaller.</returns>
        public static Int64 Min(this Int64 val1, Int64 val2)
        {
            return Math.Min(val1, val2);
        }
    }


}