namespace Z.ExtensionMethods
{

using System;
using System.Globalization;

public static partial class Extensions
    {
        /// <summary>
        ///     Categorizes the character at the specified position in a specified string into a group identified by one of
        ///     the  values.
        /// </summary>
        /// <param name="s">A .</param>
        /// <param name="index">The character position in .</param>
        /// <returns>A  enumerated constant that identifies the group that contains the character at position  in .</returns>
        public static UnicodeCategory GetUnicodeCategory(this String s, Int32 index)
        {
            return Char.GetUnicodeCategory(s, index);
        }
    }


}