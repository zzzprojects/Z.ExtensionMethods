using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a letter or a decimal digit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is a letter or a decimal digit; otherwise, false.</returns>
        public static Boolean IsLetterOrDigit(this Char c)
        {
            return Char.IsLetterOrDigit(c);
        }
    }


}