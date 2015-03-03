namespace Z.ExtensionMethods.ObjectExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A T extension method that chains actions.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="action">The action.</param>
        /// <returns>The @this acted on.</returns>
        public static T Chain<T>(this T @this, Action<T> action)
        {
            action(@this);

            return @this;
        }
    }


}