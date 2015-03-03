using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that queries if '@this' is not (null or empty).
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if '@this' is not (null or empty), false if not.</returns>
        public static bool IsNotNullOrEmpty(this string @this)
        {
            return !string.IsNullOrEmpty(@this);
        }
    }


}