using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to an u int 64.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an ulong.</returns>
        public static ulong ToUInt64(this object @this)
        {
            return Convert.ToUInt64(@this);
        }
    }
