namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified character has a surrogate code unit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is either a high surrogate or a low surrogate; otherwise, false.</returns>
        public static Boolean IsSurrogate(this Char c)
        {
            return Char.IsSurrogate(c);
        }
    }


}