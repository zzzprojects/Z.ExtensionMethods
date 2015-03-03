using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the hyperbolic sine of the specified angle.
        /// </summary>
        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>The hyperbolic sine of . If  is equal to , , or , this method returns a  equal to .</returns>
        public static Double Sinh(this Double value)
        {
            return Math.Sinh(value);
        }
    }
