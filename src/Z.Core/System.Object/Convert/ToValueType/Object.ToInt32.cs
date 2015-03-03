using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to an int 32.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an int.</returns>
        public static int ToInt32(this object @this)
        {
            return Convert.ToInt32(@this);
        }
    }
