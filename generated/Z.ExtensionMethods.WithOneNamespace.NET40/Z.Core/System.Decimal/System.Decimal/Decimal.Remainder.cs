namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Computes the remainder after dividing two  values.
        /// </summary>
        /// <param name="d1">The dividend.</param>
        /// <param name="d2">The divisor.</param>
        /// <returns>The remainder after dividing  by .</returns>
        public static Decimal Remainder(this Decimal d1, Decimal d2)
        {
            return Decimal.Remainder(d1, d2);
        }
    }


}