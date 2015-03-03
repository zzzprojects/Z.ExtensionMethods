namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a symbol character.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is a symbol character; otherwise, false.</returns>
        public static Boolean IsSymbol(this Char c)
        {
            return Char.IsSymbol(c);
        }
    }


}