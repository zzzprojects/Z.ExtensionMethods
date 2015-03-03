using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the smaller of two 16-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 16-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 16-bit unsigned integers to compare.</param>
        /// <returns>Parameter  or , whichever is smaller.</returns>
        public static UInt16 Min(this UInt16 val1, UInt16 val2)
        {
            return Math.Min(val1, val2);
        }
    }


}