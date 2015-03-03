using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that if empty.
        /// </summary>
        /// <param name="value">The value to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>A string.</returns>
        public static string IfEmpty(this string value, string defaultValue)
        {
            return (value.IsNotEmpty() ? value : defaultValue);
        }
    }


}