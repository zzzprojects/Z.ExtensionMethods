using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.Collections.ObjectModel;

public static partial class Extensions
    {
        /// <summary>
        ///     A T[] extension method that converts an array to a read only.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="array">The array to act on.</param>
        /// <returns>A list of.</returns>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array)
        {
            return Array.AsReadOnly(array);
        }
    }


}