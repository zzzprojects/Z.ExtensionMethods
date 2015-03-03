using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a punctuation mark.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if  is a punctuation mark; otherwise, false.</returns>
        public static Boolean IsPunctuation(this Char c)
        {
            return Char.IsPunctuation(c);
        }
    }


}