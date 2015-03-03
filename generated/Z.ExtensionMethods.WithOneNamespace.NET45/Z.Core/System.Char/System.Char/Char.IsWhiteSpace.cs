namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as white space.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is white space; otherwise, false.</returns>
        public static Boolean IsWhiteSpace(this Char c)
        {
            return Char.IsWhiteSpace(c);
        }
    }


}