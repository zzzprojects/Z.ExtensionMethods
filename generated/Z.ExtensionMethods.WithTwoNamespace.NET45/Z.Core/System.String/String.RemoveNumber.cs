using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.Linq;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that removes the number described by @this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A string.</returns>
        public static string RemoveNumber(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => !Char.IsNumber(x)).ToArray());
        }
    }


}