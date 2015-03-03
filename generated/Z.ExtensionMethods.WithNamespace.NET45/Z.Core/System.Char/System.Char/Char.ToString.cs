using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the specified Unicode character to its equivalent string representation.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The string representation of the value of .</returns>
        public static String ToString(this Char c)
        {
            return Char.ToString(c);
        }
    }


}