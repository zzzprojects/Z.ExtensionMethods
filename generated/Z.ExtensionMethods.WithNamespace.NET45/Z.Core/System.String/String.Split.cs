using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns a String array containing the substrings in this string that are delimited by elements of a specified
        ///     String array. A parameter specifies whether to return empty array elements.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="separator">A string that delimit the substrings in this string.</param>
        /// <param name="option">
        ///     (Optional) Specify RemoveEmptyEntries to omit empty array elements from the array returned,
        ///     or None to include empty array elements in the array returned.
        /// </param>
        /// <returns>
        ///     An array whose elements contain the substrings in this string that are delimited by the separator.
        /// </returns>
        public static string[] Split(this string @this, string separator, StringSplitOptions option = StringSplitOptions.None)
        {
            return @this.Split(new[] {separator}, option);
        }
    }


}