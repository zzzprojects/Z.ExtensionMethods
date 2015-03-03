namespace Z.ExtensionMethods
{

using System;
using System.Linq;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that removes the letter.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>A string.</returns>
        public static string RemoveWhere(this string @this, Func<char, bool> predicate)
        {
            return new string(@this.ToCharArray().Where(x => !predicate(x)).ToArray());
        }
    }


}