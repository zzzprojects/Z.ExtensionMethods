using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as an uppercase letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is an uppercase letter; otherwise, false.</returns>
        public static Boolean IsUpper(this Char c)
        {
            return Char.IsUpper(c);
        }
    }
