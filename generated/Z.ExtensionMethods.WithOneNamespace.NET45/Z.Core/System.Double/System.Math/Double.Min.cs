namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the smaller of two double-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
        /// <returns>Parameter  or , whichever is smaller. If , , or both  and  are equal to ,  is returned.</returns>
        public static Double Min(this Double val1, Double val2)
        {
            return Math.Min(val1, val2);
        }
    }


}