using System.Text.RegularExpressions;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that query if '@this' is Alphanumeric.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if Alphanumeric, false if not.</returns>
        public static bool IsAlphaNumeric(this string @this)
        {
            return !Regex.IsMatch(@this, "[^a-zA-Z0-9]");
        }
    }
