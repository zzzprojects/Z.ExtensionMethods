namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the value of the specified  to the equivalent 32-bit unsigned integer.
        /// </summary>
        /// <param name="d">The decimal number to convert.</param>
        /// <returns>A 32-bit unsigned integer equivalent to the value of .</returns>
        public static UInt32 ToUInt32(this Decimal d)
        {
            return Decimal.ToUInt32(d);
        }
    }


}