using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Calculates the integral part of a specified double-precision floating-point number.
        /// </summary>
        /// <param name="d">A number to truncate.</param>
        /// <returns>
        ///     The integral part of ; that is, the number that remains after any fractional digits have been discarded, or
        ///     one of the values listed in the following table. Return value.
        /// </returns>
        public static Double Truncate(this Double d)
        {
            return Math.Truncate(d);
        }
    }


}