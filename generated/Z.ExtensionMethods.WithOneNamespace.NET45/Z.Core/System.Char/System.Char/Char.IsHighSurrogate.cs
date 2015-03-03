namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified  object is a high surrogate.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>
        ///     true if the numeric value of the  parameter ranges from U+D800 through U+DBFF; otherwise, false.
        /// </returns>
        public static Boolean IsHighSurrogate(this Char c)
        {
            return Char.IsHighSurrogate(c);
        }
    }


}