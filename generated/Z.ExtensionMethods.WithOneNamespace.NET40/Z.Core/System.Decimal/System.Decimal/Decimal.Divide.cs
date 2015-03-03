namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Divides two specified  values.
        /// </summary>
        /// <param name="d1">The dividend.</param>
        /// <param name="d2">The divisor.</param>
        /// <returns>The result of dividing  by .</returns>
        public static Decimal Divide(this Decimal d1, Decimal d2)
        {
            return Decimal.Divide(d1, d2);
        }
    }


}