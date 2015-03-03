using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that converts the @this to an enum.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a T.</returns>
        public static T ToEnum<T>(this string @this)
        {
            Type enumType = typeof (T);
            return (T) Enum.Parse(enumType, @this);
        }
    }
