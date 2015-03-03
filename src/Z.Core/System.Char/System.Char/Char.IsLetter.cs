using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a Unicode letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is a letter; otherwise, false.</returns>
        public static Boolean IsLetter(this Char c)
        {
            return Char.IsLetter(c);
        }
    }
