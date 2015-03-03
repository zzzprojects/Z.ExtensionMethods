using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An Int64 extension method that query if '@this' is multiple of.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="factor">The factor.</param>
        /// <returns>true if multiple of, false if not.</returns>
        public static bool IsMultipleOf(this Int64 @this, Int64 factor)
        {
            return @this%factor == 0;
        }
    }


}