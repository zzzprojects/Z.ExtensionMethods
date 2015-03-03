using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A TimeSpan extension method that add the specified TimeSpan to the current UTC (Coordinated Universal Time)
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The current UTC (Coordinated Universal Time) with the specified TimeSpan added to it.</returns>
        public static DateTime UtcFromNow(this TimeSpan @this)
        {
            return DateTime.UtcNow.Add(@this);
        }
    }


}