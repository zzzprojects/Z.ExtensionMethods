namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a number.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is a number; otherwise, false.</returns>
        public static Boolean IsNumber(this Char c)
        {
            return Char.IsNumber(c);
        }
    }


}