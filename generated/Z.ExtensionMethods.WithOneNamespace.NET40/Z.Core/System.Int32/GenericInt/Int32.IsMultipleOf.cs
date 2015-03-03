namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An Int32 extension method that query if '@this' is multiple of.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="factor">The factor.</param>
        /// <returns>true if multiple of, false if not.</returns>
        public static bool IsMultipleOf(this Int32 @this, Int32 factor)
        {
            return @this%factor == 0;
        }
    }


}