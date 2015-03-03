using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a control character.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is a control character; otherwise, false.</returns>
        public static Boolean IsControl(this Char c)
        {
            return Char.IsControl(c);
        }
    }
