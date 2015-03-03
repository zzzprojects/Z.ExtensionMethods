using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A T[] extension method that searches for the first all.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="array">The array to act on.</param>
        /// <param name="match">Specifies the match.</param>
        /// <returns>The found all.</returns>
        public static T[] FindAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindAll(array, match);
        }
    }


}