namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the value of the specified  to the equivalent 8-bit unsigned integer.
        /// </summary>
        /// <param name="value">The decimal number to convert.</param>
        /// <returns>An 8-bit unsigned integer equivalent to .</returns>
        public static Byte ToByte(this Decimal value)
        {
            return Decimal.ToByte(value);
        }
    }


}