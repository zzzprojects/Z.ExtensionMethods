using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A Random extension method that return a random value from the specified values.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="values">A variable-length parameters list containing arguments.</param>
        /// <returns>One of the specified value.</returns>
        public static T OneOf<T>(this Random @this, params T[] values)
        {
            return values[@this.Next(values.Length)];
        }
    }


}