using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A Double extension method that converts the @this to a money.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a Double.</returns>
        public static Double ToMoney(this Double @this)
        {
            return Math.Round(@this, 2);
        }
    }


}