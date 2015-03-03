using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A Random extension method that flip a coin toss.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true 50% of time, otherwise false.</returns>
        public static bool CoinToss(this Random @this)
        {
            return @this.Next(2) == 0;
        }
    }


}