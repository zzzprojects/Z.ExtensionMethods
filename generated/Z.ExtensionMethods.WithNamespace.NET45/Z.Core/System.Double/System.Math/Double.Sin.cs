using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the sine of the specified angle.
        /// </summary>
        /// <param name="a">An angle, measured in radians.</param>
        /// <returns>The sine of . If  is equal to , , or , this method returns .</returns>
        public static Double Sin(this Double a)
        {
            return Math.Sin(a);
        }
    }


}