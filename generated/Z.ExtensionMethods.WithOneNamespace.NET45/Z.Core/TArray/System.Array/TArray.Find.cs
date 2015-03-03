namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A T[] extension method that searches for the first match.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="array">The array to act on.</param>
        /// <param name="match">Specifies the match.</param>
        /// <returns>A T.</returns>
        public static T Find<T>(this T[] array, Predicate<T> match)
        {
            return Array.Find(array, match);
        }
    }


}