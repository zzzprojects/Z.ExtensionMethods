using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the value of a Unicode character to its lowercase equivalent using the casing rules of the invariant
        ///     culture.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>
        ///     The lowercase equivalent of the  parameter, or the unchanged value of , if  is already lowercase or not
        ///     alphabetic.
        /// </returns>
        public static Char ToLowerInvariant(this Char c)
        {
            return Char.ToLowerInvariant(c);
        }
    }


}