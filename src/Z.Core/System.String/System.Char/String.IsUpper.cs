using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as an
        ///     uppercase letter.
        /// </summary>
        /// <param name="s">A string.</param>
        /// <param name="index">The position of the character to evaluate in .</param>
        /// <returns>true if the character at position  in  is an uppercase letter; otherwise, false.</returns>
        public static Boolean IsUpper(this String s, Int32 index)
        {
            return Char.IsUpper(s, index);
        }
    }
