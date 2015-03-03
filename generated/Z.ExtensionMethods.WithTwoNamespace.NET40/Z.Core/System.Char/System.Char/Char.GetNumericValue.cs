using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the specified numeric Unicode character to a double-precision floating point number.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The numeric value of  if that character represents a number; otherwise, -1.0.</returns>
        public static Double GetNumericValue(this Char c)
        {
            return Char.GetNumericValue(c);
        }
    }


}