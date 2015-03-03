using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the absolute value of a  number.
        /// </summary>
        /// <param name="value">A number that is greater than or equal to , but less than or equal to .</param>
        /// <returns>A decimal number, x, such that 0 ? x ?.</returns>
        public static Decimal Abs(this Decimal value)
        {
            return Math.Abs(value);
        }
    }
