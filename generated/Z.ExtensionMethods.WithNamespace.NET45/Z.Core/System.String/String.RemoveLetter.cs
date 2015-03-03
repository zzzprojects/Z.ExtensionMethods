using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.Linq;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that removes the letter described by @this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A string.</returns>
        public static string RemoveLetter(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => !Char.IsLetter(x)).ToArray());
        }
    }


}