namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the hyperbolic cosine of the specified angle.
        /// </summary>
        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>The hyperbolic cosine of . If  is equal to  or ,  is returned. If  is equal to ,  is returned.</returns>
        public static Double Cosh(this Double value)
        {
            return Math.Cosh(value);
        }
    }


}