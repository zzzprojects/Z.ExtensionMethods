using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A T[] extension method that exists.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="array">The array to act on.</param>
        /// <param name="match">Specifies the match.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static Boolean Exists<T>(this T[] array, Predicate<T> match)
        {
            return Array.Exists(array, match);
        }
    }
