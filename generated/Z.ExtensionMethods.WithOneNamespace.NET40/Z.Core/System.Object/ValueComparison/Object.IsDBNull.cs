namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns an indication whether the specified object is of type .
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="value">An object.</param>
        /// <returns>true if  is of type ; otherwise, false.</returns>
        public static Boolean IsDBNull<T>(this T value) where T : class
        {
            return Convert.IsDBNull(value);
        }
    }


}