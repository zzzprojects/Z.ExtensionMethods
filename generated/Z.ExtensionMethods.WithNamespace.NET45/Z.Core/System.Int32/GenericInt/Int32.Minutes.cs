using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An Int32 extension method that minutes the given this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A TimeSpan.</returns>
        public static TimeSpan Minutes(this Int32 @this)
        {
            return TimeSpan.FromMinutes(@this);
        }
    }


}