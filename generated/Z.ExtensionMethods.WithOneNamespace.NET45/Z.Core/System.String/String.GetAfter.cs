namespace Z.ExtensionMethods
{

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that get the string after the specified string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="value">The value to search.</param>
        /// <returns>The string after the specified value.</returns>
        public static string GetAfter(this string @this, string value)
        {
            if (@this.IndexOf(value) == -1)
            {
                return "";
            }
            return @this.Substring(@this.IndexOf(value) + value.Length);
        }
    }


}