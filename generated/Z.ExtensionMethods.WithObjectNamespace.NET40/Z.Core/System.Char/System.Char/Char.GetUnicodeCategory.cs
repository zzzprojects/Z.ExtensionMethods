using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.Globalization;

public static partial class Extensions
    {
        /// <summary>
        ///     Categorizes a specified Unicode character into a group identified by one of the  values.
        /// </summary>
        /// <param name="c">The Unicode character to categorize.</param>
        /// <returns>A  value that identifies the group that contains .</returns>
        public static UnicodeCategory GetUnicodeCategory(this Char c)
        {
            return Char.GetUnicodeCategory(c);
        }
    }


}