using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A T[] extension method that true for all.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="array">The array to act on.</param>
        /// <param name="match">Specifies the match.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static Boolean TrueForAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.TrueForAll(array, match);
        }
    }
