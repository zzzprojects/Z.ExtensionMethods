using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the larger of two single-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two single-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two single-precision floating-point numbers to compare.</param>
        /// <returns>Parameter  or , whichever is larger. If , or , or both  and  are equal to ,  is returned.</returns>
        public static Single Max(this Single val1, Single val2)
        {
            return Math.Max(val1, val2);
        }
    }


}