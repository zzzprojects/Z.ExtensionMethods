using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that replace when equals.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="oldValue">The old value.</param>
        /// <param name="newValue">The new value.</param>
        /// <returns>The new value if the string equal old value; Otherwise old value.</returns>
        public static string ReplaceWhenEquals(this string @this, string oldValue, string newValue)
        {
            return @this == oldValue ? newValue : @this;
        }
    }


}