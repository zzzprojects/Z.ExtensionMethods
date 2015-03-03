using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An Int32 extension method that query if '@this' is odd.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if odd, false if not.</returns>
        public static bool IsOdd(this Int32 @this)
        {
            return @this%2 != 0;
        }
    }
