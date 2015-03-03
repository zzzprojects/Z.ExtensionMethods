namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the value of the specified  to the equivalent 16-bit unsigned integer.
        /// </summary>
        /// <param name="value">The decimal number to convert.</param>
        /// <returns>A 16-bit unsigned integer equivalent to the value of .</returns>
        public static UInt16 ToUInt16(this Decimal value)
        {
            return Decimal.ToUInt16(value);
        }
    }


}