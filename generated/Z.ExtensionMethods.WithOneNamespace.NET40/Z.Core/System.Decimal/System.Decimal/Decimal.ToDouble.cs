namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the value of the specified  to the equivalent double-precision floating-point number.
        /// </summary>
        /// <param name="d">The decimal number to convert.</param>
        /// <returns>A double-precision floating-point number equivalent to .</returns>
        public static Double ToDouble(this Decimal d)
        {
            return Decimal.ToDouble(d);
        }
    }


}