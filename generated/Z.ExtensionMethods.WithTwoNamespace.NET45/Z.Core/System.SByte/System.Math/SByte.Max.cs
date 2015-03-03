using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the larger of two 8-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 8-bit signed integers to compare.</param>
        /// <param name="val2">The second of two 8-bit signed integers to compare.</param>
        /// <returns>Parameter  or , whichever is larger.</returns>
        public static SByte Max(this SByte val1, SByte val2)
        {
            return Math.Max(val1, val2);
        }
    }


}