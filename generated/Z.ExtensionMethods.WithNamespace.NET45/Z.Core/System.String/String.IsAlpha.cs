using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System.Text.RegularExpressions;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that query if '@this' is Alpha.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if Alpha, false if not.</returns>
        public static bool IsAlpha(this string @this)
        {
            return !Regex.IsMatch(@this, "[^a-zA-Z]");
        }
    }


}