namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the specified  value to the equivalent OLE Automation Currency value, which is contained in a 64-bit
        ///     signed integer.
        /// </summary>
        /// <param name="value">The decimal number to convert.</param>
        /// <returns>A 64-bit signed integer that contains the OLE Automation equivalent of .</returns>
        public static Int64 ToOACurrency(this Decimal value)
        {
            return Decimal.ToOACurrency(value);
        }
    }


}