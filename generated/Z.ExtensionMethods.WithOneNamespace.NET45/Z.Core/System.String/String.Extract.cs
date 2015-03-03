namespace Z.ExtensionMethods
{

using System;
using System.Linq;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that extracts this object.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>A string.</returns>
        public static string Extract(this string @this, Func<char, bool> predicate)
        {
            return new string(@this.ToCharArray().Where(predicate).ToArray());
        }
    }


}