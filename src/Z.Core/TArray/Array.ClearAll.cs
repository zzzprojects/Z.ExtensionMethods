using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A T[] extension method that clears all described by @this.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// ###
        /// <returns>.</returns>
        public static void ClearAll<T>(this T[] @this)
        {
            Array.Clear(@this, 0, @this.Length);
        }
    }
