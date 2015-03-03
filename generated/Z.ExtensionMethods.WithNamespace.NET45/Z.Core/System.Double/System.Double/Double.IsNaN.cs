using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns a value that indicates whether the specified value is not a number ().
        /// </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>true if  evaluates to ; otherwise, false.</returns>
        public static Boolean IsNaN(this Double d)
        {
            return Double.IsNaN(d);
        }
    }


}