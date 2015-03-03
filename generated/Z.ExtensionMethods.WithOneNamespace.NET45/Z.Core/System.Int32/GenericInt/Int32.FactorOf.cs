namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An Int32 extension method that factor of.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="factorNumer">The factor numer.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool FactorOf(this Int32 @this, Int32 factorNumer)
        {
            return factorNumer%@this == 0;
        }
    }


}