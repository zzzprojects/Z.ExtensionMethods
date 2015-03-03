using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the value of the specified  to the equivalent 8-bit signed integer.
        /// </summary>
        /// <param name="value">The decimal number to convert.</param>
        /// <returns>An 8-bit signed integer equivalent to .</returns>
        public static SByte ToSByte(this Decimal value)
        {
            return Decimal.ToSByte(value);
        }
    }


}