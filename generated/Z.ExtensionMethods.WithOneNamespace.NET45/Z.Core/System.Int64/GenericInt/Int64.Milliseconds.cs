namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An Int64 extension method that milliseconds the given this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A TimeSpan.</returns>
        public static TimeSpan Milliseconds(this Int64 @this)
        {
            return TimeSpan.FromMilliseconds(@this);
        }
    }


}