public static partial class Extensions
    {
        /// <summary>
        ///     A T extension method that query if '@this' is not null.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if not null, false if not.</returns>
        public static bool IsNotNull<T>(this T @this) where T : class
        {
            return @this != null;
        }
    }
