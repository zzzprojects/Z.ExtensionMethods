using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a lowercase letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is a lowercase letter; otherwise, false.</returns>
        public static Boolean IsLower(this Char c)
        {
            return Char.IsLower(c);
        }
    }


}